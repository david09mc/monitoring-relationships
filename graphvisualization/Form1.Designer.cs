
namespace graphvisualization
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.finButton = new System.Windows.Forms.Button();
            this.eliminrBBDDButton = new System.Windows.Forms.Button();
            this.alumnosGroupBox = new System.Windows.Forms.GroupBox();
            this.listAlumnos = new System.Windows.Forms.ListBox();
            this.filtrosGroupBox = new System.Windows.Forms.GroupBox();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.cbRelProf = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbMotAsignatura = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbMotEstudios = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbHorasEstudio = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbDiasEstudio = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbAutoeficacia = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.cbAsistencia = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbExtroversion = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.panelTimeline = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tardeLabel = new System.Windows.Forms.Label();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.mananaLabel = new System.Windows.Forms.Label();
            this.timeBar = new System.Windows.Forms.TrackBar();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.panelGrafo = new System.Windows.Forms.Panel();
            this.grafoPicBox = new System.Windows.Forms.PictureBox();
            this.panelBotones.SuspendLayout();
            this.alumnosGroupBox.SuspendLayout();
            this.filtrosGroupBox.SuspendLayout();
            this.panelTimeline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.panelGrafo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBotones.Controls.Add(this.finButton);
            this.panelBotones.Controls.Add(this.eliminrBBDDButton);
            this.panelBotones.Controls.Add(this.alumnosGroupBox);
            this.panelBotones.Controls.Add(this.filtrosGroupBox);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(362, 537);
            this.panelBotones.TabIndex = 0;
            // 
            // finButton
            // 
            this.finButton.Location = new System.Drawing.Point(191, 473);
            this.finButton.Name = "finButton";
            this.finButton.Size = new System.Drawing.Size(128, 45);
            this.finButton.TabIndex = 4;
            this.finButton.Text = "Finalizar monitorización";
            this.finButton.UseVisualStyleBackColor = true;
            this.finButton.Click += new System.EventHandler(this.finButton_Click);
            // 
            // eliminrBBDDButton
            // 
            this.eliminrBBDDButton.Location = new System.Drawing.Point(35, 473);
            this.eliminrBBDDButton.Name = "eliminrBBDDButton";
            this.eliminrBBDDButton.Size = new System.Drawing.Size(125, 45);
            this.eliminrBBDDButton.TabIndex = 3;
            this.eliminrBBDDButton.Text = "Vaciar base de datos";
            this.eliminrBBDDButton.UseVisualStyleBackColor = true;
            this.eliminrBBDDButton.Click += new System.EventHandler(this.eliminrBBDDButton_Click);
            // 
            // alumnosGroupBox
            // 
            this.alumnosGroupBox.Controls.Add(this.listAlumnos);
            this.alumnosGroupBox.Location = new System.Drawing.Point(3, -3);
            this.alumnosGroupBox.Name = "alumnosGroupBox";
            this.alumnosGroupBox.Size = new System.Drawing.Size(353, 183);
            this.alumnosGroupBox.TabIndex = 2;
            this.alumnosGroupBox.TabStop = false;
            // 
            // listAlumnos
            // 
            this.listAlumnos.BackColor = System.Drawing.SystemColors.Menu;
            this.listAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAlumnos.FormattingEnabled = true;
            this.listAlumnos.ItemHeight = 15;
            this.listAlumnos.Location = new System.Drawing.Point(3, 19);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.Size = new System.Drawing.Size(347, 161);
            this.listAlumnos.TabIndex = 0;
            this.listAlumnos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listAlumnos_MouseClick);
            // 
            // filtrosGroupBox
            // 
            this.filtrosGroupBox.Controls.Add(this.filtrarButton);
            this.filtrosGroupBox.Controls.Add(this.cbRelProf);
            this.filtrosGroupBox.Controls.Add(this.label26);
            this.filtrosGroupBox.Controls.Add(this.cbMotAsignatura);
            this.filtrosGroupBox.Controls.Add(this.label25);
            this.filtrosGroupBox.Controls.Add(this.cbMotEstudios);
            this.filtrosGroupBox.Controls.Add(this.label24);
            this.filtrosGroupBox.Controls.Add(this.cbHorasEstudio);
            this.filtrosGroupBox.Controls.Add(this.label23);
            this.filtrosGroupBox.Controls.Add(this.cbDiasEstudio);
            this.filtrosGroupBox.Controls.Add(this.label22);
            this.filtrosGroupBox.Controls.Add(this.cbAutoeficacia);
            this.filtrosGroupBox.Controls.Add(this.label21);
            this.filtrosGroupBox.Controls.Add(this.label20);
            this.filtrosGroupBox.Controls.Add(this.tbNota);
            this.filtrosGroupBox.Controls.Add(this.cbAsistencia);
            this.filtrosGroupBox.Controls.Add(this.label19);
            this.filtrosGroupBox.Controls.Add(this.label18);
            this.filtrosGroupBox.Controls.Add(this.tbExtroversion);
            this.filtrosGroupBox.Controls.Add(this.cbGenero);
            this.filtrosGroupBox.Controls.Add(this.label17);
            this.filtrosGroupBox.Controls.Add(this.label9);
            this.filtrosGroupBox.Controls.Add(this.tbEdad);
            this.filtrosGroupBox.Location = new System.Drawing.Point(3, 186);
            this.filtrosGroupBox.Name = "filtrosGroupBox";
            this.filtrosGroupBox.Size = new System.Drawing.Size(353, 298);
            this.filtrosGroupBox.TabIndex = 1;
            this.filtrosGroupBox.TabStop = false;
            this.filtrosGroupBox.Text = "Filtros";
            // 
            // filtrarButton
            // 
            this.filtrarButton.BackColor = System.Drawing.Color.LightGray;
            this.filtrarButton.FlatAppearance.BorderSize = 0;
            this.filtrarButton.ForeColor = System.Drawing.Color.Black;
            this.filtrarButton.Location = new System.Drawing.Point(188, 246);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(128, 23);
            this.filtrarButton.TabIndex = 36;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = false;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // cbRelProf
            // 
            this.cbRelProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelProf.FormattingEnabled = true;
            this.cbRelProf.Location = new System.Drawing.Point(32, 246);
            this.cbRelProf.Name = "cbRelProf";
            this.cbRelProf.Size = new System.Drawing.Size(125, 23);
            this.cbRelProf.TabIndex = 35;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(32, 232);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 15);
            this.label26.TabIndex = 34;
            this.label26.Text = "Relación con profesor:";
            // 
            // cbMotAsignatura
            // 
            this.cbMotAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotAsignatura.FormattingEnabled = true;
            this.cbMotAsignatura.Location = new System.Drawing.Point(188, 207);
            this.cbMotAsignatura.Name = "cbMotAsignatura";
            this.cbMotAsignatura.Size = new System.Drawing.Size(128, 23);
            this.cbMotAsignatura.TabIndex = 33;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(188, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(128, 15);
            this.label25.TabIndex = 32;
            this.label25.Text = "Motivación asignatura:";
            // 
            // cbMotEstudios
            // 
            this.cbMotEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotEstudios.FormattingEnabled = true;
            this.cbMotEstudios.Location = new System.Drawing.Point(32, 207);
            this.cbMotEstudios.Name = "cbMotEstudios";
            this.cbMotEstudios.Size = new System.Drawing.Size(125, 23);
            this.cbMotEstudios.TabIndex = 31;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(32, 192);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 15);
            this.label24.TabIndex = 30;
            this.label24.Text = "Motivación estudios:";
            // 
            // cbHorasEstudio
            // 
            this.cbHorasEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorasEstudio.FormattingEnabled = true;
            this.cbHorasEstudio.Location = new System.Drawing.Point(188, 166);
            this.cbHorasEstudio.Name = "cbHorasEstudio";
            this.cbHorasEstudio.Size = new System.Drawing.Size(128, 23);
            this.cbHorasEstudio.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(188, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 15);
            this.label23.TabIndex = 28;
            this.label23.Text = "Horas de estudio:";
            // 
            // cbDiasEstudio
            // 
            this.cbDiasEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiasEstudio.FormattingEnabled = true;
            this.cbDiasEstudio.Location = new System.Drawing.Point(32, 166);
            this.cbDiasEstudio.Name = "cbDiasEstudio";
            this.cbDiasEstudio.Size = new System.Drawing.Size(125, 23);
            this.cbDiasEstudio.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(32, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "Días de estudio:";
            // 
            // cbAutoeficacia
            // 
            this.cbAutoeficacia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoeficacia.FormattingEnabled = true;
            this.cbAutoeficacia.Location = new System.Drawing.Point(188, 126);
            this.cbAutoeficacia.Name = "cbAutoeficacia";
            this.cbAutoeficacia.Size = new System.Drawing.Size(128, 23);
            this.cbAutoeficacia.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(188, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Autoeficacia";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(32, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 15);
            this.label20.TabIndex = 23;
            this.label20.Text = "Nota media:";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(32, 86);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(125, 23);
            this.tbNota.TabIndex = 22;
            // 
            // cbAsistencia
            // 
            this.cbAsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistencia.FormattingEnabled = true;
            this.cbAsistencia.Location = new System.Drawing.Point(32, 126);
            this.cbAsistencia.Name = "cbAsistencia";
            this.cbAsistencia.Size = new System.Drawing.Size(125, 23);
            this.cbAsistencia.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(32, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 20;
            this.label19.Text = "Asistencia:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(187, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 15);
            this.label18.TabIndex = 19;
            this.label18.Text = "Extroversión:";
            // 
            // tbExtroversion
            // 
            this.tbExtroversion.Location = new System.Drawing.Point(187, 42);
            this.tbExtroversion.Name = "tbExtroversion";
            this.tbExtroversion.Size = new System.Drawing.Size(129, 23);
            this.tbExtroversion.TabIndex = 18;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(188, 86);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(128, 23);
            this.cbGenero.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(188, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Género:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(32, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Edad:";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(32, 42);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(125, 23);
            this.tbEdad.TabIndex = 13;
            // 
            // panelTimeline
            // 
            this.panelTimeline.BackColor = System.Drawing.Color.Black;
            this.panelTimeline.Controls.Add(this.label10);
            this.panelTimeline.Controls.Add(this.label11);
            this.panelTimeline.Controls.Add(this.label12);
            this.panelTimeline.Controls.Add(this.label13);
            this.panelTimeline.Controls.Add(this.label14);
            this.panelTimeline.Controls.Add(this.label15);
            this.panelTimeline.Controls.Add(this.label16);
            this.panelTimeline.Controls.Add(this.label5);
            this.panelTimeline.Controls.Add(this.label6);
            this.panelTimeline.Controls.Add(this.label3);
            this.panelTimeline.Controls.Add(this.label7);
            this.panelTimeline.Controls.Add(this.label4);
            this.panelTimeline.Controls.Add(this.label8);
            this.panelTimeline.Controls.Add(this.label2);
            this.panelTimeline.Controls.Add(this.label1);
            this.panelTimeline.Controls.Add(this.tardeLabel);
            this.panelTimeline.Controls.Add(this.mediaLabel);
            this.panelTimeline.Controls.Add(this.mananaLabel);
            this.panelTimeline.Controls.Add(this.timeBar);
            this.panelTimeline.Controls.Add(this.zoomBar);
            this.panelTimeline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTimeline.Location = new System.Drawing.Point(362, 426);
            this.panelTimeline.Name = "panelTimeline";
            this.panelTimeline.Size = new System.Drawing.Size(646, 111);
            this.panelTimeline.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(615, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "22:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(482, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "19:00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(572, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "21:00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(439, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "18:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(527, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "20:00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(395, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "17:00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(352, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 15);
            this.label16.TabIndex = 13;
            this.label16.Text = "16:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(307, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "15:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(262, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "14:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "11:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(218, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "13:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "10:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(174, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "12:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "9:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "8:00";
            // 
            // tardeLabel
            // 
            this.tardeLabel.AutoSize = true;
            this.tardeLabel.BackColor = System.Drawing.Color.Transparent;
            this.tardeLabel.ForeColor = System.Drawing.Color.White;
            this.tardeLabel.Location = new System.Drawing.Point(481, 47);
            this.tardeLabel.Name = "tardeLabel";
            this.tardeLabel.Size = new System.Drawing.Size(35, 15);
            this.tardeLabel.TabIndex = 4;
            this.tardeLabel.Text = "Tarde";
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.BackColor = System.Drawing.Color.Transparent;
            this.mediaLabel.ForeColor = System.Drawing.Color.White;
            this.mediaLabel.Location = new System.Drawing.Point(280, 47);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(86, 15);
            this.mediaLabel.TabIndex = 3;
            this.mediaLabel.Text = "Media mañana";
            // 
            // mananaLabel
            // 
            this.mananaLabel.AutoSize = true;
            this.mananaLabel.BackColor = System.Drawing.Color.Transparent;
            this.mananaLabel.ForeColor = System.Drawing.Color.White;
            this.mananaLabel.Location = new System.Drawing.Point(121, 47);
            this.mananaLabel.Name = "mananaLabel";
            this.mananaLabel.Size = new System.Drawing.Size(50, 15);
            this.mananaLabel.TabIndex = 2;
            this.mananaLabel.Text = "Mañana";
            // 
            // timeBar
            // 
            this.timeBar.BackColor = System.Drawing.Color.Black;
            this.timeBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeBar.LargeChange = 1;
            this.timeBar.Location = new System.Drawing.Point(0, 66);
            this.timeBar.Maximum = 22;
            this.timeBar.Minimum = 8;
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(646, 45);
            this.timeBar.TabIndex = 1;
            this.timeBar.Value = 8;
            this.timeBar.Scroll += new System.EventHandler(this.timeBar_Scroll);
            // 
            // zoomBar
            // 
            this.zoomBar.BackColor = System.Drawing.Color.Gainsboro;
            this.zoomBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoomBar.Location = new System.Drawing.Point(0, 0);
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(646, 45);
            this.zoomBar.TabIndex = 0;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // panelGrafo
            // 
            this.panelGrafo.AutoScroll = true;
            this.panelGrafo.Controls.Add(this.grafoPicBox);
            this.panelGrafo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrafo.Location = new System.Drawing.Point(362, 0);
            this.panelGrafo.Name = "panelGrafo";
            this.panelGrafo.Size = new System.Drawing.Size(646, 426);
            this.panelGrafo.TabIndex = 2;
            // 
            // grafoPicBox
            // 
            this.grafoPicBox.Location = new System.Drawing.Point(6, 6);
            this.grafoPicBox.Name = "grafoPicBox";
            this.grafoPicBox.Size = new System.Drawing.Size(634, 414);
            this.grafoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.grafoPicBox.TabIndex = 2;
            this.grafoPicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panelGrafo);
            this.Controls.Add(this.panelTimeline);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Herramienta de monitorización";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBotones.ResumeLayout(false);
            this.alumnosGroupBox.ResumeLayout(false);
            this.filtrosGroupBox.ResumeLayout(false);
            this.filtrosGroupBox.PerformLayout();
            this.panelTimeline.ResumeLayout(false);
            this.panelTimeline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.panelGrafo.ResumeLayout(false);
            this.panelGrafo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafoPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelTimeline;
        private System.Windows.Forms.Panel panelGrafo;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.PictureBox grafoPicBox;
        private System.Windows.Forms.GroupBox filtrosGroupBox;
        private System.Windows.Forms.ListBox listAlumnos;
        private System.Windows.Forms.TrackBar timeBar;
        private System.Windows.Forms.Label mananaLabel;
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.Label tardeLabel;
        private System.Windows.Forms.GroupBox alumnosGroupBox;
        private System.Windows.Forms.Button eliminrBBDDButton;
        private System.Windows.Forms.Button finButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRelProf;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbMotAsignatura;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbMotEstudios;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbHorasEstudio;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbDiasEstudio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbAutoeficacia;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.ComboBox cbAsistencia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbExtroversion;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Button filtrarButton;
    }
}

