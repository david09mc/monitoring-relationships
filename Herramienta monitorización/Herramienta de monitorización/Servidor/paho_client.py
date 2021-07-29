import paho.mqtt.client as mqtt
import datetime
import sys
from tratamiento_datos import *
from classes import Neo4jConnection

# Diccionario de direcciones MAC para filtrar.
knownMACs = {0 : '24:A1:60:75:E4:68', 1 : '24:A1:60:75:E4:B0', 2 : '24:A1:60:75:E4:79', 
             3 : '24:A1:60:75:E4:C3', 4 : '24:A1:60:75:E4:92', 5 : '24:A1:60:75:E4:A1',
             6 : '24:A1:60:75:E4:54', 7 : '24:A1:60:75:E4:D7', 8 : '24:A1:60:75:E4:06',
             9 : '24:A1:60:75:E4:87'}


# Se ejecuta cada vez que se recibe un mensaje.
def on_message(client, userdata, message):
    # Se separa una cadena en 3 elementos distintos, siendo el primero la dirección MAC del dispositivo que envía el mensaje, el segundo la MAC del dispositivo que detecta y el tercero la señal RSSI detectada.
    msg = str(message.payload.decode('utf-8')).split(',')

    try :
        # Se coge el valor absoluto de la señal RSSI porque se envía un valor negativo.
        rssi = int(msg[2])
        # Comprueba que la dirección MAC detectada está en el diccionario de MACs para filtrar.
        if msg[1] in knownMACs.values() and rssi > -90:
            cercanía = ''
            hora = datetime.datetime.now().hour
            if rssi > -45:
                cercanía = 'Muy cerca'
            elif rssi > -75:
                cercanía = 'Cerca'
            else:
                cercanía = 'Cercanía moderada'
            #Si no hay relacion de un nodo a otro en ambos sentidos, se crea una.
            if (conn.query(check_relationship(msg[0], msg[1], hora)).__len__() == 0) and (conn.query(check_relationship(msg[1], msg[0], hora)).__len__() == 0):
                conn.query(create_relationship(msg[0], msg[1], cercanía, hora))
            #Si hay relación de un nodo a otro pero no a la inversa, se modifica el valor RSSI de la relación ya existente.
            elif (conn.query(check_relationship(msg[0], msg[1], hora)).__len__() == 0):
                conn.query(modify_relationship(msg[1], msg[0], cercanía, hora))
            else :
                conn.query(modify_relationship(msg[0], msg[1], cercanía, hora))
    except TypeError as e:
        print(e)
        pass
    except:
        pass

# Se ejecuta cuando el cliente se conecta al broker MQTT remoto.
def on_connect(client, userdata, flags, rc): 
    print('Conectado con el código: {0}'.format(str(rc)))
    # Se subscribe al topic.
    client.subscribe('TFG/Acreditacion/Datos') 
    
# Se leen los csv con los datos obtenidos del formulario a los alumnos y el que tiene información sobre el profesor.
# Se crean los objetos correspondientes para la creación de consultas para la base de datos basada en grafos. 
print('Leyendo datos de los participantes...')
read_students = read_csv(sys.path[0]+'\datos_contextuales.csv')
students = get_students_data(read_students, knownMACs)
read_teacher = read_csv(sys.path[0]+'\profesor.csv')
teacher = get_teacher_data(read_teacher, '24:A1:60:75:E4:12')

#Se conecta a la base de datos Neo4j y crea los nodos con la información previa.
print('Estableciendo conexión con la base de datos...')
conn = Neo4jConnection('bolt://localhost:7687/', 'user', 'password')
print('Creando nodos en base de datos...')
if conn.query(get_graph()).__len__() == 0:
    conn.query(insert_teacher(teacher))
    conn.query(create_students(students))

# Se conecta al broquer MQTT remoto para obtener la información procedente de los dispositivos.
broker_address='broker.hivemq.com'
client = mqtt.Client('paho_client')
client.on_message=on_message
client.on_connect=on_connect 
print('Estableciendo conexión con el broker mqtt...')
client.connect(broker_address, 1883)
client.publish('TFG/Acreditacion/Monitorizacion','GO', qos=1, retain=True)

# Hace un bucle infinito para detectar constantemente las nuevas relaciones registradas.
try:
    client.loop_forever()
except:
    client.publish('TFG/Acreditacion/Monitorizacion','END', qos=1, retain=True)
    sys.exit(1)

client.disconnect()
conn.close()
