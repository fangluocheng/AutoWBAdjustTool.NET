using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoWBAdjustTool.NET
{
    interface IProtocal
    {
        byte[] CmdByte { get; }

        void EnterFacMode();
        void ExitFacMode();
        void SwitchInputSrc(string inputSrcType, byte inputSrcPort);
        // Set picture mode to standard.
        void ResetPicMode();
        void SetBrightness(byte value);
        void SetContrast(byte value);
        void SetBacklight(byte value);
        void SelColorTemp(string T, string inputSrcType, byte inputSrcPort);
        void SetRGBGain(string rgb, int value);
        void SetRGBOffset(string rgb, int value);
        void SaveWBDataToOtherSrcs(string inputSrcType, byte inputSrcPort);
    }
}
