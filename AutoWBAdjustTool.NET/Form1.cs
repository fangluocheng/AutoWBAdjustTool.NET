using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CA200SRVRLib;

namespace AutoWBAdjustTool.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Ca200 objCa200;
        private Ca objCa;
        private Probe objProbe;
        private Memory objMemory;
        private bool caConnected, isMsr;

        private void Form1_Load(object sender, EventArgs e)
        {
            reconnectCa:
            isMsr = false;
            caConnected = false;
            try
            {
                objCa200 = new Ca200();
                objCa200.AutoConnect();
                objCa = objCa200.SingleCa;
                objProbe = objCa.SingleProbe;
                objMemory = objCa.Memory;
                caConnected = true;
                Application.DoEvents();
            }
            catch(Exception)
            {
                if (MessageBox.Show("请连接 CA310/CA210", "连接异常",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    goto reconnectCa;
                }
                else
                {
                    this.Dispose();
                }
            }            
            
            FormSplash formSplash = new FormSplash();
            formSplash.TopMost = true;
            this.Hide();
            this.ShowInTaskbar = false;

            if (formSplash.ShowDialog() == DialogResult.OK)
            {
                if (ConfigXmlHandler.GetNodeValue("tvBrand").ToUpper() == "CAN")
                {
                    pictureBoxLogo.Image = global::AutoWBAdjustTool.NET.Properties.Resources.CANTV;
                }
                else if (ConfigXmlHandler.GetNodeValue("tvBrand").ToUpper() == "HAIER")
                {
                    pictureBoxLogo.Image = global::AutoWBAdjustTool.NET.Properties.Resources.Haier;
                }
                else if (ConfigXmlHandler.GetNodeValue("tvBrand").ToUpper() == "LETV")
                {
                    pictureBoxLogo.Image = global::AutoWBAdjustTool.NET.Properties.Resources.Letv;
                }

                labelModelName.Text = ConfigXmlHandler.GetNodeValue("tvModel");

                this.ShowInTaskbar = true;
                this.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (caConnected)
                objCa.RemoteMode = 0;
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

        private void toolStripMenuItemConnectCa_Click(object sender, EventArgs e)
        {
            if (isMsr)
            {
                objCa.RemoteMode = 1;
                return;
            }
            else
            {
                if (MessageBox.Show("请将 CA310/CA210 的探头切换到 0-CAL", "CA310/CA210 初始化", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {                    
                    retry:
                    try
                    {
                        objCa.CalZero();
                        objCa.SyncMode = 3;
                        objCa.AveragingMode = 2;
                        objCa.SetAnalogRange((float)2.5, (float)2.5);
                        objCa.DisplayMode = 0;
                        objMemory.ChannelNO = int.Parse(ConfigXmlHandler.GetNodeValue("caChannel"));

                        if (MessageBox.Show("请将 CA310/CA210 的探头切换到 MEAS", "CA310/CA210 测试模式",
                            MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            isMsr = true;
                        }
                    }
                    catch (Exception)
                    {
                        if (MessageBox.Show("CA310/CA210 较零异常\n需要重试吗？", "CalZero", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            if (isMsr)
                                objCa.RemoteMode = 0;

                            return;                            
                        }
                        goto retry;
                    }
                }
            }
        }

        private void toolStripMenuItemDisconnectCa_Click(object sender, EventArgs e)
        {
            if (isMsr)
                objCa.RemoteMode = 0;
        }        
    }
}
