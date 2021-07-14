using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Neo4j.Driver;
using QuickGraph;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz.Dot;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace graphvisualization
{

    public partial class Form1 : Form
    {
        internal const int CTRL_C_EVENT = 0;
        [DllImport("kernel32.dll")]
        internal static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AttachConsole(uint dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        internal static extern bool FreeConsole();
        [DllImport("kernel32.dll")]

        static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);
        delegate Boolean ConsoleCtrlDelegate(uint CtrlType);

        public static string _personAtribute { get; set; } = "nombre";
        Dictionary<string, Person> _peopleDict = new Dictionary<string, Person>();
        List<string> _peopleList = new List<string>();
        private Image _imgOriginal;
        ProcessStartInfo pythonStartInfo = new ProcessStartInfo();
        Process python = new Process();

        public Form1()
        {
            InitializeComponent();
        }

        public class Person
        {
            public string mac { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public Person(string mac, string name)
            {
                this.mac = mac;
                this.name = name;
            }
        }

        public class Teacher : Person
        {
            public string area { get; set; }
            public string subject { get; set; }
            public Teacher(string mac, string name, string area, string subject) : base(mac, name)
            {
                this.area = area;
                this.subject = subject;
                this.type = "Teacher";
            }
        }

        public class Student : Person
        {
            public string age { get; set; }
            public string gender { get; set; }
            public string town { get; set; }
            public List<string> interests { get; set; }
            public string autoefficacy { get; set; }
            public string mot_studies { get; set; }
            public string mot_subject { get; set; }
            public string extraversion { get; set; }
            public string mark { get; set; }
            public string study_days { get; set; }
            public string study_hours { get; set; }
            public string attendance { get; set; }
            public string teacher_relationship { get; set; }
            public Student(string mac, string name, string age, string gender, string town, List<string> interests, string autoefficacy, string mot_studies, string mot_subject, string extraversion, string mark, string study_days, string study_hours, string attendance, string teacher_relationship) : base(mac, name)
            {
                this.age = age;
                this.gender = gender;
                this.town = town;
                this.interests = interests;
                this.autoefficacy = autoefficacy;
                this.mot_studies = mot_studies;
                this.mot_subject = mot_subject;
                this.extraversion = extraversion;
                this.mark = mark;
                this.study_days = study_days;
                this.study_hours = study_hours;
                this.attendance = attendance;
                this.teacher_relationship = teacher_relationship;
                this.type = "Student";
            }
        }

        public sealed class FileDotEngine : IDotEngine
        {
            public string Run(GraphvizImageType imageType, string dot, string outputFileName)
            {
                string output = outputFileName;
                File.WriteAllText(output, dot);
                ProcessStartInfo procStartInfo = new ProcessStartInfo();
                procStartInfo.FileName = @"dot";
                procStartInfo.Arguments = $@"{output} -Tpng -o grafo.png";
                procStartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                procStartInfo.UseShellExecute = true;
                Process proc = new Process();
                proc.StartInfo = procStartInfo;

                if (!proc.Start())
                {
                    Process.Start(@"./graphviz-x64-install-2.47.3-win64.exe");
                    MessageBox.Show("Pruebe a ejecutar el programa de nuevo después de la instalación...");
                }

                return output;
            }
        }

        public AdjacencyGraph<string, TaggedEdge<string, string>> Neo4jQuery(string hora)
        {
            IResult result;
            string nombre;
            using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("user", "password")))
            using (var session = driver.Session())
            {
                var g = new AdjacencyGraph<string, TaggedEdge<string, string>>();

                result = session.Run($"MATCH (n:Profesor) " +
                    $"RETURN n.nombre AS nombre, n.mac AS mac, n.area AS area, n.asignatura AS asignatura");
                foreach (var record in result)
                {
                    nombre = record["nombre"].As<string>();
                    g.AddVertex(nombre);
                    if (!_peopleDict.ContainsKey(nombre))
                    {
                        _peopleDict.Add(nombre,
                            new Teacher(record["mac"].As<string>(), nombre, record["area"].As<string>(), record["asignatura"].As<string>()));

                    }
                }

                result = session.Run($"MATCH (n:Alumno) " +
                    $"RETURN n.nombre AS nombre, n.mac AS mac, n.edad AS edad, n.genero AS genero, n.procedencia AS procedencia," +
                    $" n.intereses AS intereses, n.autoeficacia AS autoeficacia, n.mot_estudios AS mot_estudios, n.mot_asignatura AS mot_asignatura, n.extraversion AS extraversion," +
                    $" n.nota AS nota, n.dias_estudio AS dias_estudio, n.horas_estudio AS horas_estudio, n.asistencia AS asistencia, n.relacion_prof AS relacion_prof");
                foreach (var record in result)
                {
                    string interest;
                    List<string> interests = new List<string>();
                    foreach (var inter in record["intereses"].As<List<string>>())
                    {
                        interest = inter.As<string>();
                        if (!interests.Contains(interest))
                        {
                            interests.Add(interest);
                        }
                    }

                    nombre = record["nombre"].As<string>();
                    g.AddVertex(nombre);
                    if (!_peopleDict.ContainsKey(nombre))
                    {
                        _peopleDict.Add(nombre,
                        new Student(record["mac"].As<string>(), nombre, record["edad"].As<string>(), record["genero"].As<string>(), record["procedencia"].As<string>(),
                                    interests, record["autoeficacia"].As<string>(), record["mot_estudios"].As<string>(), record["mot_asignatura"].As<string>(), record["extraversion"].As<string>(),
                                    record["nota"].As<string>(), record["dias_estudio"].As<string>(), record["horas_estudio"].As<string>(), record["asistencia"].As<string>(), record["relacion_prof"].As<string>()));
                    }

                }

                result = session.Run($"MATCH ((a)-[r:CERCA_DE{{hora:'{hora}'}}]->(b)) RETURN a.nombre AS nombre1, r.rssi AS rssi, r.hora AS hora, b.nombre AS nombre2");
                foreach (var record in result)
                    g.AddEdge(new TaggedEdge<string, string>(record["nombre1"].As<string>(), record["nombre2"].As<string>(), record["rssi"].As<string>()));

                foreach (var person in _peopleDict.Keys)
                {
                    if (!_peopleList.Contains(person))
                        _peopleList.Add(person);
                }
                listAlumnos.DataSource = _peopleList;
                grafoPicBox.Tag = hora;

                return g;
            }
        }

        public AdjacencyGraph<string, TaggedEdge<string, string>> Neo4jQuery(string atributo, string hora)
        {
            IResult result;
            string nombre;
            string interest;
            List<string> interests = new List<string>();
            using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("user", "password")))
            using (var session = driver.Session())
            {
                var g = new AdjacencyGraph<string, TaggedEdge<string, string>>();

                result = session.Run($"MATCH (n:Profesor) " +
                    $"RETURN n.nombre AS nombre, n.mac AS mac, n.area AS area, n.asignatura AS asignatura");
                foreach (var record in result)
                {
                    nombre = record["nombre"].As<string>();
                    g.AddVertex(nombre);
                    if (!_peopleDict.ContainsKey(nombre))
                    {
                        _peopleDict.Add(nombre,
                        new Teacher(record["mac"].As<string>(), nombre, record["area"].As<string>(), record["asignatura"].As<string>()));
                    }
                    }

                result = session.Run($"MATCH (n:Alumno) " +
                    $"RETURN n.nombre AS nombre, n.mac AS mac, n.edad AS edad, n.genero AS genero, n.procedencia AS procedencia," +
                    $" n.intereses AS intereses, n.autoeficacia AS autoeficacia, n.mot_estudios AS mot_estudios, n.mot_asignatura AS mot_asignatura, n.extraversion AS extraversion," +
                    $" n.nota AS nota, n.dias_estudio AS dias_estudio, n.horas_estudio AS horas_estudio, n.asistencia AS asistencia, n.relacion_prof AS relacion_prof");
                foreach (var record in result)
                {
                    foreach (var inter in record["intereses"].As<List<string>>())
                    {
                        interest = inter.As<string>();
                        if (!interests.Contains(interest))
                        {
                            interests.Add(interest);
                        }
                    }

                    nombre = record["nombre"].As<string>();
                    g.AddVertex(nombre + ": " + record[atributo].As<string>());
                    if (!_peopleDict.ContainsKey(nombre))
                    {
                        _peopleDict.Add(nombre,
                        new Student(record["mac"].As<string>(), nombre, record["edad"].As<string>(), record["genero"].As<string>(), record["procedencia"].As<string>(),
                                    interests, record["autoeficacia"].As<string>(), record["mot_estudios"].As<string>(), record["mot_asignatura"].As<string>(), record["extraversion"].As<string>(),
                                    record["nota"].As<string>(), record["dias_estudio"].As<string>(), record["horas_estudio"].As<string>(), record["asistencia"].As<string>(), record["relacion_prof"].As<string>()));
                    }
                    
                }

                result = session.Run($"MATCH ((a:Profesor)-[r:CERCA_DE{{hora:'{hora}'}}]-(b:Alumno)) " +
                    $"RETURN a.nombre AS nombre_prof, r.rssi AS rssi, r.hora AS hora, b.nombre AS nombre_alum, b.{atributo} AS {atributo}");
                foreach (var record in result)
                    g.AddEdge(new TaggedEdge<string, string>(record["nombre_alum"].As<string>() + ": " + record[atributo].As<string>(), record["nombre_prof"].As<string>(), record["rssi"].As<string>()));

                result = session.Run($"MATCH ((a:Alumno)-[r:CERCA_DE{{hora:'{hora}'}}]->(b:Alumno)) " +
                    $"RETURN a.nombre AS nombre1, a.{atributo} AS {atributo}1, r.rssi AS rssi, r.hora AS hora, b.nombre AS nombre2, b.{atributo} AS {atributo}2");
                foreach (var record in result)
                    g.AddEdge(new TaggedEdge<string, string>(record["nombre1"].As<string>()+": "+record[atributo + "1"].As<string>(), record["nombre2"].As<string>() + ": " + record[atributo + "2"].As<string>(), record["rssi"].As<string>()));

                foreach (var person in _peopleDict.Keys)
                {
                    if(!_peopleList.Contains(person))
                        _peopleList.Add(person);
                }
                listAlumnos.DataSource = _peopleList;
                grafoPicBox.Tag = hora;
                return g;
            }
        }

        public void DrawGraph(AdjacencyGraph<string, TaggedEdge<string, string>> g)
        {
            GraphvizAlgorithm<string, TaggedEdge<string, string>> graphviz = new GraphvizAlgorithm<string, TaggedEdge<string, string>>(g);
            
            graphviz.FormatVertex += (sender, args) => args.VertexFormatter.Comment = args.Vertex.ToString();
            graphviz.FormatVertex += (sender, args) => args.VertexFormatter.Style = GraphvizVertexStyle.Filled;

            graphviz.FormatEdge += (sender, args) => { args.EdgeFormatter.Label.Value = args.Edge.Tag; };            
            graphviz.Generate(new FileDotEngine(), "grafo.dot");
            
            System.Threading.Thread.Sleep(500);

            FileStream fs = new FileStream("grafo.png", FileMode.Open, FileAccess.Read);
            grafoPicBox.Image = Image.FromStream(fs);
            _imgOriginal = grafoPicBox.Image;
            fs.Close();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Herramienta de monitorización";
            pythonStartInfo.FileName = @"python";
            pythonStartInfo.Arguments = $@"./paho_client.py";
            pythonStartInfo.WorkingDirectory = $"./Servidor";
            pythonStartInfo.UseShellExecute = true;
            python.StartInfo = pythonStartInfo;
            if (!python.Start())
            {
                Process.Start(@"./python-3.9.6-amd64.exe");
                MessageBox.Show("Pruebe a ejecutar el programa de nuevo después de la instalación...");
            }

            this.DoubleBuffered = true;

            int hour = DateTime.Now.Hour;
            if (hour>22)
            {
                hour = 22;
            } else if (hour<8) {
                hour = 8;
            }
            _personAtribute = "nombre";
            DrawGraph(Neo4jQuery(hour.ToString()));
            
            zoomBar.Minimum = 1;
            zoomBar.Maximum = 5;
            zoomBar.SmallChange = 1;
            zoomBar.LargeChange = 1;
            zoomBar.UseWaitCursor = false;
        }

        public Image PictureBoxZoom(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            if (zoomBar.Value > 0)
            {
                grafoPicBox.Image = null;
                grafoPicBox.Image = PictureBoxZoom(_imgOriginal, new Size(zoomBar.Value, zoomBar.Value));
            }
        }

        private void timeBar_Scroll(object sender, EventArgs e)
        {
            if (_personAtribute == "nombre")
            {
                DrawGraph(Neo4jQuery(timeBar.Value.ToString()));
            }
            else
            {
                DrawGraph(Neo4jQuery(_personAtribute, timeBar.Value.ToString()));
            }
        }

        private void nombreButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "nombre";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(hour.ToString()));
        }

        private void horasEstudButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "horas_estudio";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void motEstudButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "mot_estudios";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void edadButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "edad";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void generoButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "genero";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void extraversButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "extraversion";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void notaButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "nota";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void asistenciaButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "asistencia";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void autoeficaciaButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "autoeficacia";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void motAsignButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "mot_asignatura";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void díasEstudButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "dias_estudio";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void relacionProfButton_CheckedChanged(object sender, EventArgs e)
        {
            _personAtribute = "relacion_prof";
            var hour = grafoPicBox.Tag;
            DrawGraph(Neo4jQuery(_personAtribute, hour.ToString()));
        }

        private void eliminrBBDDButton_Click(object sender, EventArgs e)
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("user", "password")))
            using (var session = driver.Session())
            {
                var g = new AdjacencyGraph<string, TaggedEdge<string, string>>();

                session.Run("MATCH (n) DETACH DELETE n");
            }
        }

        private void finButton_Click(object sender, EventArgs e)
        {
            while (MessageBox.Show("¿Quieres salir de la aplicación?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (AttachConsole((uint)python.Id))
                {
                    SetConsoleCtrlHandler(null, true);
                    try
                    {
                        if (!GenerateConsoleCtrlEvent(CTRL_C_EVENT, 0))
                            python.WaitForExit();
                    }
                    finally
                    {
                        SetConsoleCtrlHandler(null, false);
                        FreeConsole();
                    }
                }
                this.TopMost = false;
                this.Dispose();
                this.Close();
                Application.Exit();
            }
        }

        private void listAlumnos_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "";
            int index = this.listAlumnos.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string name = listAlumnos.Items[index].ToString();
                Person person = _peopleDict[name];
                if (person.type == "Teacher")
                {
                    Teacher teacher = (Teacher)person;
                    message = $"NOMBRE: {teacher.name}\n\n" +
                        $"ÁREA DE CONOCIMIENTO: {teacher.area}\n\n" +
                        $"ASIGNATURA: {teacher.subject}";

                }
                else if (person.type == "Student")
                {
                    Student student = (Student)person;
                    string interests = "";
                    foreach (string st in student.interests)
                    {
                        interests += st.ToString() + " | ";
                    }
                    interests = interests.Remove(interests.Length-3);
                    message = $"NOMBRE: {student.name}\n\n" +
                        $"EDAD: {student.age}\n\n" +
                        $"GÉNERO: {student.gender}\n\n" +
                        $"PROCEDENCIA: {student.town}\n\n" +
                        $"AUTOEFICACIA: {student.autoefficacy}\n\n" +
                        $"EXTROVERSIÓN: {student.extraversion}\n\n" +
                        $"ASISTENCIA: {student.attendance}\n\n" +
                        $"NOTA MEDIA: {student.mark}\n\n" +
                        $"MOTIVACIÓN CON LA ASIGNATURA: {student.mot_subject}\n\n" +
                        $"MOTIVACIÓN CON LOS ESTUDIOS: {student.mot_studies}\n\n" +
                        $"DÍAS DE ESTUDIO POR SEMANA: {student.study_days}\n\n" +
                        $"HORAS DE ESTUDIO POR DÍA: {student.study_hours}\n\n" +
                        $"RELACIÓN CON EL PROFESOR: {student.teacher_relationship}\n\n" +
                        $"INTERESES: {interests}";
                }
                MessageBox.Show(message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AttachConsole((uint)python.Id))
            {
                SetConsoleCtrlHandler(null, true);
                try
                {
                    if (!GenerateConsoleCtrlEvent(CTRL_C_EVENT, 0))
                        python.WaitForExit();
                }
                finally
                {
                    SetConsoleCtrlHandler(null, false);
                    FreeConsole();
                }
            }
            this.TopMost = false;
            this.Dispose();
            this.Close();
            Application.Exit();
        }
    }
}
