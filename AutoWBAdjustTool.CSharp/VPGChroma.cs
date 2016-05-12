using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VPGCtrl;

namespace AutoWBAdjustTool.CSharp
{
    class VPGChroma
    {
        public VPGChroma(string model)
        {
            m_Model = model;
        }

        private string m_Model;
        private bool m_IsConnected;
        private IVPGCtrl m_VPGCtrl;

        #region VPGChroma_PROPERTY
        public string Model
        {
            set { m_Model = value; }
            get { return m_Model; }
        }
        public bool IsConnected
        {
            get { return m_IsConnected; }
        }
        #endregion

        public void InitVPGDevice()
        {
            switch (m_Model)
            {
                case "2401":
                    m_VPGCtrl = new VPGCtrl_24xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG2401);
                    break;
                case "2402":
                    m_VPGCtrl = new VPGCtrl_24xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG2402);
                    break;
                case "22293":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG22293);
                    break;
                case "22293_A":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG22293_A);
                    break;
                case "22293_B":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG22293_B);
                    break;
                case "2233":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG2233);
                    break;
                case "2233_A":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG2233_A);
                    break;
                case "2233_B":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG2233_B);
                    break;
                case "2333_B":
                    m_VPGCtrl = new VPGCtrl_24xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG2333_B);
                    break;
                case "23293_B":
                    m_VPGCtrl = new VPGCtrl_24xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG23293_B);
                    break;
                case "2234":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG2234);
                    break;
                case "22294":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG22294);
                    break;
                case "22294_A":
                    m_VPGCtrl = new VPGCtrl_22xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG22294_A);
                    break;
                case "23294":
                    m_VPGCtrl = new VPGCtrl_24xx();
                    m_VPGCtrl.InitDevice(IVPGCtrl.VPG_MODEL.VPG23294);
                    break;
            }
        }

        public void ChangeTiming(string timing)
        {
            byte[] bNo = new byte[2];
            bNo[0] = (byte)((Convert.ToInt32(timing) & 0xFF00) >> 8);
            bNo[1] = (byte)(Convert.ToInt32(timing) & 0xFF);

            m_VPGCtrl.ExecuteCmd(IVPGCtrl.VPG_CMD.CM_DOWNLOAD, IVPGCtrl.VPG_SCMD.SCM_CTL_RUNTIM, ref bNo, false);
        }

        public void ChangePattern(string pattern)
        {
            byte[] bNo = new byte[2];
            bNo[0] = (byte)((Convert.ToInt32(pattern) & 0xFF00) >> 8);
            bNo[1] = (byte)(Convert.ToInt32(pattern) & 0xFF);

            m_VPGCtrl.RunKey(IVPGCtrl.VPG_KEY.CKEY_OUT);
            m_VPGCtrl.ExecuteCmd(IVPGCtrl.VPG_CMD.CM_DOWNLOAD, IVPGCtrl.VPG_SCMD.SCM_CTL_RUNPTN, ref bNo, false);
        }
    }
}
