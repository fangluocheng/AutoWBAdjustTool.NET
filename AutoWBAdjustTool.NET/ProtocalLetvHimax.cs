using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoWBAdjustTool.NET
{
    class ProtocalLetvHimax : IProtocal
    {
        public ProtocalLetvHimax()
        {
            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = 0x00;
            }
        }

        private byte[] mCmdByte = new byte[7];

        private byte CalChkSum(byte[] data)
        {
            byte result = 0x00;

            for (int i = 0; i < mCmdByte.Length - 1; i++)
            {
                result = (byte)(result ^ data[i]);
            }
            return result;
        }

        byte[] IProtocal.CmdByte
        {
            get
            {
                return mCmdByte;
            }
        }

        void IProtocal.EnterFacMode()
        {
            // 6E 51 84 03 FF 00 01 46
            byte[] data = { 0x51, 0x84, 0x03, 0xFF, 0x00, 0x01, 0x46 };

            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }

        void IProtocal.ExitFacMode()
        {
            // 6E 51 84 03 FF 00 00 47
            byte[] data = { 0x51, 0x84, 0x03, 0xFF, 0x00, 0x00, 0x47 };

            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }

        void IProtocal.SwitchInputSrc(string inputSrcType, byte inputSrcPort)
        {
            // HDMI1: 6E 51 84 03 60 00 03 DB
            mCmdByte[0] = 0x51;
            mCmdByte[1] = 0x84;
            mCmdByte[2] = 0x03;
            mCmdByte[3] = 0x60;
            mCmdByte[4] = 0x00;
            mCmdByte[5] = (byte)(0x04 - inputSrcPort);
            mCmdByte[6] = (byte)(CalChkSum(mCmdByte) ^ 0x6E);
        }

        void IProtocal.ResetPicMode() { }

        void IProtocal.SetBrightness(byte value)
        {
            // 6E 51 84 03 10 00 XX CHK
            mCmdByte[0] = 0x51;
            mCmdByte[1] = 0x84;
            mCmdByte[2] = 0x03;
            mCmdByte[3] = 0x10;
            mCmdByte[4] = 0x00;
            mCmdByte[5] = (byte)(value % 256);
            mCmdByte[6] = (byte)(CalChkSum(mCmdByte) ^ 0x6E);
        }

        void IProtocal.SetContrast(byte value)
        {
            // 6E 51 84 03 12 00 XX CHK
            mCmdByte[0] = 0x51;
            mCmdByte[1] = 0x84;
            mCmdByte[2] = 0x03;
            mCmdByte[3] = 0x12;
            mCmdByte[4] = 0x00;
            mCmdByte[5] = (byte)(value % 256);
            mCmdByte[6] = (byte)(CalChkSum(mCmdByte) ^ 0x6E);
        }

        void IProtocal.SetBacklight(byte value)
        {
            // 6E 51 84 03 13 00 XX CHK
            mCmdByte[0] = 0x51;
            mCmdByte[1] = 0x84;
            mCmdByte[2] = 0x03;
            mCmdByte[3] = 0x13;
            mCmdByte[4] = 0x00;
            mCmdByte[5] = (byte)(value % 256);
            mCmdByte[6] = (byte)(CalChkSum(mCmdByte) ^ 0x6E);
        }

        void IProtocal.SelColorTemp(string T, string inputSrcType, byte inputSrcPort)
        {
            // Cool:     6E 51 84 03 14 00 02 AE
            // Standard: 6E 51 84 03 14 00 01 AD
            // Warm:     6E 51 84 03 14 00 00 AC
            mCmdByte[0] = 0x51;
            mCmdByte[1] = 0x84;
            mCmdByte[2] = 0x03;
            mCmdByte[3] = 0x14;
            mCmdByte[4] = 0x00;

            switch (T)
            {
                case "Cool":
                    mCmdByte[5] = 0x02;
                    break;
                case "Standard":
                    mCmdByte[5] = 0x01;
                    break;
                case "Warm":
                    mCmdByte[5] = 0x00;
                    break;
                default:
                    mCmdByte[5] = 0x02;
                    break;
            }

            mCmdByte[6] = (byte)(CalChkSum(mCmdByte) ^ 0x6E);
        }

        void IProtocal.SetRGBGain(string rgb, int value)
        {
            // R: 6E 51 84 03 16 00 XX CHK
            // G: 6E 51 84 03 18 00 XX CHK
            // B: 6E 51 84 03 1A 00 XX CHK
            mCmdByte[0] = 0x51;
            mCmdByte[1] = 0x84;
            mCmdByte[2] = 0x03;

            switch (rgb.ToUpper())
            {
                case "R":
                    mCmdByte[3] = 0x16;
                    break;
                case "G":
                    mCmdByte[3] = 0x18;
                    break;
                case "B":
                    mCmdByte[3] = 0x1A;
                    break;
                default:
                    mCmdByte[3] = 0x16;
                    break;
            }

            mCmdByte[4] = 0x00;
            mCmdByte[5] = (byte)(value % 256);
            mCmdByte[6] = (byte)(CalChkSum(mCmdByte) ^ 0x6E);
        }

        void IProtocal.SetRGBOffset(string rgb, int value)
        {
            // R: 6E 51 84 03 6C 00 XX CHK
            // G: 6E 51 84 03 6E 00 XX CHK
            // B: 6E 51 84 03 70 00 XX CHK
            mCmdByte[0] = 0x51;
            mCmdByte[1] = 0x84;
            mCmdByte[2] = 0x03;

            switch (rgb.ToUpper())
            {
                case "R":
                    mCmdByte[3] = 0x6C;
                    break;
                case "G":
                    mCmdByte[3] = 0x6E;
                    break;
                case "B":
                    mCmdByte[3] = 0x70;
                    break;
                default:
                    mCmdByte[3] = 0x6C;
                    break;
            }

            mCmdByte[4] = 0x00;
            mCmdByte[5] = (byte)(value % 256);
            mCmdByte[6] = (byte)(CalChkSum(mCmdByte) ^ 0x6E);
        }

        void IProtocal.SaveWBDataToOtherSrcs(string inputSrcType, byte inputSrcPort)
        {
            // 6E 51 84 03 BC 00 01 05
            byte[] data = { 0x51, 0x84, 0x03, 0xBC, 0x00, 0x01, 0x05 };

            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }
    }
}
