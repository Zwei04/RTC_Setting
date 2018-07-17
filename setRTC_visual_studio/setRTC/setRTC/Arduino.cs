using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace setRTC
{
    class Arduino
    {
        private SerialPort serialPort;
        private string Memport;

        public string[] GetPort()
        {
            return SerialPort.GetPortNames();
        }

        public bool connect(string serialPortName)
        {
            Memport = serialPortName;
            serialPort = new SerialPort(serialPortName, 9600);
            serialPort.NewLine = "\r\n";
            serialPort.ReadTimeout = 500;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open serial port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool handshake()
        {
            string response = "";
            for (int i = 0; i < 3; i++)
            {
                serialPort.WriteLine("HI");

                response = "";
                try
                {
                    response = serialPort.ReadLine();
                }
                catch (Exception)
                {
                    if (i == 2)
                    {
                        MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                       
                }
                if (!response.Equals(""))
                    i = 3;
            }
            if (response.Equals("IH")) return true;
            MessageBox.Show("Unknown device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public string getRTCTime()
        {
            try
            {
                serialPort.WriteLine("T?");
            }
            catch(Exception)
            {
                //MessageBox.Show("Port is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "UNKNOWN";
            }
            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "UNKNOWN";
            }
            return response;
        }

        public bool setRTCTime(DateTime time)
        {
            // Wait until we're 200ms before the next second
            while (DateTime.Now.Millisecond != 850)
                Thread.Sleep(1);

            string command = "T^" + time.AddSeconds(1).ToString("ddMMyyyyHHmmss");
            serialPort.WriteLine(command);

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Equals("Success"))
            {
                MessageBox.Show("RTC is sync!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Wrong response from RTC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void disconnect()
        {
            try
            {
                serialPort.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Serial port is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
