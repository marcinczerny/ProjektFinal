﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialConnect;
using BazaDanychMySQL;

namespace ProjektFinal
{
    public struct SaverToDB
    {
        public bool saveCompletedWithoutError;
        public int tryToSaveCount;
    }
    public partial class Form1 : Form
    {
        ManageForms mng;
        Serial serial;
        string leftInBuffer;
        DBConnect baza;

        object serialMutex;
        object dbCollectionMutex;

        List<string> sqlToSaveCollection;
        timespan[] timespans = { timespan.day, timespan.hour, timespan.minute, timespan.sample };

        bool appValidated;
        SaverToDB saverTo;


        public Form1()
        {
            InitializeComponent();

            mng = new ManageForms(this);
            mng.SendClick += new ManageForms.SendClickHandler(formOption_Close);

            serial = SerialFactory.CreateSerial(this.serialPort1);
            SetSerialPort();
            baza = new DBConnect(Properties.Settings.Default.stringServer,Properties.Settings.Default.stringUID,Properties.Settings.Default.stringDBPassword,Properties.Settings.Default.stringDatabase);

            btnDisconnectSerial.Enabled = false;
            panelClosedSerial.BackColor = Color.Red;

            serialMutex = new object();

            foreach (timespan tspan in timespans)
            {
                cmbAggregation.Items.Add(tspan);
            }
            cmbAggregation.SelectedIndex = 1;

            appValidated = false;

            sqlToSaveCollection = new List<string>();
            dbCollectionMutex = new object();

            saverTo = new SaverToDB();

            ValidateApp();
        }

        private void formOption_Close(object sender, EventArgs e)
        {
            ValidateApp();
        }

        private void konfiguracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mng.FormOpened() == false)
            {
                mng.ViewOptions(serial);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Close();
        }

        public void SetSerialPort()
        {
            lblPortName.Text = Properties.Settings.Default.stringPortName;
            lblPortBaud.Text = Properties.Settings.Default.intBaudRate.ToString();
        }

        private void CloseSerialConnection()
        {
            serial.Close();
            panelClosedSerial.BackColor = Color.Red;
            panelOpenedSerial.BackColor = DefaultBackColor;
            btnConnectSerial.Enabled = true;
            btnDisconnectSerial.Enabled = false;
            pictureSerial.BackColor = Color.DarkRed;
            pictureBT.BackColor = Color.DarkRed;
            pictureUControler.BackColor = Color.DarkRed;
        }

