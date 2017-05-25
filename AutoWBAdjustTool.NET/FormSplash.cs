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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            int index = 0;

            /* Load Brand and Model from config.xml. And initialize the 
             * items of comboBoxBrand and comboBoxModel. */
            foreach (string itemBrand in ConfigXmlHandler.GetBrandList())
            {
                comboBoxBrand.Items.Add(itemBrand);

                if (itemBrand == ConfigXmlHandler.GetNodeValue("tvBrand"))
                {
                    index = ConfigXmlHandler.GetBrandList().ToList().IndexOf(itemBrand);
                }
            }
            comboBoxBrand.SelectedIndex = index;

            comboBoxModel.Items.Clear();
            IEnumerable<string> modelList = ConfigXmlHandler.GetModelList(comboBoxBrand.Text);
            foreach (string itemModel in modelList)
            {
                comboBoxModel.Items.Add(itemModel);

                if (itemModel == ConfigXmlHandler.GetNodeValue("tvModel"))
                {
                    index = modelList.ToList().IndexOf(itemModel);
                }
            }
            comboBoxModel.SelectedIndex = index;

            showLogo();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ConfigXmlHandler.SetNodeValue("tvBrand", comboBoxBrand.Text);
            ConfigXmlHandler.SetNodeValue("tvModel", comboBoxModel.Text);
            ConfigXmlHandler.SaveConfigXml();

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<string> queryModels = ConfigXmlHandler.GetModelList(comboBoxBrand.Text);
            comboBoxModel.Items.Clear();
            foreach (string itemModel in queryModels)
            {
                comboBoxModel.Items.Add(itemModel);
            }
            comboBoxModel.SelectedIndex = 0;

            showLogo();
        }

        private void showLogo()
        {
            if (comboBoxBrand.Text.ToUpper() == "CAN")
            {
                pictureBoxLogo.Image = global::AutoWBAdjustTool.NET.Properties.Resources.CANTV;
            }
            else if (comboBoxBrand.Text.ToUpper() == "HAIER")
            {
                pictureBoxLogo.Image = global::AutoWBAdjustTool.NET.Properties.Resources.Haier;
            }
            else if (comboBoxBrand.Text.ToUpper() == "LETV")
            {
                pictureBoxLogo.Image = global::AutoWBAdjustTool.NET.Properties.Resources.Letv;
            }
        }
    }
}
