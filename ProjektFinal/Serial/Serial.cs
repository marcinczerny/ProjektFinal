using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO.Ports;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace SerialConnect
{
  public struct messageDecoded
  {
    public float temperature;
    public float pressure;
    public float humidity;
  }


  public class Serial
  {
    private SerialPort UART;
    public long baudRate;
    public string portName;

    public float temperature;
    public float pressure;
    public float humidity;

    public string IncommingMessage;
    public messageDecoded decodedMessage;

    string leftInBuffer;

    public bool IsOpen
    {
      get { return UART.IsOpen; }
    }

    private string errMessage;
    public string ErrMessage
    {
      get => errMessage;
      set => errMessage = value;
    }
    public void setSerial(SerialPort serial) {
      this.UART = serial;
    }

    public void CopySerialPort(SerialPort serialCopy)
    {
      serialCopy.BaudRate = UART.BaudRate;
      serialCopy.PortName = UART.PortName;
    }
    public void CopySerialSettings(Serial copy)
    {
      copy.baudRate = this.baudRate;
      copy.portName = this.portName;
    }
    public SerialPort getSerialPort()
    {
      return UART;
    }
    public Serial()
    {
      decodedMessage = new messageDecoded();
    }
    public void Open(string portName, int baud)
    {
      UART.PortName = portName;
      UART.BaudRate = baud;
      if (!UART.IsOpen)
      {
        try
        {
          UART.Open();
          UART.DiscardInBuffer();
        }
        catch (IOException e)
        {
          throw e;
        }

      }
    }
    public void Close()
    {
      try {
        UART.Close();
      }
      catch (IOException)
      {

      }

    }

    public string ReadMessage()
    {
      string result;
      if (UART.IsOpen)
      {

        result = UART.ReadExisting();
        //   int leftInBufor = BytesToRead;

        // while (leftInBufor > 0)
        //{
        //   leftInBufor = GetDataFromSerial();
        //}
        //}
        return result;

      }

      return null;
    }
    public void Write(string msg)
    {
      try
      {
        UART.Write(msg);
      }
      catch (InvalidOperationException)
      {

      }
    }
    public static List<string> GetPortNames() {
      List<string> result = new List<string>();

      using (var searcher = new ManagementObjectSearcher
          ("SELECT * FROM WIN32_SerialPort"))
      {
        string[] portnames = SerialPort.GetPortNames();
        var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
        var tList = (from n in portnames
                     join p in ports on n equals p["DeviceID"].ToString()
                     select n + " - " + p["Caption"]).ToList();

        foreach (string t in tList) {
          result.Add(t);
        }
      }

      return result;
    }


    public bool DecodeMessage(ref string message)
    {
      message = leftInBuffer + message;

      int endFrame = message.IndexOf(ProjektFinal.Properties.Settings.Default.charEndOfSerialFrame);
      if (endFrame == -1)
      {
        return false;
      }

      int beginFrame = message.IndexOf(ProjektFinal.Properties.Settings.Default.charBeginOfTemperature);
      if (beginFrame == -1 || beginFrame > endFrame)
      {
        message = message.Substring(endFrame + 1);
        return true;
      }
      try
      {
        //T3093H8892P1014
        string result = message.Substring(beginFrame, endFrame - beginFrame + 1);
        Debug.WriteLine($"Res: {result}");

        int indexOfT = result.IndexOf(ProjektFinal.Properties.Settings.Default.charBeginOfTemperature);
        int indexOfH = result.IndexOf(ProjektFinal.Properties.Settings.Default.charBeginOfHumidity);
        int indexOfP = result.IndexOf(ProjektFinal.Properties.Settings.Default.charBeginOfPressure);
        int indexOfAmp = result.IndexOf(ProjektFinal.Properties.Settings.Default.charEndOfSerialFrame);
        string tempString = result.Substring(indexOfT + 1, (indexOfH-indexOfT-1));
        string humString = result.Substring(indexOfH + 1, (indexOfP - indexOfH - 1));
        string presString = result.Substring(indexOfP + 1, (indexOfAmp - indexOfP - 1));

        this.humidity = float.Parse(humString, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture) / 100;
        this.pressure = float.Parse(presString, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture);
        this.temperature = float.Parse(tempString, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture) / 100;
      } catch (ArgumentOutOfRangeException)
      {
        message = message.Substring(endFrame + 1);
        return true;
      }



      message = message.Substring(endFrame + 1);

      return true;
    }


  }
}
