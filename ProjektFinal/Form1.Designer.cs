namespace ProjektFinal
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kontrolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabKontrola = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneClient5 = new ProjektFinal.PhoneClient();
            this.phoneClient4 = new ProjektFinal.PhoneClient();
            this.phoneClient3 = new ProjektFinal.PhoneClient();
            this.phoneClient2 = new ProjektFinal.PhoneClient();
            this.phoneClient1 = new ProjektFinal.PhoneClient();
            this.pictureServer = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureDatabase = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericHumidity = new System.Windows.Forms.NumericUpDown();
            this.numericPressure = new System.Windows.Forms.NumericUpDown();
            this.numericTemperature = new System.Windows.Forms.NumericUpDown();
            this.pictureUControler = new System.Windows.Forms.PictureBox();
            this.pictureSerial = new System.Windows.Forms.PictureBox();
            this.pictureBT = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelClosedSerial = new System.Windows.Forms.Panel();
            this.panelOpenedSerial = new System.Windows.Forms.Panel();
            this.btnDisconnectSerial = new System.Windows.Forms.Button();
            this.btnConnectSerial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPortBaud = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPortName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAggregation = new System.Windows.Forms.ComboBox();
            this.nmrUnits = new System.Windows.Forms.NumericUpDown();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundValidate = new System.ComponentModel.BackgroundWorker();
            this.backgroundSerial = new System.ComponentModel.BackgroundWorker();
            this.timerDatabase = new System.Windows.Forms.Timer(this.components);
            this.backgroundSQLSender = new System.ComponentModel.BackgroundWorker();
            this.ledLight1 = new ProjektFinal.LedLight();
            this.ledLight2 = new ProjektFinal.LedLight();
            this.ledLight3 = new ProjektFinal.LedLight();
            this.ledLight4 = new ProjektFinal.LedLight();
            this.ledLight5 = new ProjektFinal.LedLight();
            this.menuStrip1.SuspendLayout();
            this.tabKontrola.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureServer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDatabase)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUControler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrolaToolStripMenuItem,
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kontrolaToolStripMenuItem
            // 
            this.kontrolaToolStripMenuItem.Name = "kontrolaToolStripMenuItem";
            this.kontrolaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kontrolaToolStripMenuItem.Text = "Kontrola";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.konfiguracjaToolStripMenuItem.Text = "Konfiguracja";
            this.konfiguracjaToolStripMenuItem.Click += new System.EventHandler(this.konfiguracjaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // tabKontrola
            // 
            this.tabKontrola.Controls.Add(this.tabPage1);
            this.tabKontrola.Controls.Add(this.tabPage2);
            this.tabKontrola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKontrola.HotTrack = true;
            this.tabKontrola.Location = new System.Drawing.Point(0, 24);
            this.tabKontrola.Name = "tabKontrola";
            this.tabKontrola.SelectedIndex = 0;
            this.tabKontrola.Size = new System.Drawing.Size(1323, 725);
            this.tabKontrola.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1315, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Obsługa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStopServer);
            this.groupBox4.Controls.Add(this.btnStartServer);
            this.groupBox4.Controls.Add(this.labelServerIP);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.phoneClient5);
            this.groupBox4.Controls.Add(this.phoneClient4);
            this.groupBox4.Controls.Add(this.phoneClient3);
            this.groupBox4.Controls.Add(this.phoneClient2);
            this.groupBox4.Controls.Add(this.phoneClient1);
            this.groupBox4.Controls.Add(this.pictureServer);
            this.groupBox4.Location = new System.Drawing.Point(674, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 643);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serwer";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(200, 78);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(108, 23);
            this.btnStopServer.TabIndex = 21;
            this.btnStopServer.Text = "Zamknij Serwer";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(52, 78);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(108, 23);
            this.btnStartServer.TabIndex = 20;
            this.btnStartServer.Text = "Uruchom Serwer";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServerIP.Location = new System.Drawing.Point(52, 404);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(59, 18);
            this.labelServerIP.TabIndex = 19;
            this.labelServerIP.Text = "1.1.1.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adres IP:";
            // 
            // phoneClient5
            // 
            this.phoneClient5.Connected = false;
            this.phoneClient5.ID = null;
            this.phoneClient5.Ip = null;
            this.phoneClient5.Location = new System.Drawing.Point(375, 19);
            this.phoneClient5.Name = "phoneClient5";
            this.phoneClient5.Size = new System.Drawing.Size(157, 197);
            this.phoneClient5.TabIndex = 17;
            // 
            // phoneClient4
            // 
            this.phoneClient4.Connected = false;
            this.phoneClient4.ID = null;
            this.phoneClient4.Ip = null;
            this.phoneClient4.Location = new System.Drawing.Point(375, 222);
            this.phoneClient4.Name = "phoneClient4";
            this.phoneClient4.Size = new System.Drawing.Size(157, 202);
            this.phoneClient4.TabIndex = 16;
            // 
            // phoneClient3
            // 
            this.phoneClient3.Connected = false;
            this.phoneClient3.ID = null;
            this.phoneClient3.Ip = null;
            this.phoneClient3.Location = new System.Drawing.Point(375, 430);
            this.phoneClient3.Name = "phoneClient3";
            this.phoneClient3.Size = new System.Drawing.Size(157, 207);
            this.phoneClient3.TabIndex = 15;
            // 
            // phoneClient2
            // 
            this.phoneClient2.Connected = false;
            this.phoneClient2.ID = null;
            this.phoneClient2.Ip = null;
            this.phoneClient2.Location = new System.Drawing.Point(188, 430);
            this.phoneClient2.Name = "phoneClient2";
            this.phoneClient2.Size = new System.Drawing.Size(157, 207);
            this.phoneClient2.TabIndex = 14;
            // 
            // phoneClient1
            // 
            this.phoneClient1.Connected = false;
            this.phoneClient1.ID = null;
            this.phoneClient1.Ip = null;
            this.phoneClient1.Location = new System.Drawing.Point(6, 430);
            this.phoneClient1.Name = "phoneClient1";
            this.phoneClient1.Size = new System.Drawing.Size(157, 207);
            this.phoneClient1.TabIndex = 13;
            this.phoneClient1.Load += new System.EventHandler(this.phoneClient1_Load);
            // 
            // pictureServer
            // 
            this.pictureServer.BackColor = System.Drawing.Color.DarkRed;
            this.pictureServer.Image = global::ProjektFinal.Properties.Resources.server;
            this.pictureServer.Location = new System.Drawing.Point(52, 124);
            this.pictureServer.Name = "pictureServer";
            this.pictureServer.Size = new System.Drawing.Size(256, 256);
            this.pictureServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureServer.TabIndex = 9;
            this.pictureServer.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.pictureDatabase);
            this.groupBox3.Location = new System.Drawing.Point(360, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 646);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baza Danych";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Błędy przy zapisie:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(158, 62);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Poprawnie zapisane dane:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // pictureDatabase
            // 
            this.pictureDatabase.BackColor = System.Drawing.Color.DarkRed;
            this.pictureDatabase.Image = global::ProjektFinal.Properties.Resources.database_mysql;
            this.pictureDatabase.Location = new System.Drawing.Point(19, 154);
            this.pictureDatabase.Name = "pictureDatabase";
            this.pictureDatabase.Size = new System.Drawing.Size(256, 256);
            this.pictureDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureDatabase.TabIndex = 8;
            this.pictureDatabase.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ledLight5);
            this.groupBox2.Controls.Add(this.ledLight3);
            this.groupBox2.Controls.Add(this.ledLight4);
            this.groupBox2.Controls.Add(this.ledLight2);
            this.groupBox2.Controls.Add(this.ledLight1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericHumidity);
            this.groupBox2.Controls.Add(this.numericPressure);
            this.groupBox2.Controls.Add(this.numericTemperature);
            this.groupBox2.Controls.Add(this.pictureUControler);
            this.groupBox2.Controls.Add(this.pictureSerial);
            this.groupBox2.Controls.Add(this.pictureBT);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 643);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mikrokontroler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wilgotność:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ciśnienie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura:";
            // 
            // numericHumidity
            // 
            this.numericHumidity.DecimalPlaces = 2;
            this.numericHumidity.Location = new System.Drawing.Point(227, 264);
            this.numericHumidity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericHumidity.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericHumidity.Name = "numericHumidity";
            this.numericHumidity.ReadOnly = true;
            this.numericHumidity.Size = new System.Drawing.Size(92, 20);
            this.numericHumidity.TabIndex = 15;
            // 
            // numericPressure
            // 
            this.numericPressure.DecimalPlaces = 2;
            this.numericPressure.Location = new System.Drawing.Point(119, 264);
            this.numericPressure.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericPressure.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericPressure.Name = "numericPressure";
            this.numericPressure.ReadOnly = true;
            this.numericPressure.Size = new System.Drawing.Size(88, 20);
            this.numericPressure.TabIndex = 14;
            // 
            // numericTemperature
            // 
            this.numericTemperature.DecimalPlaces = 2;
            this.numericTemperature.Location = new System.Drawing.Point(12, 264);
            this.numericTemperature.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericTemperature.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericTemperature.Name = "numericTemperature";
            this.numericTemperature.ReadOnly = true;
            this.numericTemperature.Size = new System.Drawing.Size(86, 20);
            this.numericTemperature.TabIndex = 13;
            // 
            // pictureUControler
            // 
            this.pictureUControler.BackColor = System.Drawing.Color.DarkRed;
            this.pictureUControler.Image = global::ProjektFinal.Properties.Resources.arduino;
            this.pictureUControler.Location = new System.Drawing.Point(12, 306);
            this.pictureUControler.Name = "pictureUControler";
            this.pictureUControler.Size = new System.Drawing.Size(254, 181);
            this.pictureUControler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureUControler.TabIndex = 4;
            this.pictureUControler.TabStop = false;
            // 
            // pictureSerial
            // 
            this.pictureSerial.BackColor = System.Drawing.Color.DarkRed;
            this.pictureSerial.Image = global::ProjektFinal.Properties.Resources.serial;
            this.pictureSerial.Location = new System.Drawing.Point(283, 306);
            this.pictureSerial.Name = "pictureSerial";
            this.pictureSerial.Size = new System.Drawing.Size(64, 64);
            this.pictureSerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureSerial.TabIndex = 7;
            this.pictureSerial.TabStop = false;
            // 
            // pictureBT
            // 
            this.pictureBT.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBT.Image = global::ProjektFinal.Properties.Resources.Bluetooth_icon;
            this.pictureBT.Location = new System.Drawing.Point(283, 400);
            this.pictureBT.Name = "pictureBT";
            this.pictureBT.Size = new System.Drawing.Size(64, 64);
            this.pictureBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBT.TabIndex = 6;
            this.pictureBT.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelClosedSerial);
            this.groupBox1.Controls.Add(this.panelOpenedSerial);
            this.groupBox1.Controls.Add(this.btnDisconnectSerial);
            this.groupBox1.Controls.Add(this.btnConnectSerial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPortBaud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPortName);
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Połączenie z mikrokontrolerem";
            // 
            // panelClosedSerial
            // 
            this.panelClosedSerial.Location = new System.Drawing.Point(102, 124);
            this.panelClosedSerial.Name = "panelClosedSerial";
            this.panelClosedSerial.Size = new System.Drawing.Size(75, 35);
            this.panelClosedSerial.TabIndex = 7;
            // 
            // panelOpenedSerial
            // 
            this.panelOpenedSerial.Location = new System.Drawing.Point(9, 124);
            this.panelOpenedSerial.Name = "panelOpenedSerial";
            this.panelOpenedSerial.Size = new System.Drawing.Size(75, 35);
            this.panelOpenedSerial.TabIndex = 6;
            // 
            // btnDisconnectSerial
            // 
            this.btnDisconnectSerial.Location = new System.Drawing.Point(102, 98);
            this.btnDisconnectSerial.Name = "btnDisconnectSerial";
            this.btnDisconnectSerial.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectSerial.TabIndex = 5;
            this.btnDisconnectSerial.Text = "Rozłącz";
            this.btnDisconnectSerial.UseVisualStyleBackColor = true;
            this.btnDisconnectSerial.Click += new System.EventHandler(this.btnDisconnectSerial_Click);
            // 
            // btnConnectSerial
            // 
            this.btnConnectSerial.Location = new System.Drawing.Point(9, 98);
            this.btnConnectSerial.Name = "btnConnectSerial";
            this.btnConnectSerial.Size = new System.Drawing.Size(75, 23);
            this.btnConnectSerial.TabIndex = 4;
            this.btnConnectSerial.Text = "Połącz";
            this.btnConnectSerial.UseVisualStyleBackColor = true;
            this.btnConnectSerial.Click += new System.EventHandler(this.btnConnectSerial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prędkość:";
            // 
            // lblPortBaud
            // 
            this.lblPortBaud.AutoSize = true;
            this.lblPortBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPortBaud.Location = new System.Drawing.Point(6, 70);
            this.lblPortBaud.Name = "lblPortBaud";
            this.lblPortBaud.Size = new System.Drawing.Size(35, 13);
            this.lblPortBaud.TabIndex = 2;
            this.lblPortBaud.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPortName.Location = new System.Drawing.Point(6, 35);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(35, 13);
            this.lblPortName.TabIndex = 0;
            this.lblPortName.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.btnDraw);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cmbAggregation);
            this.tabPage2.Controls.Add(this.nmrUnits);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1315, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wykresy";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Pressure";
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Humidity";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1017, 433);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(1145, 307);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(132, 23);
            this.btnDraw.TabIndex = 24;
            this.btnDraw.Text = "Wykreśl";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1142, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Agregacja";
            // 
            // cmbAggregation
            // 
            this.cmbAggregation.FormattingEnabled = true;
            this.cmbAggregation.Location = new System.Drawing.Point(1145, 243);
            this.cmbAggregation.Name = "cmbAggregation";
            this.cmbAggregation.Size = new System.Drawing.Size(132, 21);
            this.cmbAggregation.TabIndex = 21;
            this.cmbAggregation.SelectedIndexChanged += new System.EventHandler(this.cmbAggregation_SelectedIndexChanged);
            // 
            // nmrUnits
            // 
            this.nmrUnits.Location = new System.Drawing.Point(1145, 270);
            this.nmrUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUnits.Name = "nmrUnits";
            this.nmrUnits.Size = new System.Drawing.Size(132, 20);
            this.nmrUnits.TabIndex = 22;
            this.nmrUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // backgroundValidate
            // 
            this.backgroundValidate.WorkerSupportsCancellation = true;
            this.backgroundValidate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundValidate_DoWork);
            this.backgroundValidate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundValidate_RunWorkerCompleted);
            // 
            // backgroundSerial
            // 
            this.backgroundSerial.WorkerSupportsCancellation = true;
            this.backgroundSerial.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSerial_DoWork);
            this.backgroundSerial.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSerial_RunWorkerCompleted);
            // 
            // timerDatabase
            // 
            this.timerDatabase.Enabled = true;
            this.timerDatabase.Interval = 10000;
            this.timerDatabase.Tick += new System.EventHandler(this.timerDatabase_Tick);
            // 
            // backgroundSQLSender
            // 
            this.backgroundSQLSender.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSQLSender_DoWork);
            this.backgroundSQLSender.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSQLSender_RunWorkerCompleted);
            // 
            // ledLight1
            // 
            this.ledLight1.Location = new System.Drawing.Point(6, 524);
            this.ledLight1.Name = "ledLight1";
            this.ledLight1.Size = new System.Drawing.Size(69, 70);
            this.ledLight1.TabIndex = 19;
            // 
            // ledLight2
            // 
            this.ledLight2.Location = new System.Drawing.Point(81, 524);
            this.ledLight2.Name = "ledLight2";
            this.ledLight2.Size = new System.Drawing.Size(69, 70);
            this.ledLight2.TabIndex = 20;
            // 
            // ledLight3
            // 
            this.ledLight3.Location = new System.Drawing.Point(147, 524);
            this.ledLight3.Name = "ledLight3";
            this.ledLight3.Size = new System.Drawing.Size(69, 70);
            this.ledLight3.TabIndex = 22;
            // 
            // ledLight4
            // 
            this.ledLight4.Location = new System.Drawing.Point(219, 524);
            this.ledLight4.Name = "ledLight4";
            this.ledLight4.Size = new System.Drawing.Size(69, 70);
            this.ledLight4.TabIndex = 21;
            // 
            // ledLight5
            // 
            this.ledLight5.Location = new System.Drawing.Point(285, 524);
            this.ledLight5.Name = "ledLight5";
            this.ledLight5.Size = new System.Drawing.Size(69, 70);
            this.ledLight5.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 749);
            this.Controls.Add(this.tabKontrola);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Projekt KSP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabKontrola.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureServer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDatabase)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUControler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kontrolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.TabControl tabKontrola;
        private System.Windows.Forms.TabPage tabPage2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelClosedSerial;
        private System.Windows.Forms.Panel panelOpenedSerial;
        private System.Windows.Forms.Button btnDisconnectSerial;
        private System.Windows.Forms.Button btnConnectSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPortBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureUControler;
        private System.Windows.Forms.PictureBox pictureServer;
        private System.Windows.Forms.PictureBox pictureDatabase;
        private System.Windows.Forms.PictureBox pictureSerial;
        private System.Windows.Forms.PictureBox pictureBT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private PhoneClient phoneClient5;
        private PhoneClient phoneClient4;
        private PhoneClient phoneClient3;
        private PhoneClient phoneClient2;
        private PhoneClient phoneClient1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbAggregation;
        private System.Windows.Forms.NumericUpDown nmrUnits;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundValidate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericHumidity;
        private System.Windows.Forms.NumericUpDown numericPressure;
        private System.Windows.Forms.NumericUpDown numericTemperature;
        private System.ComponentModel.BackgroundWorker backgroundSerial;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerDatabase;
        private System.ComponentModel.BackgroundWorker backgroundSQLSender;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStopServer;
        private LedLight ledLight5;
        private LedLight ledLight3;
        private LedLight ledLight4;
        private LedLight ledLight2;
        private LedLight ledLight1;
    }
}

