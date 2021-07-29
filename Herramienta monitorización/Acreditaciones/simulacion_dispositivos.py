import paho.mqtt.client as mqtt
import time, sys, random

detectedMACs = {0 : '24:A1:60:75:E4:68', 1 : '24:A1:60:75:E4:B0', 2 : '24:A1:60:75:E4:79', 
                3 : '24:A1:60:75:E4:C3', 4 : '24:A1:60:75:E4:92', 5 : '24:A1:60:75:E4:A1',
                6 : '24:A1:60:75:E4:54', 7 : '24:A1:60:75:E4:D7', 8 : '24:A1:60:75:E4:06',
                9 : '24:A1:60:75:E4:87', 10 : '24:A1:60:75:E4:12'}

senderMACs = {0 : '24:A1:60:75:E4:79', 1 : '24:A1:60:75:E4:C3', 2 : '24:A1:60:75:E4:92', 
              3 : '24:A1:60:75:E4:A1', 4 : '24:A1:60:75:E4:54', 5 : '24:A1:60:75:E4:D7',
              6 : '24:A1:60:75:E4:06', 7 : '24:A1:60:75:E4:87', 8 : '24:A1:60:75:E4:12'}

# Se ejecuta cada vez que se recibe un mensaje.
def on_message(client, userdata, message):
    global start
    msg = str(message.payload.decode('utf-8'))
    if msg == 'GO':
        print('Comenzando monitorización...')
        start = True
    elif msg == 'END':
        print('Finalizando monitorización...')
        start = False

# Se ejecuta cuando el cliente se conecta al broker MQTT remoto.
def on_connect(client, userdata, flags, rc): 
    print('Conectado con el código: {0}'.format(str(rc)))
    client.subscribe('TFG/Acreditacion/Monitorizacion') 

if len(sys.argv) == 2:
    mac = sys.argv[1]
    if mac in senderMACs.values():
        detectedMACs.pop(list(detectedMACs.values()).index(mac))
        rssiDict = dict.fromkeys(detectedMACs.values())
        for key in rssiDict.keys():
            rssiDict[key] = random.randrange(-95, -20)

        broker_address='broker.hivemq.com'
        client = mqtt.Client('simulador_acreditación')
        client.on_message=on_message
        client.on_connect=on_connect 
        print('Estableciendo conexión con el broker mqtt...')

        client.connect(broker_address, 1883)

        start = False

        while True:
            detected_mac = detectedMACs.get(random.choice(list(detectedMACs.keys())))
            try:
                client.loop()
                if start is True:
                    message = mac+','+detected_mac+','+str(rssiDict.get(detected_mac))
                    client.publish('TFG/Acreditacion/Datos', message)
                    time.sleep(4)
            except:
                break

        client.disconnect()
        
    else:
        print('ERROR: La dirección MAC no es válida.')
else:
    print('ERROR: Introduce una dirección MAC')
