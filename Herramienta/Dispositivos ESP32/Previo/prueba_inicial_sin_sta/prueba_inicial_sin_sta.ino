#include "WiFi.h"
#include <Wire.h>
#include "esp_wifi.h"

#define WIFI_CHANNEL_MAX (13) //max Channel -> US = 11, EU = 13, Japan = 14

int channel = 1;
int listcount = 0;
String maclist[64][2]; 


String KnownMac[10][2] = {  // Put devices you want to be reconized
  {"Placa COM5","24:A1:60:75:E4:68"},
  {"Placa COM6","24:A1:60:75:E4:B0"},
  {"NAME","MACADDRESS"},
  {"NAME","MACADDRESS"},
  {"NAME","MACADDRESS"},
  {"NAME","MACADDRESS"},
  {"NAME","MACADDRESS"},
  {"NAME","MACADDRESS"},
  {"NAME","MACADDRESS"},
  {"NAME","MACADDRESS"}
  
};


//---------------------------------------------------------------------------------------------------------

const wifi_promiscuous_filter_t filt={ //Idk what this does
  .filter_mask= WIFI_PROMIS_FILTER_MASK_MGMT | WIFI_PROMIS_FILTER_MASK_DATA
};

void wifi_sniffer_init(void)
{
  wifi_init_config_t cfg = WIFI_INIT_CONFIG_DEFAULT();
  
  ESP_ERROR_CHECK( esp_wifi_init(&cfg) );
  ESP_ERROR_CHECK( esp_wifi_set_storage(WIFI_STORAGE_RAM) );
  ESP_ERROR_CHECK( esp_wifi_set_mode(WIFI_MODE_NULL) );
  ESP_ERROR_CHECK( esp_wifi_start() );

  esp_wifi_set_promiscuous(true);
  esp_wifi_set_promiscuous_filter(&filt);
  esp_wifi_set_promiscuous_rx_cb(&sniffer);
  esp_wifi_set_channel(channel, WIFI_SECOND_CHAN_NONE);
}

void sniffer(void* buf, wifi_promiscuous_pkt_type_t type) { //This is where packets end up after they get sniffed
  wifi_promiscuous_pkt_t *p = (wifi_promiscuous_pkt_t*)buf;
  int rssi = p->rx_ctrl.rssi;

 
  String packet;
  String mac;

  for(int i=8;i<=8+6+1;i++){ // This reads the first couple of bytes of the packet. This is where you can read the whole packet replaceing the "8+6+1" with "p->rx_ctrl.sig_len"
    packet += String(p->payload[i],HEX);
  }
  for(int i=4;i<=15;i++){ // This removes the 'nibble' bits from the stat and end of the data we want. So we only get the mac address.
    mac += packet[i];
    if (i%2 != 0 && i != 15){
      mac += ":";
    }
  }
  mac.toUpperCase();

  
  boolean added = false;
  for(int i=0;i<=63;i++){ // checks if the MAC address has been added before
    if(mac == maclist[i][0]){
      maclist[i][1] = rssi;
      added = true;
    }
  }
  
  if(!added){ // If its new. add it to the array.
    maclist[listcount][0] = mac;
    maclist[listcount][1] = rssi;
    //Serial.println("Esto guarda en MAC: " + mac + " y esto en RSSI: " + rssi);
    listcount ++;
    if(listcount >= 64){
      Serial.println("Too many addresses");
      listcount = 0;
    }
  }
}

//===== SETUP =====//
void setup() {

  /* start Serial */
  Serial.begin(115200);

  /* setup wifi */
  wifi_sniffer_init();
  
  Serial.println("\nComenzando...\n");
}
 
void printmac(){ // This checks if the MAC is in the reckonized list and then prints it to serial.
  for(int i=0;i<=63;i++){
    String tmp1 = maclist[i][0];
    if(!(tmp1 == "")){
      //Serial.print("MAC: " + tmp1 + " | RSSI: " + maclist[i][1] + "\n -- \n");
      
      for(int j=0;j<10;j++){
        String tmp2 = KnownMac[j][1];
        if(tmp1 == tmp2){
          Serial.print("SSID: " + KnownMac[j][0] + " | MAC: " + tmp1 + " | RSSI: " + maclist[i][1] + "\n -- \n");
          maclist[i][0] = "";
          break;
        }
      }
    }
  }
}

//===== LOOP =====//
void loop() {
    //Serial.println("Changed channel:" + String(channel));
    if(channel > WIFI_CHANNEL_MAX){ 
      channel = 1;
    }
    esp_wifi_set_channel(channel, WIFI_SECOND_CHAN_NONE);
    delay(1000);

    printmac();
    channel++;
    
    
}
