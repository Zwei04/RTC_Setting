using System;
using System.Windows.Forms;

namespace setRTC
{
    public partial class Form1 : Form
    {
        private Arduino arduino = new Arduino();
        private bool connection = false;
        private string RTCTimeTemp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelRTCTime.Text = "Unknown";
            AddComPorts();
        }

        private void AddComPorts()
        {
            foreach (string ComPort in arduino.GetPort())
                ComboBoxPorts.Items.Add(ComPort);
            if (ComboBoxPorts.Items.Count > 0)
                ComboBoxPorts.SelectedIndex = 0;
        }

        private void UpdateUI()
        {
            if(connection)
            {
                StripStatusLabel.Text = "Connected to " + ComboBoxPorts.SelectedItem.ToString();
                SetRTCTime.Enabled = true;
                labelRTCTime.Text = arduino.getRTCTime();
            }
            else
            {
                StripStatusLabel.Text = "Disconnected";
                labelRTCTime.Text = "UNKNOWN";
                SetRTCTime.Enabled = false;
                RTCTimeTemp = "";
            }
        }

        private void SetRTCTime_Click(object sender, EventArgs e)
        {
            arduino.setRTCTime(DateTime.Now);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelSysTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            RTCTimeTemp = arduino.getRTCTime();
            labelRTCTime.Text = RTCTimeTemp;
            if (connection)
            {
                if(RTCTimeTemp=="UNKNOWN")
                {
                    connection = false;
                    arduino.disconnect();
                    UpdateUI();
                    ComboBoxPorts.SelectedIndex = 0;
                }
                
            }
            
        }

        private void ComboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            String PortName = ComboBoxPorts.SelectedItem.ToString();

            if (connection && PortName == "Disconnect")
            {
                arduino.disconnect();
                connection = false;
                UpdateUI();
            }
            else if(connection && PortName != "Disconnect")
            {
                arduino.disconnect();
                bool result = arduino.connect(PortName);
                if (result)
                {
                    result = arduino.handshake();
                }
                else return;
                if (result)
                {
                    connection = true;
                    UpdateUI();
                }
                else return;
            }
            else if(!connection && PortName == "Disconnect")
            {
                connection = false;
                UpdateUI();
            }
            else
            {
                bool result = arduino.connect(PortName);
                if (result)
                {
                    result = arduino.handshake();
                }
                else return;
                if (result)
                {
                    connection = true;
                    UpdateUI();
                }
                else
                {
                    arduino.disconnect();
                    ComboBoxPorts.SelectedIndex = 0;   
                    return;
                }
            }
        }

        private void ComboBoxPorts_Click(object sender, EventArgs e)
        {
            ComboBoxPorts.Items.Clear();
            ComboBoxPorts.Items.Add("Disconnect");
            AddComPorts();
        }

        private void labelRTCTime_Click(object sender, EventArgs e)
        {

        }
    }
}
