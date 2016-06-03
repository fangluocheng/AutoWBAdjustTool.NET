using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoWBAdjustTool.CSharp
{
    class ProtocalLetv : IProtocal
    {
        public ProtocalLetv()
        {
            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = 0x00;
            }
        }

        private byte[] mCmdByte = new byte[10];               

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
            // 6E 51 86 03 FE E1 A0 00 01 04
            byte[] data = { 0x6E, 0x51, 0x86, 0x03, 0xFE, 0xE1, 0xA0, 0x00, 0x01, 0x04 }; 
            
            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }

        void IProtocal.ExitFacMode()
        {
            // 6E 51 86 03 FE E1 A0 00 00 05
            byte[] data = { 0x6E, 0x51, 0x86, 0x03, 0xFE, 0xE1, 0xA0, 0x00, 0x00, 0x05 };

            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }

        void IProtocal.SwitchInputSrc(string inputSrcType, byte inputSrcPort)
        {
            // HDMI1: 6E 51 86 03 FE 60 00 23 02 05
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;
            mCmdByte[5] = 0x60;
            mCmdByte[6] = 0x00;

            if (inputSrcType.ToUpper() == "HDMI")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x03);
            else if (inputSrcType.ToUpper() == "AV")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x05);
            else if (inputSrcType.ToUpper() == "YPBPR")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x07);
            else
                mCmdByte[7] = 0x23;

            mCmdByte[8] = 0x02;
            mCmdByte[9] = CalChkSum(mCmdByte);
        }

        void IProtocal.ResetPicMode()
        {
            // 6E 51 86 03 FE E1 A7 05 01 06
            byte[] data = { 0x6E, 0x51, 0x86, 0x03, 0xFE, 0xE1, 0xA7, 0x05, 0x01, 0x06 };

            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }

        void IProtocal.SetBrightness(byte value)
        {
            // 6E 51 86 03 FE 10 00 XX XX CHK
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;
            mCmdByte[5] = 0x10;
            mCmdByte[6] = 0x00;
            mCmdByte[7] = (byte)(value / 256);
            mCmdByte[8] = (byte)(value % 256);
            mCmdByte[9] = CalChkSum(mCmdByte);
        }

        void IProtocal.SetContrast(byte value)
        {
            // 6E 51 86 03 FE 12 00 XX XX CHK
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;
            mCmdByte[5] = 0x12;
            mCmdByte[6] = 0x00;
            mCmdByte[7] = (byte)(value / 256);
            mCmdByte[8] = (byte)(value % 256);
            mCmdByte[9] = CalChkSum(mCmdByte);
        }

        void IProtocal.SetBacklight(byte value)
        {
            // 6E 51 86 03 FE 13 00 XX XX CHK
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;
            mCmdByte[5] = 0x13;
            mCmdByte[6] = 0x00;
            mCmdByte[7] = (byte)(value / 256);
            mCmdByte[8] = (byte)(value % 256);
            mCmdByte[9] = CalChkSum(mCmdByte);
        }

        void IProtocal.SelColorTemp(string T, string inputSrcType, byte inputSrcPort)
        {
            /* HDMI1
             * Cool:     6E 51 86 03 FE 14 0A 23 01 78
             * Standard: 6E 51 86 03 FE 14 06 23 01 74
             * Warm:     6E 51 86 03 FE 14 05 23 01 77 */
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;
            mCmdByte[5] = 0x14;

            switch (T)
            {
                case "Cool":
                    mCmdByte[6] = 0x0A;
                    break;
                case "Standard":
                    mCmdByte[6] = 0x06;
                    break;
                case "Warm":
                    mCmdByte[6] = 0x05;
                    break;
                default:
                    mCmdByte[6] = 0x0A;
                    break;
            }

            if (inputSrcType.ToUpper() == "HDMI")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x03);
            else if (inputSrcType.ToUpper() == "AV")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x05);
            else if (inputSrcType.ToUpper() == "YPBPR")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x07);
            else
                mCmdByte[7] = 0x23;

            mCmdByte[8] = 0x01;
            mCmdByte[9] = CalChkSum(mCmdByte);
        }

        void IProtocal.SetRGBGain(string rgb, int value)
        {
            /* R: 6E 51 86 03 FE 16 00 XX XX CHK
             * G: 6E 51 86 03 FE 18 00 XX XX CHK
             * B: 6E 51 86 03 FE 1A 00 XX XX CHK */
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;

            switch (rgb.ToUpper())
            {
                case "R":
                    mCmdByte[5] = 0x16;
                    break;
                case "G":
                    mCmdByte[5] = 0x18;
                    break;
                case "B":
                    mCmdByte[5] = 0x1A;
                    break;
                default:
                    mCmdByte[5] = 0x16;
                    break;
            }

            mCmdByte[6] = 0x00;
            mCmdByte[7] = (byte)(value / 256);
            mCmdByte[8] = (byte)(value % 256);
            mCmdByte[9] = CalChkSum(mCmdByte);
        }

        void IProtocal.SetRGBOffset(string rgb, int value)
        {
            /* R: 6E 51 86 03 FE 6C 00 XX XX CHK
             * G: 6E 51 86 03 FE 6E 00 XX XX CHK
             * B: 6E 51 86 03 FE 70 00 XX XX CHK */
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;

            switch (rgb.ToUpper())
            {
                case "R":
                    mCmdByte[5] = 0x6C;
                    break;
                case "G":
                    mCmdByte[5] = 0x6E;
                    break;
                case "B":
                    mCmdByte[5] = 0x70;
                    break;
                default:
                    mCmdByte[5] = 0x6C;
                    break;
            }

            mCmdByte[6] = 0x00;
            mCmdByte[7] = (byte)(value / 256);
            mCmdByte[8] = (byte)(value % 256);
            mCmdByte[9] = CalChkSum(mCmdByte);
        }

        void IProtocal.SaveWBDataToOtherSrcs(string inputSrcType, byte inputSrcPort)
        {
            // HDMI1: 6E 51 86 03 FE 14 05 23 00 76
            mCmdByte[0] = 0x6E;
            mCmdByte[1] = 0x51;
            mCmdByte[2] = 0x86;
            mCmdByte[3] = 0x03;
            mCmdByte[4] = 0xFE;
            mCmdByte[5] = 0x14;
            mCmdByte[6] = 0x05;

            if (inputSrcType.ToUpper() == "HDMI")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x03);
            else if (inputSrcType.ToUpper() == "AV")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x05);
            else if (inputSrcType.ToUpper() == "YPBPR")
                mCmdByte[7] = (byte)(0x20 * inputSrcPort + 0x07);
            else
                mCmdByte[7] = 0x23;

            mCmdByte[8] = 0x00;
            mCmdByte[9] = CalChkSum(mCmdByte);
        }
    }
}
