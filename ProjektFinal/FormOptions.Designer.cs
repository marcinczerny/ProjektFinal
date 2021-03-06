﻿using System;

namespace ProjektFinal
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSerial = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveSerialPort = new System.Windows.Forms.Button();
            this.lblSerialInfo = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbBeginOfHumidity = new System.Windows.Forms.MaskedTextBox();
            this.txbBeginOfTemperature = new System.Windows.Forms.MaskedTextBox();
            this.btnSaveFrame = new System.Windows.Forms.Button();
            this.txbBeginOfPressure = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEndOfFrame = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbWilgotnosc = new System.Windows.Forms.TextBox();
            this.txbCisnienie = new System.Windows.Forms.TextBox();
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStatusSerialConnection = new System.Windows.Forms.Label();
            this.lblStatusSerial = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.bntCancelSerialTest = new System.Windows.Forms.Button();
            this.btnStartSerialTest = new System.Windows.Forms.Button();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbServerIp = new System.Windows.Forms.TextBox();
            this.maskedPortServer = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabDB = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnValidateDB = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.txbUID = new System.Windows.Forms.TextBox();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.maskedPassword = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCheckCount = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nmrDeleteCount = new System.Windows.Forms.NumericUpDown();
            this.nmrStatCount = new System.Windows.Forms.NumericUpDown();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundValidateDB = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabSerial.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabDB.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDeleteCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStatCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSerial);
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Controls.Add(this.tabDB);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSerial
            // 
            this.tabSerial.Controls.Add(this.flowLayoutPanel1);
            this.tabSerial.Location = new System.Drawing.Point(4, 22);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerial.Size = new System.Drawing.Size(792, 424);
            this.tabSerial.TabIndex = 0;
            this.tabSerial.Text = "Połączenie szeregowe";
            this.tabSerial.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveSerialPort);
            this.groupBox1.Controls.Add(this.lblSerialInfo);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konfiguracja Portu";
            // 
            // btnSaveSerialPort
            // 
            this.btnSaveSerialPort.Location = new System.Drawing.Point(9, 136);
            this.btnSaveSerialPort.Name = "btnSaveSerialPort";
            this.btnSaveSerialPort.Size = new System.Drawing.Size(104, 37);
            this.btnSaveSerialPort.TabIndex = 24;
            this.btnSaveSerialPort.Text = "Zapisz";
            this.btnSaveSerialPort.UseVisualStyleBackColor = true;
            this.btnSaveSerialPort.Click += new System.EventHandler(this.btnSaveSerialPort_Click);
            // 
            // lblSerialInfo
            // 
            this.lblSerialInfo.AutoSize = true;
            this.lblSerialInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSerialInfo.Location = new System.Drawing.Point(6, 139);
            this.lblSerialInfo.Name = "lblSerialInfo";
            this.lblSerialInfo.Size = new System.Drawing.Size(0, 25);
            this.lblSerialInfo.TabIndex = 23;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(9, 104);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(200, 21);
            this.cmbBaudRate.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Wybierz predkosc";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(9, 42);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(200, 21);
            this.cmbPort.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Wybierz port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbBeginOfHumidity);
            this.groupBox2.Controls.Add(this.txbBeginOfTemperature);
            this.groupBox2.Controls.Add(this.btnSaveFrame);
            this.groupBox2.Controls.Add(this.txbBeginOfPressure);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbEndOfFrame);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(234, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konfiguracja Ramki";
            // 
            // txbBeginOfHumidity
            // 
            this.txbBeginOfHumidity.Location = new System.Drawing.Point(151, 105);
            this.txbBeginOfHumidity.Mask = "&";
            this.txbBeginOfHumidity.Name = "txbBeginOfHumidity";
            this.txbBeginOfHumidity.RejectInputOnFirstFailure = true;
            this.txbBeginOfHumidity.Size = new System.Drawing.Size(104, 20);
            this.txbBeginOfHumidity.TabIndex = 30;
            this.txbBeginOfHumidity.TextChanged += new System.EventHandler(this.txbBeginOfHumidity_TextChanged);
            // 
            // txbBeginOfTemperature
            // 
            this.txbBeginOfTemperature.Location = new System.Drawing.Point(9, 105);
            this.txbBeginOfTemperature.Mask = "&";
            this.txbBeginOfTemperature.Name = "txbBeginOfTemperature";
            this.txbBeginOfTemperature.RejectInputOnFirstFailure = true;
            this.txbBeginOfTemperature.Size = new System.Drawing.Size(104, 20);
            this.txbBeginOfTemperature.TabIndex = 29;
            this.txbBeginOfTemperature.TextChanged += new System.EventHandler(this.txbBeginOfTemperature_TextChanged);
            // 
            // btnSaveFrame
            // 
            this.btnSaveFrame.Location = new System.Drawing.Point(9, 139);
            this.btnSaveFrame.Name = "btnSaveFrame";
            this.btnSaveFrame.Size = new System.Drawing.Size(104, 37);
            this.btnSaveFrame.TabIndex = 3;
            this.btnSaveFrame.Text = "Zapisz";
            this.btnSaveFrame.UseVisualStyleBackColor = true;
            this.btnSaveFrame.Click += new System.EventHandler(this.btnSaveFrame_Click);
            // 
            // txbBeginOfPressure
            // 
            this.txbBeginOfPressure.Location = new System.Drawing.Point(151, 43);
            this.txbBeginOfPressure.Mask = "&";
            this.txbBeginOfPressure.Name = "txbBeginOfPressure";
            this.txbBeginOfPressure.RejectInputOnFirstFailure = true;
            this.txbBeginOfPressure.Size = new System.Drawing.Size(104, 20);
            this.txbBeginOfPressure.TabIndex = 28;
            this.txbBeginOfPressure.TextChanged += new System.EventHandler(this.txbBeginOfPressure_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Znak pocżątku wilgotności";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Znak początku ciśnienia";
            // 
            // txbEndOfFrame
            // 
            this.txbEndOfFrame.Location = new System.Drawing.Point(9, 43);
            this.txbEndOfFrame.Mask = "&";
            this.txbEndOfFrame.Name = "txbEndOfFrame";
            this.txbEndOfFrame.RejectInputOnFirstFailure = true;
            this.txbEndOfFrame.Size = new System.Drawing.Size(104, 20);
            this.txbEndOfFrame.TabIndex = 24;
            this.txbEndOfFrame.TextChanged += new System.EventHandler(this.txbEndOfFrame_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Znak pocżątku temperatury";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Znak końca ramki";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txbWilgotnosc);
            this.groupBox3.Controls.Add(this.txbCisnienie);
            this.groupBox3.Controls.Add(this.txbTemperatura);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblStatusSerialConnection);
            this.groupBox3.Controls.Add(this.lblStatusSerial);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.bntCancelSerialTest);
            this.groupBox3.Controls.Add(this.btnStartSerialTest);
            this.groupBox3.Location = new System.Drawing.Point(13, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(669, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test połączenia";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 93);
            this.textBox1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Wyślij potwierdzenie od klienta";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(221, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 45);
            this.button5.TabIndex = 24;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(168, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 45);
            this.button4.TabIndex = 23;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(115, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 45);
            this.button3.TabIndex = 22;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(62, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(9, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Wilgotność";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ciśnienie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Temperatura";
            // 
            // txbWilgotnosc
            // 
            this.txbWilgotnosc.Location = new System.Drawing.Point(253, 118);
            this.txbWilgotnosc.Name = "txbWilgotnosc";
            this.txbWilgotnosc.Size = new System.Drawing.Size(101, 20);
            this.txbWilgotnosc.TabIndex = 16;
            // 
            // txbCisnienie
            // 
            this.txbCisnienie.Location = new System.Drawing.Point(128, 118);
            this.txbCisnienie.Name = "txbCisnienie";
            this.txbCisnienie.Size = new System.Drawing.Size(101, 20);
            this.txbCisnienie.TabIndex = 15;
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(6, 118);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(101, 20);
            this.txbTemperatura.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Odebrane dane";
            // 
            // lblStatusSerialConnection
            // 
            this.lblStatusSerialConnection.AutoSize = true;
            this.lblStatusSerialConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusSerialConnection.Location = new System.Drawing.Point(228, 63);
            this.lblStatusSerialConnection.Name = "lblStatusSerialConnection";
            this.lblStatusSerialConnection.Size = new System.Drawing.Size(0, 20);
            this.lblStatusSerialConnection.TabIndex = 4;
            // 
            // lblStatusSerial
            // 
            this.lblStatusSerial.AutoSize = true;
            this.lblStatusSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusSerial.Location = new System.Drawing.Point(243, 28);
            this.lblStatusSerial.Name = "lblStatusSerial";
            this.lblStatusSerial.Size = new System.Drawing.Size(0, 20);
            this.lblStatusSerial.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(11, 54);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // bntCancelSerialTest
            // 
            this.bntCancelSerialTest.Enabled = false;
            this.bntCancelSerialTest.Location = new System.Drawing.Point(118, 19);
            this.bntCancelSerialTest.Name = "bntCancelSerialTest";
            this.bntCancelSerialTest.Size = new System.Drawing.Size(101, 29);
            this.bntCancelSerialTest.TabIndex = 1;
            this.bntCancelSerialTest.Text = "Stop";
            this.bntCancelSerialTest.UseVisualStyleBackColor = true;
            this.bntCancelSerialTest.Click += new System.EventHandler(this.bntCancelSerialTest_Click);
            // 
            // btnStartSerialTest
            // 
            this.btnStartSerialTest.Location = new System.Drawing.Point(11, 19);
            this.btnStartSerialTest.Name = "btnStartSerialTest";
            this.btnStartSerialTest.Size = new System.Drawing.Size(101, 29);
            this.btnStartSerialTest.TabIndex = 0;
            this.btnStartSerialTest.Text = "Start";
            this.btnStartSerialTest.UseVisualStyleBackColor = true;
            this.btnStartSerialTest.Click += new System.EventHandler(this.btnStartSerialTest_Click);
            // 
            // tabServer
            // 
            this.tabServer.Controls.Add(this.groupBox6);
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(792, 424);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "Ustawienia Serwera";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txbServerIp);
            this.groupBox6.Controls.Add(this.maskedPortServer);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(776, 96);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Połączenie";
            // 
            // txbServerIp
            // 
            this.txbServerIp.Location = new System.Drawing.Point(28, 41);
            this.txbServerIp.Name = "txbServerIp";
            this.txbServerIp.Size = new System.Drawing.Size(100, 20);
            this.txbServerIp.TabIndex = 4;
            this.txbServerIp.Validated += new System.EventHandler(this.txbServerIp_Validated);
            // 
            // maskedPortServer
            // 
            this.maskedPortServer.Location = new System.Drawing.Point(205, 41);
            this.maskedPortServer.Mask = "####";
            this.maskedPortServer.Name = "maskedPortServer";
            this.maskedPortServer.Size = new System.Drawing.Size(43, 20);
            this.maskedPortServer.TabIndex = 3;
            this.maskedPortServer.Validated += new System.EventHandler(this.maskedPortServer_Validated);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(202, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Port:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Adres Ip:";
            // 
            // tabDB
            // 
            this.tabDB.Controls.Add(this.groupBox5);
            this.tabDB.Controls.Add(this.groupBox4);
            this.tabDB.Location = new System.Drawing.Point(4, 22);
            this.tabDB.Name = "tabDB";
            this.tabDB.Size = new System.Drawing.Size(792, 424);
            this.tabDB.TabIndex = 2;
            this.tabDB.Text = "Baza Danych";
            this.tabDB.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnValidateDB);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txbDatabase);
            this.groupBox5.Controls.Add(this.txbUID);
            this.groupBox5.Controls.Add(this.txbServer);
            this.groupBox5.Controls.Add(this.maskedPassword);
            this.groupBox5.Location = new System.Drawing.Point(8, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(751, 122);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Połączenie";
            // 
            // btnValidateDB
            // 
            this.btnValidateDB.Location = new System.Drawing.Point(670, 84);
            this.btnValidateDB.Name = "btnValidateDB";
            this.btnValidateDB.Size = new System.Drawing.Size(75, 23);
            this.btnValidateDB.TabIndex = 8;
            this.btnValidateDB.Text = "Waliduj";
            this.btnValidateDB.UseVisualStyleBackColor = true;
            this.btnValidateDB.Click += new System.EventHandler(this.btnValidateDB_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(461, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Baza:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(157, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Login:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Hasło:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Serwer MySQL:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txbDatabase
            // 
            this.txbDatabase.Location = new System.Drawing.Point(464, 44);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(120, 20);
            this.txbDatabase.TabIndex = 3;
            this.txbDatabase.TextChanged += new System.EventHandler(this.txbDatabase_TextChanged);
            // 
            // txbUID
            // 
            this.txbUID.Location = new System.Drawing.Point(160, 44);
            this.txbUID.Name = "txbUID";
            this.txbUID.Size = new System.Drawing.Size(120, 20);
            this.txbUID.TabIndex = 2;
            this.txbUID.Validated += new System.EventHandler(this.txbUID_Validated);
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(15, 44);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(120, 20);
            this.txbServer.TabIndex = 1;
            this.txbServer.TextChanged += new System.EventHandler(this.txbServer_TextChanged);
            this.txbServer.Validated += new System.EventHandler(this.txbServer_Validated);
            // 
            // maskedPassword
            // 
            this.maskedPassword.Location = new System.Drawing.Point(315, 44);
            this.maskedPassword.Name = "maskedPassword";
            this.maskedPassword.PasswordChar = '*';
            this.maskedPassword.Size = new System.Drawing.Size(120, 20);
            this.maskedPassword.TabIndex = 0;
            this.maskedPassword.Validated += new System.EventHandler(this.maskedPassword_Validated);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnCheckCount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.nmrDeleteCount);
            this.groupBox4.Controls.Add(this.nmrStatCount);
            this.groupBox4.Location = new System.Drawing.Point(8, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(751, 233);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Obsługa";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(475, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 33);
            this.button6.TabIndex = 20;
            this.button6.Text = "Przywróć";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(335, 73);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 33);
            this.button7.TabIndex = 19;
            this.button7.Text = "Backup";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Liczba rekordów do usunięcia";
            // 
            // btnCheckCount
            // 
            this.btnCheckCount.Location = new System.Drawing.Point(15, 73);
            this.btnCheckCount.Name = "btnCheckCount";
            this.btnCheckCount.Size = new System.Drawing.Size(120, 33);
            this.btnCheckCount.TabIndex = 17;
            this.btnCheckCount.Text = "Oblicz";
            this.btnCheckCount.UseVisualStyleBackColor = true;
            this.btnCheckCount.Click += new System.EventHandler(this.btnCheckCount_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Ilość rekordów";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(172, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "USUŃ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nmrDeleteCount
            // 
            this.nmrDeleteCount.Location = new System.Drawing.Point(172, 47);
            this.nmrDeleteCount.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.nmrDeleteCount.Name = "nmrDeleteCount";
            this.nmrDeleteCount.Size = new System.Drawing.Size(120, 20);
            this.nmrDeleteCount.TabIndex = 1;
            // 
            // nmrStatCount
            // 
            this.nmrStatCount.Location = new System.Drawing.Point(15, 47);
            this.nmrStatCount.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.nmrStatCount.Name = "nmrStatCount";
            this.nmrStatCount.Size = new System.Drawing.Size(120, 20);
            this.nmrStatCount.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // backgroundValidateDB
            // 
            this.backgroundValidateDB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundValidateDB_DoWork);
            this.backgroundValidateDB.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundValidateDB_RunWorkerCompleted);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOptions_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormOptions_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabSerial.ResumeLayout(false);
            this.tabSerial.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabDB.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDeleteCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStatCount)).EndInit();
            this.ResumeLayout(false);

        }

        private void FormOptions_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void txbEndOfFrame_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbBeginOfPressure_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbBeginOfTemperature_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbBeginOfHumidity_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSerial;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TabPage tabDB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSerialInfo;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txbEndOfFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txbBeginOfHumidity;
        private System.Windows.Forms.MaskedTextBox txbBeginOfTemperature;
        private System.Windows.Forms.MaskedTextBox txbBeginOfPressure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbWilgotnosc;
        private System.Windows.Forms.TextBox txbCisnienie;
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblStatusSerialConnection;
        private System.Windows.Forms.Label lblStatusSerial;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button bntCancelSerialTest;
        private System.Windows.Forms.Button btnStartSerialTest;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnSaveFrame;
        private System.Windows.Forms.Button btnSaveSerialPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCheckCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nmrDeleteCount;
        private System.Windows.Forms.NumericUpDown nmrStatCount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox maskedPassword;
        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.TextBox txbUID;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnValidateDB;
        private System.ComponentModel.BackgroundWorker backgroundValidateDB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox maskedPortServer;
        private System.Windows.Forms.TextBox txbServerIp;
    }
}