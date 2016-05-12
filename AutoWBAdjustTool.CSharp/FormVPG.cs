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
    public partial class FormVPG : Form
    {
        public FormVPG()
        {
            InitializeComponent();
        }

        private VPGChroma vpgChroma;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            vpgChroma = new VPGChroma("22294");
            vpgChroma.InitVPGDevice();
            vpgChroma.ChangeTiming(textBoxTiming.Text);
            vpgChroma.ChangePattern(textBoxW80.Text);
        }

        private void FormVPG_Load(object sender, EventArgs e)
        {

        }
    }
}
