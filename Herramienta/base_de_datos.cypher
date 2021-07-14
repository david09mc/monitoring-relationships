CREATE (profesor:Profesor {mac:'24:A1:60:75:E4:12', nombre:'Ana Isabel Molina Díaz', area: 'Lenguajes y Sistemas Informáticos', asignatura:'Interacción Personal Ordenador I'})
CREATE (alumno1:Alumno {mac:'24:A1:60:75:E4:68', nombre:'David Moreno Carmona', edad:'21', genero:'Hombre', procedencia:'VillacaÃ±as', intereses:['Musica', 'Cine y audiovisuales', 'Tecnologias'], autoeficacia:'4', mot_estudios:'4', mot_asignatura:'5', extraversion:'58.33', nota:'7.0', dias_estudio:'Entre 3 y 5 dias', horas_estudio:'Entre 3 y 4 horas', asistencia:'Frecuente', relacion_prof:'Muy buena'})
CREATE (alumno2:Alumno {mac:'24:A1:60:75:E4:B0', nombre:'Javier Novillo Martin', edad:'21', genero:'Hombre', procedencia:'Toledo', intereses:['Tecnologias', 'Musica', 'Juegos'], autoeficacia:'4', mot_estudios:'4', mot_asignatura:'4', extraversion:'83.33', nota:'7.5', dias_estudio:'Todos los dias', horas_estudio:'Entre 3 y 4 horas', asistencia:'Muy frecuente', relacion_prof:'Buena'})
CREATE (alumno3:Alumno {mac:'24:A1:60:75:E4:79', nombre:'Lydia Moreno Carmona', edad:'21', genero:'Mujer', procedencia:'VillacaÃ±as', intereses:['Lectura', 'Arte y manualidades', 'Cine y audiovisuales'], autoeficacia:'4', mot_estudios:'5', mot_asignatura:'4', extraversion:'75.0', nota:'7.0', dias_estudio:'Entre 1 y 3 dias', horas_estudio:'MÃ¡s de 6 horas', asistencia:'Frecuente', relacion_prof:'Buena'})

'''
CREATE (alumno4:Alumno {mac:'24:A1:60:75:E4:C3', nombre:'Raul Sanchez Castro', edad:'23', genero:'Hombre', procedencia:'Pozorrubio de Santiago', intereses:['Reuniones sociales', 'Arte y manualidades', 'Musica'], autoeficacia:'3', mot_estudios:'2', mot_asignatura:'3', extraversion:'75.0', nota:'6.0', dias_estudio:'Entre 1 y 3 dias', horas_estudio:'Entre 1 y 2 horas', asistencia:'Frecuente', relacion_prof:'Mejorable'}) 
CREATE (alumno5:Alumno {mac:'24:A1:60:75:E4:92', nombre:'Jaime Leon Rosado', edad:'22', genero:'Hombre', procedencia:'Tomelloso', intereses:['Deportes', 'Viajar', 'Tecnologias'], autoeficacia:'4', mot_estudios:'4', mot_asignatura:'4', extraversion:'66.67', nota:'7.6', dias_estudio:'Entre 5 y 6 dias', horas_estudio:'Entre 5 y 6 horas', asistencia:'Muy frecuente', relacion_prof:'Buena'})
CREATE (alumno6:Alumno {mac:'24:A1:60:75:E4:A1', nombre:'Daniela Plasencia Rodriguez ', edad:'23', genero:'Mujer', procedencia:'VillacaÃ±as', intereses:['Lectura', 'Moda', 'Juegos'], autoeficacia:'5', mot_estudios:'5', mot_asignatura:'4', extraversion:'83.33', nota:'7.0', dias_estudio:'Entre 3 y 5 dias', horas_estudio:'Entre 1 y 2 horas', asistencia:'Poco frecuente', relacion_prof:'Mejorable'})
CREATE (alumno7:Alumno {mac:'24:A1:60:75:E4:54', nombre:'Paula Novillo', edad:'21', genero:'Mujer', procedencia:'Tembleque', intereses:['Musica', 'Viajar', 'Arte y manualidades'], autoeficacia:'5', mot_estudios:'2', mot_asignatura:'3', extraversion:'83.33', nota:'8.0', dias_estudio:'Entre 1 y 3 dias', horas_estudio:'Entre 1 y 2 horas', asistencia:'Muy frecuente', relacion_prof:'Buena'})
CREATE (alumno8:Alumno {mac:'24:A1:60:75:E4:D7', nombre:'Silvia Ruiz ', edad:'21', genero:'Mujer', procedencia:'Toledo ', intereses:['Viajar', 'Musica', 'Pintura'], autoeficacia:'4', mot_estudios:'2', mot_asignatura:'3', extraversion:'66.67', nota:'7.9', dias_estudio:'Entre 5 y 6 dias', horas_estudio:'Entre 1 y 2 horas', asistencia:'Muy frecuente', relacion_prof:'Buena'})
CREATE (alumno9:Alumno {mac:'24:A1:60:75:E4:06', nombre:'Elena Maria Ruiz Izquierdo', edad:'24', genero:'Mujer', procedencia:'Fuente el Fresno', intereses:['Viajar', 'Cine y audiovisuales', 'Baile'], autoeficacia:'2', mot_estudios:'2', mot_asignatura:'2', extraversion:'75.0', nota:'7.0', dias_estudio:'Entre 3 y 5 dias', horas_estudio:'Entre 1 y 2 horas', asistencia:'Frecuente', relacion_prof:'Mejorable'})
CREATE (alumno10:Alumno {mac:'24:A1:60:75:E4:87', nombre:'Mihai Marian Dobrin', edad:'22', genero:'Hombre', procedencia:'Lominchar', intereses:['Juegos', 'Lectura', 'Tecnologias'], autoeficacia:'3', mot_estudios:'1', mot_asignatura:'1', extraversion:'41.67', nota:'7.0', dias_estudio:'Ninguno', horas_estudio:'Menos de 1 hora', asistencia:'Frecuente', relacion_prof:'Mejorable'})
'''

// INSERTAR DE UNO EN UNO:

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'8'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'9'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'10'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'11'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'12'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'13'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'17'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'18'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'19'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'20'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'21'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'22'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'8'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'9'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'10'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'11'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'12'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'13'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'17'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Profesor {mac:'24:A1:60:75:E4:12'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'18'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'8'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'14'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'12'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'15'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'17'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'18'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'19'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'20'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:B0'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'21'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'8'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'9'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'10'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'11'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'14'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderada', hora:'15'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'17'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cercanía moderado', hora:'16'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'19'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:68'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'22'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:B0'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'14'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:B0'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Muy cerca', hora:'15'}]->(b)

MATCH (a:Alumno {mac:'24:A1:60:75:E4:B0'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'16'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'12'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'13'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'14'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'21'}]->(b)

MATCH (a:Profesor {mac:'24:A1:60:75:E4:12'}), (b:Alumno {mac:'24:A1:60:75:E4:79'}) CREATE (a)-[r:CERCA_DE {rssi:'Cerca', hora:'22'}]->(b)

// Permite saber si una relación está creada o no a una determinada hora
// MATCH (a{mac:'24:A1:60:75:E4:68'})-[r{hora:'12'}]->(b{mac:'24:A1:60:75:E4:B0'}) RETURN r

// Para modificar las propiedades de cada relación en una determinada hora
// MATCH (a{mac:'24:A1:60:75:E4:68'})-[r{hora:'12'}]->(b{mac:'24:A1:60:75:E4:B0'}) SET r.rssi = 32
