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
            // Color Temperature
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

            // RGB Preset
            textBoxPreGainCoolR.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "cool", "r");
            textBoxPreGainCoolG.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "cool", "g");
            textBoxPreGainCoolB.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "cool", "b");

            textBoxPreGainStandardR.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "standard", "r");
            textBoxPreGainStandardG.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "standard", "g");
            textBoxPreGainStandardB.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "standard", "b");

            textBoxPreGainWarmR.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "warm", "r");
            textBoxPreGainWarmG.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "warm", "g");
            textBoxPreGainWarmB.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "warm", "b");

            textBoxRgbGainMax.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "max");
            textBoxRgbGainMin.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetGain", "min");

            textBoxPreOffsetCoolR.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "cool", "r");
            textBoxPreOffsetCoolG.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "cool", "g");
            textBoxPreOffsetCoolB.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "cool", "b");

            textBoxPreOffsetStandardR.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "standard", "r");
            textBoxPreOffsetStandardG.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "standard", "g");
            textBoxPreOffsetStandardB.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "standard", "b");

            textBoxPreOffsetWarmR.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "warm", "r");
            textBoxPreOffsetWarmG.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "warm", "g");
            textBoxPreOffsetWarmB.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "warm", "b");

            textBoxRgbOffsetMax.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "max");
            textBoxRgbOffsetMin.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "rgbPresetOffset", "min");

            // Lv Spec
            textBoxLvSpec.Text = ConfigXmlHandler.GetNodeValueByBrandAndModel(brandName, modelName, "LvSpec");
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
