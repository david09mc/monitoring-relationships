
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
            this.edadButton = new System.Windows.Forms.RadioButton();
            this.motEstudButton = new System.Windows.Forms.RadioButton();
            this.motAsignButton = new System.Windows.Forms.RadioButton();
            this.autoeficaciaButton = new System.Windows.Forms.RadioButton();
            this.relacionProfButton = new System.Windows.Forms.RadioButton();
            this.díasEstudButton = new System.Windows.Forms.RadioButton();
            this.horasEstudButton = new System.Windows.Forms.RadioButton();
            this.notaButton = new System.Windows.Forms.RadioButton();
            this.asistenciaButton = new System.Windows.Forms.RadioButton();
            this.extraversButton = new System.Windows.Forms.RadioButton();
            this.generoButton = new System.Windows.Forms.RadioButton();
            this.nombreButton = new System.Windows.Forms.RadioButton();
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
            this.finButton.Size = new System.Drawing.Size(100, 45);
            this.finButton.TabIndex = 4;
            this.finButton.Text = "Finalizar monitorización";
            this.finButton.UseVisualStyleBackColor = true;
            this.finButton.Click += new System.EventHandler(this.finButton_Click);
            // 
            // eliminrBBDDButton
            // 
            this.eliminrBBDDButton.Location = new System.Drawing.Point(35, 473);
            this.eliminrBBDDButton.Name = "eliminrBBDDButton";
            this.eliminrBBDDButton.Size = new System.Drawing.Size(100, 45);
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
            this.alumnosGroupBox.Size = new System.Drawing.Size(353, 203);
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
            this.listAlumnos.Size = new System.Drawing.Size(347, 181);
            this.listAlumnos.TabIndex = 0;
            this.listAlumnos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listAlumnos_MouseClick);
            // 
            // filtrosGroupBox
            // 
            this.filtrosGroupBox.Controls.Add(this.edadButton);
            this.filtrosGroupBox.Controls.Add(this.motEstudButton);
            this.filtrosGroupBox.Controls.Add(this.motAsignButton);
            this.filtrosGroupBox.Controls.Add(this.autoeficaciaButton);
            this.filtrosGroupBox.Controls.Add(this.relacionProfButton);
            this.filtrosGroupBox.Controls.Add(this.díasEstudButton);
            this.filtrosGroupBox.Controls.Add(this.horasEstudButton);
            this.filtrosGroupBox.Controls.Add(this.notaButton);
            this.filtrosGroupBox.Controls.Add(this.asistenciaButton);
            this.filtrosGroupBox.Controls.Add(this.extraversButton);
            this.filtrosGroupBox.Controls.Add(this.generoButton);
            this.filtrosGroupBox.Controls.Add(this.nombreButton);
            this.filtrosGroupBox.Location = new System.Drawing.Point(3, 199);
            this.filtrosGroupBox.Name = "filtrosGroupBox";
            this.filtrosGroupBox.Size = new System.Drawing.Size(353, 285);
            this.filtrosGroupBox.TabIndex = 1;
            this.filtrosGroupBox.TabStop = false;
            this.filtrosGroupBox.Text = "Filtros";
            // 
            // edadButton
            // 
            this.edadButton.AutoSize = true;
            this.edadButton.Location = new System.Drawing.Point(188, 35);
            this.edadButton.Name = "edadButton";
            this.edadButton.Size = new System.Drawing.Size(51, 19);
            this.edadButton.TabIndex = 12;
            this.edadButton.TabStop = true;
            this.edadButton.Text = "Edad";
            this.edadButton.UseVisualStyleBackColor = true;
            this.edadButton.CheckedChanged += new System.EventHandler(this.edadButton_CheckedChanged);
            // 
            // motEstudButton
            // 
            this.motEstudButton.AutoSize = true;
            this.motEstudButton.Location = new System.Drawing.Point(32, 235);
            this.motEstudButton.Name = "motEstudButton";
            this.motEstudButton.Size = new System.Drawing.Size(132, 19);
            this.motEstudButton.TabIndex = 11;
            this.motEstudButton.TabStop = true;
            this.motEstudButton.Text = "Motivación estudios";
            this.motEstudButton.UseVisualStyleBackColor = true;
            this.motEstudButton.CheckedChanged += new System.EventHandler(this.motEstudButton_CheckedChanged);
            // 
            // motAsignButton
            // 
            this.motAsignButton.AutoSize = true;
            this.motAsignButton.Location = new System.Drawing.Point(188, 235);
            this.motAsignButton.Name = "motAsignButton";
            this.motAsignButton.Size = new System.Drawing.Size(143, 19);
            this.motAsignButton.TabIndex = 10;
            this.motAsignButton.TabStop = true;
            this.motAsignButton.Text = "Motivación asignatura";
            this.motAsignButton.UseVisualStyleBackColor = true;
            this.motAsignButton.CheckedChanged += new System.EventHandler(this.motAsignButton_CheckedChanged);
            // 
            // autoeficaciaButton
            // 
            this.autoeficaciaButton.AutoSize = true;
            this.autoeficaciaButton.Location = new System.Drawing.Point(32, 155);
            this.autoeficaciaButton.Name = "autoeficaciaButton";
            this.autoeficaciaButton.Size = new System.Drawing.Size(91, 19);
            this.autoeficaciaButton.TabIndex = 3;
            this.autoeficaciaButton.TabStop = true;
            this.autoeficaciaButton.Text = "Autoeficacia";
            this.autoeficaciaButton.UseVisualStyleBackColor = true;
            this.autoeficaciaButton.CheckedChanged += new System.EventHandler(this.autoeficaciaButton_CheckedChanged);
            // 
            // relacionProfButton
            // 
            this.relacionProfButton.AutoSize = true;
            this.relacionProfButton.Location = new System.Drawing.Point(188, 155);
            this.relacionProfButton.Name = "relacionProfButton";
            this.relacionProfButton.Size = new System.Drawing.Size(140, 19);
            this.relacionProfButton.TabIndex = 9;
            this.relacionProfButton.TabStop = true;
            this.relacionProfButton.Text = "Relación con profesor";
            this.relacionProfButton.UseVisualStyleBackColor = true;
            this.relacionProfButton.CheckedChanged += new System.EventHandler(this.relacionProfButton_CheckedChanged);
            // 
            // díasEstudButton
            // 
            this.díasEstudButton.AutoSize = true;
            this.díasEstudButton.Location = new System.Drawing.Point(32, 195);
            this.díasEstudButton.Name = "díasEstudButton";
            this.díasEstudButton.Size = new System.Drawing.Size(105, 19);
            this.díasEstudButton.TabIndex = 7;
            this.díasEstudButton.TabStop = true;
            this.díasEstudButton.Text = "Días de estudio";
            this.díasEstudButton.UseVisualStyleBackColor = true;
            this.díasEstudButton.CheckedChanged += new System.EventHandler(this.díasEstudButton_CheckedChanged);
            // 
            // horasEstudButton
            // 
            this.horasEstudButton.AutoSize = true;
            this.horasEstudButton.Location = new System.Drawing.Point(188, 195);
            this.horasEstudButton.Name = "horasEstudButton";
            this.horasEstudButton.Size = new System.Drawing.Size(114, 19);
            this.horasEstudButton.TabIndex = 6;
            this.horasEstudButton.TabStop = true;
            this.horasEstudButton.Text = "Horas de estudio";
            this.horasEstudButton.UseVisualStyleBackColor = true;
            this.horasEstudButton.CheckedChanged += new System.EventHandler(this.horasEstudButton_CheckedChanged);
            // 
            // notaButton
            // 
            this.notaButton.AutoSize = true;
            this.notaButton.Location = new System.Drawing.Point(188, 115);
            this.notaButton.Name = "notaButton";
            this.notaButton.Size = new System.Drawing.Size(87, 19);
            this.notaButton.TabIndex = 5;
            this.notaButton.TabStop = true;
            this.notaButton.Text = "Nota media";
            this.notaButton.UseVisualStyleBackColor = true;
            this.notaButton.CheckedChanged += new System.EventHandler(this.notaButton_CheckedChanged);
            // 
            // asistenciaButton
            // 
            this.asistenciaButton.AutoSize = true;
            this.asistenciaButton.Location = new System.Drawing.Point(32, 115);
            this.asistenciaButton.Name = "asistenciaButton";
            this.asistenciaButton.Size = new System.Drawing.Size(78, 19);
            this.asistenciaButton.TabIndex = 4;
            this.asistenciaButton.TabStop = true;
            this.asistenciaButton.Text = "Asistencia";
            this.asistenciaButton.UseVisualStyleBackColor = true;
            this.asistenciaButton.CheckedChanged += new System.EventHandler(this.asistenciaButton_CheckedChanged);
            // 
            // extraversButton
            // 
            this.extraversButton.AutoSize = true;
            this.extraversButton.Location = new System.Drawing.Point(188, 75);
            this.extraversButton.Name = "extraversButton";
            this.extraversButton.Size = new System.Drawing.Size(90, 19);
            this.extraversButton.TabIndex = 2;
            this.extraversButton.TabStop = true;
            this.extraversButton.Text = "Extroversión";
            this.extraversButton.UseVisualStyleBackColor = true;
            this.extraversButton.CheckedChanged += new System.EventHandler(this.extraversButton_CheckedChanged);
            // 
            // generoButton
            // 
            this.generoButton.AutoSize = true;
            this.generoButton.Location = new System.Drawing.Point(32, 75);
            this.generoButton.Name = "generoButton";
            this.generoButton.Size = new System.Drawing.Size(63, 19);
            this.generoButton.TabIndex = 1;
            this.generoButton.TabStop = true;
            this.generoButton.Text = "Género";
            this.generoButton.UseVisualStyleBackColor = true;
            this.generoButton.CheckedChanged += new System.EventHandler(this.generoButton_CheckedChanged);
            // 
            // nombreButton
            // 
            this.nombreButton.AutoSize = true;
            this.nombreButton.Location = new System.Drawing.Point(32, 35);
            this.nombreButton.Name = "nombreButton";
            this.nombreButton.Size = new System.Drawing.Size(69, 19);
            this.nombreButton.TabIndex = 0;
            this.nombreButton.TabStop = true;
            this.nombreButton.Text = "Nombre";
            this.nombreButton.UseVisualStyleBackColor = true;
            this.nombreButton.CheckedChanged += new System.EventHandler(this.nombreButton_CheckedChanged);
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
        private System.Windows.Forms.RadioButton motEstudButton;
        private System.Windows.Forms.RadioButton motAsignButton;
        private System.Windows.Forms.RadioButton relacionProfButton;
        private System.Windows.Forms.RadioButton díasEstudButton;
        private System.Windows.Forms.RadioButton horasEstudButton;
        private System.Windows.Forms.RadioButton notaButton;
        private System.Windows.Forms.RadioButton asistenciaButton;
        private System.Windows.Forms.RadioButton autoeficaciaButton;
        private System.Windows.Forms.RadioButton extraversButton;
        private System.Windows.Forms.RadioButton generoButton;
        private System.Windows.Forms.RadioButton nombreButton;
        private System.Windows.Forms.GroupBox alumnosGroupBox;
        private System.Windows.Forms.Button eliminrBBDDButton;
        private System.Windows.Forms.Button finButton;
        private System.Windows.Forms.RadioButton edadButton;
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
    }
}