        private void OpenSerialConnection()
        {
            if (mng.FormOpened() == true || serial.IsOpen)
            {
                return;
            }
            string port = Properties.Settings.Default.stringPortName;
            port = port.Substring(0, port.IndexOf(' '));
            try
            {
                serial.Open(port, Properties.Settings.Default.intBaudRate);
            }
            catch(System.IO.IOException ex)
            {
                    MessageBox.Show(ex.Message);
                    return;
             }
            btnDisconnectSerial.Enabled = true;
            btnConnectSerial.Enabled = false;
            panelClosedSerial.BackColor = DefaultBackColor;
            panelOpenedSerial.BackColor = Color.Green;
            pictureSerial.BackColor = Color.Green;
            pictureBT.BackColor = Color.Green;
            pictureUControler.BackColor = Color.Green;
        }

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            OpenSerialConnection();
        }

        private void btnDisconnectSerial_Click(object sender, EventArgs e)
        {
            CloseSerialConnection();
        }

        delegate void delegatForIncomingSerial();
        private void SetIncommingSerialValues()
        {
            bool sendingSuccesfull;
            if (this.numericUpDown1.InvokeRequired)
            {
                delegatForIncomingSerial d = new delegatForIncomingSerial(SetIncommingSerialValues); //dodanie delegata do kolejki
                this.numericUpDown1.BeginInvoke(d, new object[] { });  //tutej
            }
            else
            {
                try
                {
                    lock (serialMutex)
                    {
                        numericPressure.Value = Convert.ToDecimal(serial.pressure);
                        numericTemperature.Value = Convert.ToDecimal(serial.temperature);
                        numericHumidity.Value = Convert.ToDecimal(serial.humidity);
                    }
                    
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SetDbCountersNumerics(int count, bool correct)
        {
            if (correct == true)
                numericUpDown1.Value = numericUpDown1.Value + count;
            else
                numericUpDown2.Value = numericUpDown2.Value + count;
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            float temp, pres, hum;
            string query;


            bool result;
            string dane = serial.ReadMessage();
            lock (serialMutex)
            {
                dane = leftInBuffer + dane;
                
                do
                {
                    result = serial.DecodeMessage(ref dane);

                    if (result)
                    {
                        

                        temp = serial.temperature;
                        pres = serial.pressure;
                        hum = serial.humidity;
                        query = baza.CreateInsertQuery(DateTime.Now,temp, pres, hum);

                        lock (dbCollectionMutex)
                        {
                            sqlToSaveCollection.Add(query);
                        }
                        SetIncommingSerialValues();
                        /*try
                        {
                            bool temporary;
                            temporary = baza.Insert(query);

                            SetInsertedToDBMessagesNumber(temporary);
                        }catch(Exception ex)
                        {
                            SetInsertedToDBMessagesNumber(false);
                        }*/


                    }

                } while (result == true);

                leftInBuffer = dane;
            }
        }

        private void phoneClient1_Load(object sender, EventArgs e)
        {

        }

        public void ValidateApp()
        {
            baza.Server = Properties.Settings.Default.stringServer;
            baza.Uid = Properties.Settings.Default.stringUID;
            baza.Password = Properties.Settings.Default.stringDBPassword;
            baza.Database = Properties.Settings.Default.stringDatabase;
            if (!backgroundValidate.IsBusy)
                backgroundValidate.RunWorkerAsync();            
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            var times = cmbAggregation.SelectedItem;

            timespan ts = (timespan)Enum.Parse(typeof(timespan), times.ToString());

            string query = baza.CreateSelectQuery(ts, (int)nmrUnits.Value, false);

            List<string>[] result = new List<string>[4];
            result = baza.Select(query);


            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series[1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series[2].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "g";
            chart1.ChartAreas[1].AxisX.LabelStyle.Format = "g";
            chart1.ChartAreas[2].AxisX.LabelStyle.Format = "g";


            DrawChart(result[0], result[1], result[2], result[3]);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmbAggregation_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void DrawChart(List<string> timestamp, List<string> temperature, List<string> pressure, List<string> humidity)
        {

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            for (int i = 0; i < timestamp.Count; i++)
            {
                try
                {
                    DateTime timeOnX = DateTime.Parse(timestamp[i]);
                    float temperatureOnY = Convert.ToSingle(temperature[i]);
                    float pressureOnY = Convert.ToSingle(pressure[i]);
                    float humidityOnY = Convert.ToSingle(humidity[i]);

                    chart1.Series[0].Points.AddXY(timeOnX, temperatureOnY);
                    chart1.Series[1].Points.AddXY(timeOnX, pressureOnY);
                    chart1.Series[2].Points.AddXY(timeOnX, humidityOnY);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Brak argumentu " + ex);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Błąd formatu: " + ex);
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Błąd przepełnienia " + ex);
                }
            }

        }

        private void backgroundValidate_DoWork(object sender, DoWorkEventArgs e)
        {
            if(baza.ValidateDB() == true)
            {
                appValidated = true;
            }
            else
            {
                appValidated = false;
            }
        }

        private void backgroundValidate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (appValidated == true)
            {
                pictureDatabase.BackColor = Color.Green;
            }
            else
            {
                pictureDatabase.BackColor = Color.Red;
            }
        }

        private void backgroundSerial_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundSerial_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void timerDatabase_Tick(object sender, EventArgs e)
        {
            int count;   
            lock (dbCollectionMutex)
            {
                count = sqlToSaveCollection.Count;
            }
            if (count == 0)
            {
                return;
            }
            if (!backgroundSQLSender.IsBusy)
            {
                backgroundSQLSender.RunWorkerAsync();
            }
            else
            {
                //trudno, niech się kasuje, nie mam pomysłu :/
                lock (dbCollectionMutex)
                {
                    numericUpDown2.Value += sqlToSaveCollection.Count;
                    sqlToSaveCollection.Clear();
                }               
            }
        }

        private void backgroundSQLSender_DoWork(object sender, DoWorkEventArgs e)
        {
            string tempSQL="";
            int tryToSaveCount;
            lock (dbCollectionMutex)
            {
                foreach(string s in sqlToSaveCollection)
                {
                    tempSQL += s + "\n\r";
                }
                saverTo.tryToSaveCount = sqlToSaveCollection.Count;
                sqlToSaveCollection.Clear();
            }
            try
            {
                saverTo.saveCompletedWithoutError = baza.Insert(tempSQL);
            }
            catch(Exception ex)
            {
                saverTo.saveCompletedWithoutError = false;
            }
        }

        private void backgroundSQLSender_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetDbCountersNumerics(saverTo.tryToSaveCount, saverTo.saveCompletedWithoutError);
        }
    }
}
