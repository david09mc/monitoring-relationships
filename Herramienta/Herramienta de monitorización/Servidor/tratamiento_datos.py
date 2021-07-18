import csv
from classes import *

# Obtiene un array de diccionarios con la información de las filas del csv.
def read_csv (csvFile):
    results = []
    with open(csvFile) as File:
        reader = csv.DictReader(File)
        for row in reader:
            results.append(row)
        return results

# Obtiene un array de alumnos con toda la información de los diccionarios obtenidos del csv y las direcciones MAC filtradas.
def get_students_data(results, knownMACs):
    students = []
    try:
        # Obtiene un array de intereses a partir de una cadena con valores separados por comas.
        for i in range (0, results.__len__()):
            n_extravers = 0
            intereses = results[i]['Intereses'].split(", ")

            # Cuenta el número de respuestas 'SI' a las preguntas del test de personalidad de Eysenck para sacar el grado 
            # de extraversion sacando el porcentaje respuestas afirmaticas sobre el total de preguntas.
            for j in range(1,13):
                if (results[i]['Eysenck '+str(j)] == 'SI'):
                    n_extravers += 1
            extravers_scale = round((n_extravers / 12) * 100, 2)
            
            alumno = Alumno(knownMACs[i], results[i]['Nombre'], int(results[i]['Edad']), results[i]['Genero'], 
                            results[i]['Procedencia'], intereses, int(results[i]['Autoeficacia']), 
                            int(results[i]['Motivacion estudios']), int(results[i]['Motivacion asignatura']), 
                            extravers_scale, float(results[i]['Nota media']), results[i]['Dias estudio'], 
                            results[i]['Horas estudio'], results[i]['Asistencia'], results[i]['Relacion profesor'])

            students.append(alumno)
    except KeyError as e:
        print ('[ERROR] El número de alumnos participantes es mayor que el número de direcciones MAC registradas: ', e)  
    return students

# Obtiene un objeto "Profesor" con la información obtenida del csv y la dirección MAC que se le asigna.
def get_teacher_data(teacher, mac):
    profesor = Profesor(mac, teacher[0]['Nombre'], teacher[0]['Area'], teacher[0]['Asignatura'])
    return profesor

# Devuelve una consulta que permite crear un nodo de tipo Profesor en la base de datos.
def insert_teacher(teacher):
    query =  'CREATE (profesor:Profesor {mac:\''+teacher.mac+'\', nombre:\''+teacher.nombre+'\', '
    query += 'area:\''+teacher.area+'\', asignatura:\''+teacher.asignatura+'\'})\n'
    return query

# Devuelve una consulta que permite crear un nodo de tipo Alumno en la base de datos.
def insert_student(student, n_student):
    query =  'CREATE (alumno'+str(n_student)+':Alumno {mac:\''+student.mac+'\', '
    query += 'nombre:\''+student.nombre+'\', edad:\''+str(student.edad)+'\', '
    query += 'genero:\''+student.genero+'\', procedencia:\''+student.procedencia+'\', '
    query += 'intereses:'+student.intereses+', autoeficacia:\''+str(student.autoeficacia)+'\', '
    query += 'mot_estudios:\''+str(student.mot_estudios)+'\', mot_asignatura:\''+str(student.mot_asignatura)+'\', '
    query += 'extraversion:\''+str(student.extraversion)+'\', nota:\''+str(student.nota)+'\', '
    query += 'dias_estudio:\''+student.dias_estudio+'\', horas_estudio:\''+student.horas_estudio+'\', '
    query += 'asistencia:\''+student.asistencia+'\', relacion_prof:\''+student.relacion_prof+'\'})\n'
    return query

# Devuelve una consulta que permite crear varios nodos de tipo Alumno en la base de datos.
def create_students(students):
    query = ''
    for i in range (0, students.__len__()):
        query += insert_student(students[i],i+1)
    return query

# Devuelve una consulta que permite comprobar si entre dos nodos hay algún tipo de relación.
def check_relationship (mac1, mac2, hour):
    query = 'MATCH (a{mac:\''+mac1+'\'})-[r{hora:\''+str(hour)+'\'}]->(b{mac:\''+mac2+'\'}) RETURN r'
    return query

# Devuelve una consulta que permite crear una relación de cercania entre dos nodos asginándole además un valor RSSI.
def create_relationship (mac1, mac2, rssi, hour):
    query = 'MATCH (a:Alumno {mac:\''+mac1+'\'}), (b:Alumno {mac:\''+mac2+'\'}) CREATE (a)-[r:CERCA_DE {rssi:\''+rssi+'\', hora:\''+str(hour)+'\'}]->(b)'
    return query

# Devuelve una consulta que permite modificar el valor RSSI que determina una distancia entre dos nodos.
def modify_relationship (mac1, mac2, rssi):
    query = 'MATCH (a{mac:\''+mac1+'\'})-[r]->(b{mac:\''+mac2+'\'}) SET r.rssi = \''+rssi+'\''
    return query

# Devuelve una consulta para obtener el grafo creado (o una lista vacía si no hay nada).
def get_graph():
    query = 'MATCH (n) RETURN n'
    return query

# Devuelve una consulta para eliminar todos los nodos y relaciones en el grafo.
def delete_graph():
    query = 'MATCH (n) DETACH DELETE n'
    return query
