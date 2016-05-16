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
    }
}
