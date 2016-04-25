using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml.Linq;
using System.IO;

namespace FacInfoCheckingTool.CSharp
{
    public partial class FormSerialPortSetting : Form
    {
        public FormSerialPortSetting()
        {
            InitializeComponent();
        }

        private void FormSerialPortSetting_Load(object sender, EventArgs e)
        {
            int index = 0;

            comboBoxBaudRate.Text = ConfigXmlHandler.comBaudRate;

            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Count(); i++)
            {
                comboBoxComId.Items.Add(ports[i]);
                
                if (ports[i] == "COM" + ConfigXmlHandler.comId)
                {
                    index = i;
                }
            }

            comboBoxComId.SelectedIndex = index;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string xmlFileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\config.xml";
            ConfigXmlHandler configXml = new ConfigXmlHandler(xmlFileName);

            configXml.ComBaudRate = comboBoxBaudRate.Text;
            configXml.ComId = comboBoxComId.Text.Substring(3);
            configXml.SaveConfigXml();

            ConfigXmlHandler.comBaudRate = comboBoxBaudRate.Text;
            ConfigXmlHandler.comId = comboBoxComId.Text.Substring(3);

            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
