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
    public partial class FormVPG : Form
    {
        public FormVPG()
        {
            InitializeComponent();
        }

        private VPGChroma vpgChroma;        

        private void FormVPG_Load(object sender, EventArgs e)
        {
            foreach (string itemChromaModel in comboBoxChromaModel.Items)
            {
                if (itemChromaModel == ConfigXmlHandler.GetNodeValue("vpgModel"))
                {
                    comboBoxChromaModel.SelectedIndex = comboBoxChromaModel.Items.IndexOf(itemChromaModel);
                }
            }

            textBoxChromaTiming.Text = ConfigXmlHandler.GetNodeValue("vpgTiming");
            textBoxChromaGray.Text = ConfigXmlHandler.GetNodeValue("vpgPatternGray");
            textBoxChromaWhite.Text = ConfigXmlHandler.GetNodeValue("vpgPatternWhite");
            textBoxChroma100IRE.Text = ConfigXmlHandler.GetNodeValue("vpgPattern100IRE");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            vpgChroma = new VPGChroma("22294");
            vpgChroma.InitVPGDevice();
            vpgChroma.ChangeTiming(textBoxChromaTiming.Text);
            vpgChroma.ChangePattern(textBoxChromaWhite.Text);

            ConfigXmlHandler.SetNodeValue("vpgModel", comboBoxChromaModel.Text);
            ConfigXmlHandler.SetNodeValue("vpgTiming", textBoxChromaTiming.Text);
            ConfigXmlHandler.SetNodeValue("vpgPatternGray", textBoxChromaGray.Text);
            ConfigXmlHandler.SetNodeValue("vpgPatternWhite", textBoxChromaWhite.Text);
            ConfigXmlHandler.SetNodeValue("vpgPattern100IRE", textBoxChroma100IRE.Text);
            ConfigXmlHandler.SaveConfigXml();

            this.Hide();
        }
    }
}
