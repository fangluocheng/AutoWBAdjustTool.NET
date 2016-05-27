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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormSplash formSplash = new FormSplash();
            formSplash.TopMost = true;
            this.Hide();
            this.ShowInTaskbar = false;

            if (formSplash.ShowDialog() == DialogResult.OK)
            {
                if (ConfigXmlHandler.GetNodeValue("tvBrand").ToUpper() == "CAN")
                {
                    pictureBoxLogo.Image = global::AutoWBAdjustTool.CSharp.Properties.Resources.CANTV;
                }
                else if (ConfigXmlHandler.GetNodeValue("tvBrand").ToUpper() == "HAIER")
                {
                    pictureBoxLogo.Image = global::AutoWBAdjustTool.CSharp.Properties.Resources.Haier;
                }

                this.ShowInTaskbar = true;
                this.Show();
            }
        }

        private void toolStripMenuItemVPG_Click(object sender, EventArgs e)
        {
            FormVPG formVPG = new FormVPG();
            formVPG.Show();
        }

        private void toolStripMenuItemSpecSetting_Click(object sender, EventArgs e)
        {
            FormSpec formSpec = new FormSpec();
            formSpec.Show();
        }

        private void toolStripMenuItemCommonSetting_Click(object sender, EventArgs e)
        {
            FormCommonSetting formCommonSetting = new FormCommonSetting();
            formCommonSetting.Show();
        }

        private void toolStripMenuItemColorAnalyzer_Click(object sender, EventArgs e)
        {
            FormColorAnalyzer formColorAnalyzer = new FormColorAnalyzer();
            formColorAnalyzer.Show();
        }
    }
}
