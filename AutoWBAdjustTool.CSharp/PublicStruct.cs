using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoWBAdjustTool.CSharp
{
    public class PublicStruct
    { 
        public struct WhiteBalanceData
        {
            public Chromaticity specCool;
            public Chromaticity specStandard;
            public Chromaticity specWarm;
            public byte tolGain;
            public byte tolOffset;
            public Chromaticity magicValueGain;
            public Chromaticity magicValueOffset;
            public Rgb rgbPresetGainCool;
            public Rgb rgbPresetGainStandard;
            public Rgb rgbPresetGainWarm;
            public Rgb rgbPresetOffsetCool;
            public Rgb rgbPresetOffsetStandard;
            public Rgb rgbPresetOffsetWarm;
            public int rgbGainMax;
            public int rgbGainMin;
            public int rgbOffsetMax;
            public int rgbOffsetMin;
            public int specLv;
        }

        public struct Chromaticity
        {
            public int x;
            public int y;
        }

        public struct Rgb
        {
            public int R;
            public int G;
            public int B;
        }

        public static WhiteBalanceData WBData;
    }
}
