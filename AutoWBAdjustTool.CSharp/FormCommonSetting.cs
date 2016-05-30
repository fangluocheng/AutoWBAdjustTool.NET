using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace AutoWBAdjustTool.CSharp
{
    public partial class FormCommonSetting : Form
    {
        public FormCommonSetting()
        {
            InitializeComponent();
        }

        private void FormCommonSetting_Load(object sender, EventArgs e)
        {
            int index = 0;
            var comModeList = new List<string> { "serialPort", "network", "i2c" };

            foreach (string itemInputSrc in comboBoxInputSrc.Items)
            {
                if (itemInputSrc == ConfigXmlHandler.GetNodeValue("tvInputSrc"))
                {
                    index = comboBoxInputSrc.Items.IndexOf(itemInputSrc);
                }
            }
            comboBoxInputSrc.SelectedIndex = index;

            textBoxTvBarcodeLen.Text = ConfigXmlHandler.GetNodeValue("tvBarcodeLen");

            foreach (string itemComMode in comModeList)
            {
                if (itemComMode == ConfigXmlHandler.GetAttributeValueByNode("communication", "mode"))
                {
                    index = comModeList.IndexOf(itemComMode);
                }
            }
            comboBoxComMode.SelectedIndex = index;            

            // Serial Port
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxComId.Items.Add(port);

                if (port == ConfigXmlHandler.GetAttributeValueByNode("communication", "serialPort", "id"))
                {
                    index = ports.ToList().IndexOf(port);
                }
            }
            if (ports.Count() > 0)
            {
                comboBoxComId.SelectedIndex = index;
            }

            comboBoxBaudRate.Text = ConfigXmlHandler.GetAttributeValueByNode("communication", "serialPort", "baud");

            // Network
            ipAddressControl1.Text = ConfigXmlHandler.GetAttributeValueByNode("communication", "network", "ipAddr");

            // I2C
            foreach (string itemClockRate in comboBoxI2cClockRate.Items)
            {
                if (itemClockRate == ConfigXmlHandler.GetAttributeValueByNode("communication", "i2c", "clockRate"))
                {
                    index = comboBoxI2cClockRate.Items.IndexOf(itemClockRate);
                }
            }
            comboBoxI2cClockRate.SelectedIndex = index;
        }

        private void comboBoxComMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = comboBoxComMode.SelectedIndex;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var comModeList = new List<string> { "serialPort", "network", "i2c" };

            ConfigXmlHandler.SetNodeValue("tvInputSrc", comboBoxInputSrc.Text);
            ConfigXmlHandler.SetNodeValue("tvBarcodeLen", textBoxTvBarcodeLen.Text);
            ConfigXmlHandler.SetAttributeValueByNode("communication", "mode",
                comModeList[comboBoxComMode.SelectedIndex]);
            if (comboBoxComId.Text != "")
            {
                ConfigXmlHandler.SetAttributeValueByNode("communication", "serialPort",
                    "id", comboBoxComId.Text);
                ConfigXmlHandler.SetAttributeValueByNode("communication", "serialPort",
                    "baud", comboBoxBaudRate.Text);
            }
            ConfigXmlHandler.SetAttributeValueByNode("communication", "network",
                "ipAddr", ipAddressControl1.Text);
            ConfigXmlHandler.SetAttributeValueByNode("communication", "i2c",
                "clockRate", comboBoxI2cClockRate.Text);
            ConfigXmlHandler.SaveConfigXml();

            this.Hide();
        }
    }
}
