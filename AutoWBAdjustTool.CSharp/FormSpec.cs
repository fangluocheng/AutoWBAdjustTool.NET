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
    public partial class FormSpec : Form
    {
        public FormSpec()
        {
            InitializeComponent();
        }

        private string brandName = ConfigXmlHandler.GetNodeValue("tvBrand");
        private string modelName = ConfigXmlHandler.GetNodeValue("tvModel");

        private void FormSpec_Load(object sender, EventArgs e)
        {
            if (ConfigXmlHandler.GetAttributeValueByNode("adjustOffset", "enable").ToLower() == "true")
                checkBoxAdjustOffset.Checked = true;
            else
                checkBoxAdjustOffset.Checked = false;

            if (ConfigXmlHandler.GetAttributeValueByNode("checkColorTemp", "enable").ToLower() == "true")
                checkBoxCheckColorTemp.Checked = true;
            else
                checkBoxCheckColorTemp.Checked = false;
            
            textBoxCoolx.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "colorTempCool", "x");
            textBoxCooly.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "colorTempCool", "y");
            if (ConfigXmlHandler.GetAttributeValueByBrand(brandName, "colorTempCool", "enable").ToLower() == "true")
            {
                checkBoxCool.Checked = true;
                textBoxCoolx.ReadOnly = false;
                textBoxCooly.ReadOnly = false;
            }
            else
            {
                checkBoxCool.Checked = false;
                textBoxCoolx.ReadOnly = true;
                textBoxCooly.ReadOnly = true;
            }

            textBoxStandardx.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "colorTempStandard", "x");
            textBoxStandardy.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "colorTempStandard", "y");
            if (ConfigXmlHandler.GetAttributeValueByBrand(brandName, "colorTempStandard", "enable").ToLower() == "true")
            {
                checkBoxStandard.Checked = true;
                textBoxStandardx.ReadOnly = false;
                textBoxStandardy.ReadOnly = false;
            }
            else
            {
                checkBoxStandard.Checked = false;
                textBoxStandardx.ReadOnly = true;
                textBoxStandardy.ReadOnly = true;
            }

            textBoxWarmx.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "colorTempWarm", "x");
            textBoxWarmy.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "colorTempWarm", "y");
            if (ConfigXmlHandler.GetAttributeValueByBrand(brandName, "colorTempWarm", "enable").ToLower() == "true")
            {
                checkBoxWarm.Checked = true;
                textBoxWarmx.ReadOnly = false;
                textBoxWarmy.ReadOnly = false;
            }
            else
            {
                checkBoxWarm.Checked = false;
                textBoxWarmx.ReadOnly = true;
                textBoxWarmy.ReadOnly = true;
            }

            textBoxTolGain.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "toleranceGain");
            textBoxTolOffset.Text = ConfigXmlHandler.GetNodeValueByBrand(brandName, "toleranceOffset");
            textBoxMagicValGainx.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "magicValueGain", "x");
            textBoxMagicValGainy.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "magicValueGain", "y");
            textBoxMagicValOffsetx.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "magicValueOffset", "x");
            textBoxMagicValOffsety.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "magicValueOffset", "y");
        }

        private void checkBoxCool_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCool.Checked)
            {
                textBoxCoolx.ReadOnly = false;
                textBoxCooly.ReadOnly = false;
            }
            else
            {
                textBoxCoolx.ReadOnly = true;
                textBoxCooly.ReadOnly = true;
            }
        }

        private void checkBoxStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStandard.Checked)
            {
                textBoxStandardx.ReadOnly = false;
                textBoxStandardy.ReadOnly = false;
            }
            else
            {
                textBoxStandardx.ReadOnly = true;
                textBoxStandardy.ReadOnly = true;
            }
        }

        private void checkBoxWarm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWarm.Checked)
            {
                textBoxWarmx.ReadOnly = false;
                textBoxWarmy.ReadOnly = false;
            }
            else
            {
                textBoxWarmx.ReadOnly = true;
                textBoxWarmy.ReadOnly = true;
            }
        }
    }
}
