#include "WiFi.h"
#include "esp_wifi.h"
#include <PubSubClient.h>

#define WIFI_CHANNEL_MAX (13) //Max Channel -> US = 11, EU = 13, Japan = 14.

/*//--------Filtar MACs---------------------------------------------//
String KnownMac[10][2] = {  
  {"SMART INSIGNIA 1","24:A1:60:75:E4:68"},
  {"SMART INSIGNIA 2","24:A1:60:75:E4:B0"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"},
  {"NOMBRE","FF:FF:FF:FF:FF:FF"}
};
//----------------------------------------------------------------//*/

//Se define el servidor MQTT, el topic y el cliente para enviar los mensajes
const char* mqtt_server = "broker.hivemq.com";
const char* topicEnvio = "David/TFG/Info";
const char* topicRecibir = "David/TFG/Start";
WiFiClient espClient;
PubSubClient client(espClient);
long lastMsg = 0;

//--------------------------------------------------------------------------------------------------------//

int channel = 1;
int listcount = 0;
boolean start = false;
String maclist[64][2]; //Lista de direcciones MAC conocidas.
String send[2];
String message;

//Filtro para la transmisión de paquetes en modo promiscuo.
const wifi_promiscuous_filter_t filt={ 
  .filter_mask= WIFI_PROMIS_FILTER_MASK_MGMT | WIFI_PROMIS_FILTER_MASK_DATA
};

//Manejador de los paquetes interceptados.
void sniffer_handler(void* buf, wifi_promiscuous_pkt_type_t type) {
  wifi_promiscuous_pkt_t *p = (wifi_promiscuous_pkt_t*)buf;
  int rssi = p->rx_ctrl.rssi;

  String packet;
  String mac;

  for(int i=10;i<=15;i++){ //Lee los primeros pares de bytes del paquete correspondientes a la dirección MAC. Se comienza a contar desde la posición 10 y se cogen los 6 pares siguientes.
    mac += String(p->payload[i],HEX);
    if (i != 15){
      mac += ":";
    }
  }

  mac.toUpperCase();

  boolean added = false;
  for(int i=0;i<=63;i++){ //Comprueba que la dirección MAC se haya añadido antes y le asigna un valor RSSI para guardarlos en la lista de MACs conocidas.
    if(mac == maclist[i][0]){
      maclist[i][1] = rssi;
      added = true;
    }
  }
  
  if(!added){ //Si es nueva, se añade a la lista.
    maclist[listcount][0] = mac;
    maclist[listcount][1] = rssi;
    listcount ++;
    if(listcount >= 64){
      Serial.println("Nº de direcciones MAC almacenadas muy alto, sobreescribiendo...");
      listcount = 0;
    }
  }
}

//Configuración inicial.
void initial_config(void)
{
  wifi_init_config_t cfg = WIFI_INIT_CONFIG_DEFAULT();
  
  ESP_ERROR_CHECK( esp_wifi_init(&cfg) );
  ESP_ERROR_CHECK( esp_wifi_set_storage(WIFI_STORAGE_RAM) );
  ESP_ERROR_CHECK( esp_wifi_set_mode(WIFI_MODE_NULL) );
  ESP_ERROR_CHECK( esp_wifi_start() );

  esp_wifi_set_promiscuous(true);
  esp_wifi_set_promiscuous_filter(&filt);
  esp_wifi_set_promiscuous_rx_cb(&sniffer_handler);
  esp_wifi_set_channel(channel, WIFI_SECOND_CHAN_NONE);
}

//Imprime la dirección MAC detectada y la señal RSSI.
void sendmac(){ 
  for(int i=0;i<=63;i++){
    String tmp1 = maclist[i][0];
    if(!(tmp1 == "")){

      //Obtiene todas las MACs del entorno sin filtrar
      send[0] = tmp1;
      send[1] = maclist[i][1];
      
      //Descomentar esta sección para filtrar la dirección MAC con las que se han predefinido.
      /*
      for(int j=0;j<10;j++){ 
        String tmp2 = KnownMac[j][1];
        if(tmp1 == tmp2){
          send[0] = tmp1;
          send[1] = maclist[i][1];
          Serial.print("NOMBRE: " + KnownMac[j][0] + " | MAC: " + tmp1 + " | RSSI: " + maclist[i][1] + "\n -- \n");
          maclist[i][0] = "";
          break;
        }
      }
      */

    }
  }
}

//--------------------------------------------------------------------------------------------------------//

//Función callback para el envío de mensajes con el protocolo MQTT
void callback(char* topic, byte* message, unsigned int length) {
  Serial.print("Mensaje recibido en topic: ");
  Serial.print(topic);
  Serial.print(". Mensaje: ");
  String messageTemp;
  for (int i = 0; i < length; i++) {
    Serial.print((char)message[i]);
    messageTemp += (char)message[i];
  }
  Serial.println();

  if (String(topic) == topicRecibir) {

    if(messageTemp == "GO"){
      Serial.println("Comenzando monitorización...");
      //client.publish(topicRecibir, )
      start = true;
    }
    else if(messageTemp == "END"){
      Serial.println("Finalizando monitorización...");
      start = false;
    }
  }
}

//Función para reconectar con el servidor MQTT
void reconnect() {
  //Bucle hasta que reconecte
  while (!client.connected()) {
    Serial.print("Intentando conectar con el servidor MQTT...");
    //Intenta conectarse al servidor
    if (client.connect(mqtt_server)) {
      Serial.println("¡Conectado!");
      //Se subscribe a los topics predefinidos para el intercambio de mensajes
      //client.subscribe(topicEnvio);
      client.subscribe(topicRecibir);
    } else {
      Serial.print("Fallo, rc=");
      Serial.print(client.state());
      Serial.println("Volviendo a intentar en 2 segundos...");
      //Espera 2 segundos para volver a intentar conectarse
      delay(2000);
    }
  }
}
//--------------------------------------------------------------------------------------------------------//

//------ SETUP ------//
void setup() {

  Serial.begin(115200);
  //Configuración inicial.
  initial_config();

  client.setServer(mqtt_server, 1883);
  client.setCallback(callback);
  
  Serial.println("\nIniciando...\n");

}

//------LOOP ------//
void loop() {
  if(start) {
    //Si se pasa del número máximo del canal, se reinicia.
    if(channel > WIFI_CHANNEL_MAX){ 
      channel = 1;
    }
    esp_wifi_set_channel(channel, WIFI_SECOND_CHAN_NONE);
      
    sendmac();
    delay(2000);
    //Se cambia del modo promiscuo al modo estación para que otros dispositivos lo detecten.
    ESP_ERROR_CHECK(esp_wifi_set_promiscuous(false));
  }

    WiFi.mode(WIFI_MODE_STA);
    if (WiFi.status() != WL_CONNECTED) {
      Serial.println("Conectándose a red...");
      WiFi.begin("SSID","Password");
    }
    //Se conecta a una red.
    delay(1000);
    
//--------------------------------------------------------------------------------------------------------//
    //Si no está conectado, se reconecta al servidor
    if (!client.connected()) {
      reconnect();
    }
    
    client.loop();
    delay(1000);
    if(start) {
      message = WiFi.macAddress() + "," + send[0] + "," + send[1] ;
      client.publish(topicEnvio, message.c_str() );
  //--------------------------------------------------------------------------------------------------------//

      //Se cambia del modo estación al modo promiscuo para seguir detectando dispositivos.
      ESP_ERROR_CHECK(esp_wifi_set_promiscuous(true));

      
      channel++;
    }
    
}