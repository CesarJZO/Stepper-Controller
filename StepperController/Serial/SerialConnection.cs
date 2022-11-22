using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace StepperController.Serial
{
    public class SerialConnection
    {
        public SerialPort Port { get; }

        public SerialConnection()
        {
            Port = new SerialPort("COM6", 9600);
            Port.Open();
        }

        public void SendMessage(string message)
        {
            if (Port.IsOpen)
                Port.Write(message);
        }
    }
}
