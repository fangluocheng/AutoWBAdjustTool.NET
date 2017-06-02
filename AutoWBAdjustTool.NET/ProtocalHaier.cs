using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoWBAdjustTool.NET
{
    class ProtocalHaier : IProtocal
    {
        public ProtocalHaier()
        {
            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = 0x00;
            }
        }

        private byte[] mCmdByte = new byte[12];

        private byte CalChkSum(byte[] data)
        {
            // byte10 is the checksum byte.
            // byte10 = 0xFF - byte1 - byte2 - ... - byte9 + 1
            // If it hits 0xFF, ignore 0xFF and plus 1 instead.
            byte result = 0xFF;

            for (int i = 0; i <= 9; i++)
            {
                if (data[i] == 255)
                    result = (byte)(result + 1);
                else
                {
                    if (result < data[i])
                        result = (byte)(256 - (data[i] - result));
                    else
                        result = (byte)(result - data[i]);
                }
            }

            if (result == 255)
                result = 0x00;
            else
                result = (byte)(result + 1);

            return result;
        }

        byte[] IProtocal.CmdByte
        {
            get
            {
                return mCmdByte;
            }
        }

        void IProtocal.EnterFacMode() { }
        void IProtocal.ExitFacMode() { }

        void IProtocal.SwitchInputSrc(string inputSrcType, byte inputSrcPort)
        {
            // 55 2E 01 XX 00 00 00 00 00 00 CHK FE
            // HDMI1: 55 2E 01 07 00 00 00 00 00 00 CA FE
            mCmdByte[0] = 0x55;
            mCmdByte[1] = 0x2E;
            mCmdByte[2] = 0x01;

            if (inputSrcType.ToUpper() == "HDMI")
                mCmdByte[3] = (byte)(inputSrcPort + 0x06);
            else if (inputSrcType.ToUpper() == "AV")
                mCmdByte[3] = 0x03;
            else if (inputSrcType.ToUpper() == "YPBPR")
                mCmdByte[3] = 0x05;
            else
                mCmdByte[3] = 0x07;

            for (int i = 4; i <= 9; i++)
                mCmdByte[i] = 0x00;

            mCmdByte[10] = CalChkSum(mCmdByte);
            mCmdByte[11] = 0xFE;
        }

        void IProtocal.ResetPicMode()
        {
            // 55 34 00 00 00 00 00 00 00 00 CC FE
            byte[] data = { 0x55, 0x34, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xCC, 0xFE };

            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }

        void IProtocal.SetBrightness(byte value)
        {
            // 55 37 02 XX XX 00 00 00 00 00 CHK FE
            mCmdByte[0] = 0x55;
            mCmdByte[1] = 0x37;
            mCmdByte[2] = 0x02;
            mCmdByte[3] = (byte)(value / 256);
            mCmdByte[4] = (byte)(value % 256);

            for (int i = 5; i <= 9; i++)
                mCmdByte[i] = 0x00;

            mCmdByte[10] = CalChkSum(mCmdByte);
            mCmdByte[11] = 0xFE;
        }

        void IProtocal.SetContrast(byte value)
        {
            // 55 39 02 XX XX 00 00 00 00 00 CHK FE
            mCmdByte[0] = 0x55;
            mCmdByte[1] = 0x39;
            mCmdByte[2] = 0x02;
            mCmdByte[3] = (byte)(value / 256);
            mCmdByte[4] = (byte)(value % 256);

            for (int i = 5; i <= 9; i++)
                mCmdByte[i] = 0x00;

            mCmdByte[10] = CalChkSum(mCmdByte);
            mCmdByte[11] = 0xFE;
        }

        void IProtocal.SetBacklight(byte value)
        {
            // 55 3B 02 XX XX 00 00 00 00 00 CHK FE
            mCmdByte[0] = 0x55;
            mCmdByte[1] = 0x3B;
            mCmdByte[2] = 0x02;
            mCmdByte[3] = (byte)(value / 256);
            mCmdByte[4] = (byte)(value % 256);

            for (int i = 5; i <= 9; i++)
                mCmdByte[i] = 0x00;

            mCmdByte[10] = CalChkSum(mCmdByte);
            mCmdByte[11] = 0xFE;
        }

        void IProtocal.SelColorTemp(string T, string inputSrcType, byte inputSrcPort)
        {
            // 55 02 01 XX 00 00 00 00 00 00 CHK FE
            mCmdByte[0] = 0x55;
            mCmdByte[1] = 0x02;
            mCmdByte[2] = 0x01;

            switch (T)
            {
                case "Cool":
                    mCmdByte[3] = 0x00;
                    break;
                case "Standard":
                    mCmdByte[3] = 0x01;
                    break;
                case "Warm":
                    mCmdByte[3] = 0x02;
                    break;
                default:
                    mCmdByte[3] = 0x00;
                    break;
            }

            for (int i = 4; i <= 9; i++)
                mCmdByte[i] = 0x00;

            mCmdByte[10] = CalChkSum(mCmdByte);
            mCmdByte[11] = 0xFE;
        }

        void IProtocal.SetRGBGain(string rgb, int value)
        {
            // R: 55 0A 02 XX XX 00 00 00 00 00 CHK FE
            // G: 55 0B 02 XX XX 00 00 00 00 00 CHK FE
            // B: 55 0C 02 XX XX 00 00 00 00 00 CHK FE
            mCmdByte[0] = 0x55;

            switch (rgb.ToUpper())
            {
                case "R":
                    mCmdByte[1] = 0x0A;
                    break;
                case "G":
                    mCmdByte[1] = 0x0B;
                    break;
                case "B":
                    mCmdByte[1] = 0x0C;
                    break;
                default:
                    mCmdByte[1] = 0x0A;
                    break;
            }
            
            mCmdByte[2] = 0x02;
            mCmdByte[3] = (byte)(value / 256);
            mCmdByte[4] = (byte)(value % 256);

            for (int i = 5; i <= 9; i++)
                mCmdByte[i] = 0x00;

            mCmdByte[10] = CalChkSum(mCmdByte);
            mCmdByte[11] = 0xFE;
        }

        void IProtocal.SetRGBOffset(string rgb, int value)
        {
            // R: 55 04 02 XX XX 00 00 00 00 00 CHK FE
            // G: 55 05 02 XX XX 00 00 00 00 00 CHK FE
            // B: 55 06 02 XX XX 00 00 00 00 00 CHK FE
            mCmdByte[0] = 0x55;

            switch (rgb.ToUpper())
            {
                case "R":
                    mCmdByte[1] = 0x04;
                    break;
                case "G":
                    mCmdByte[1] = 0x05;
                    break;
                case "B":
                    mCmdByte[1] = 0x06;
                    break;
                default:
                    mCmdByte[1] = 0x04;
                    break;
            }

            mCmdByte[2] = 0x02;
            mCmdByte[3] = (byte)((value + 1024) / 256);
            mCmdByte[4] = (byte)((value + 1024) % 256);

            for (int i = 5; i <= 9; i++)
                mCmdByte[i] = 0x00;

            mCmdByte[10] = CalChkSum(mCmdByte);
            mCmdByte[11] = 0xFE;
        }

        void IProtocal.SaveWBDataToOtherSrcs(string inputSrcType, byte inputSrcPort)
        {
            // 55 01 01 06 00 00 00 00 00 00 F8 FE
            byte[] data = { 0x55, 0x01, 0x01, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0xFE };

            for (int i = 0; i < mCmdByte.Length; i++)
            {
                mCmdByte[i] = data[i];
            }
        }
    }
}
