using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            foreach (string itemComMode in comModeList)
            {
                if (itemComMode == ConfigXmlHandler.GetAttributeValueByNode("communication", "mode"))
                {
                    index = comModeList.IndexOf(itemComMode);
                }
            }
            comboBoxComMode.SelectedIndex = index;

            textBoxTvBarcodeLen.Text = ConfigXmlHandler.GetNodeValue("tvBarcodeLen");
        }

        private void comboBoxComMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = comboBoxComMode.SelectedIndex;
        }
    }
}
