using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace SerialConnect
{
    static class SerialFactory
    {

        public static Serial CreateSerial(SerialPort serial) {
            Serial serialport = new Serial();
            serialport.setSerial(serial);

            return serialport;
        }

        public static Serial CopySerial(SerialPort serial, Serial original)
        {
            Serial copy = new Serial();
            original.CopySerialPort(serial);
            original.CopySerialSettings(copy);
            copy.setSerial(serial);

            return copy;
        }
    }
}
