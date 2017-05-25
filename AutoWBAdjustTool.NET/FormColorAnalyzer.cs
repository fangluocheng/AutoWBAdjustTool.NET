using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoWBAdjustTool.NET
{
    public partial class FormColorAnalyzer : Form
    {
        public FormColorAnalyzer()
        {
            InitializeComponent();
        }

        private void FormColorAnalyzer_Load(object sender, EventArgs e)
        {
            foreach (string itemCaModel in comboBoxCaModel.Items)
            {
                if (itemCaModel == ConfigXmlHandler.GetNodeValue("caModel"))
                {
                    comboBoxCaModel.SelectedIndex = comboBoxCaModel.Items.IndexOf(itemCaModel);
                }

                textBoxCaChannel.Text = ConfigXmlHandler.GetNodeValue("caChannel");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ConfigXmlHandler.SetNodeValue("caModel", comboBoxCaModel.Text);
            ConfigXmlHandler.SetNodeValue("caChannel", textBoxCaChannel.Text);
            ConfigXmlHandler.SaveConfigXml();

            this.Hide();
        }
    }
}
