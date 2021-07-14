from neo4j import GraphDatabase

class Alumno:
    def __init__(self, macaddress, name, age, gender, town, interests, autoefficacy, studies, subject, extravers, marks, days, hours, attendance, teacher):
        self.mac = macaddress
        self.nombre = name
        self.edad = age
        self.genero = gender
        self.procedencia = town
        self.intereses = interests
        self.autoeficacia = autoefficacy
        self.mot_estudios = studies
        self.mot_asignatura = subject
        self.extraversion = extravers 
        self.nota = marks
        self.dias_estudio = days
        self.horas_estudio = hours
        self.asistencia = attendance
        self.relacion_prof = teacher

class Profesor:
    def __init__(self, macaddress, name, a, subject):
        self.mac = macaddress
        self.nombre = name
        self.area = a
        self.asignatura = subject

class Neo4jConnection:
    def __init__(self, uri, user, pwd):
        self.__uri = uri
        self.__user = user
        self.__pwd = pwd
        self.__driver = None
        try:
            self.__driver = GraphDatabase.driver(self.__uri, auth=(self.__user, self.__pwd))
        except Exception as e:
            print('Failed to create the driver:', e)
        
    def close(self):
        if self.__driver is not None:
            self.__driver.close()
        
    def query(self, query, db=None):
        assert self.__driver is not None, 'Driver not initialized!'
        session = None
        response = None
        try: 
            session = self.__driver.session(database=db) if db is not None else self.__driver.session() 
            response = list(session.run(query))
        except Exception as e:
            print('Query failed:', e)
        finally: 
            if session is not None:
                session.close()
        return response
