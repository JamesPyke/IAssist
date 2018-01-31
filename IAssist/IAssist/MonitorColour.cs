using System;
using System.Runtime.InteropServices;

namespace IAssist
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MonitorColour
    {
        public static MonitorColour Default = new MonitorColour(128, 128, 128);
        public static MonitorColour Turquoise = new MonitorColour(58, 137, 117);
        public static MonitorColour LightBlue = new MonitorColour(84, 113, 179);
        public static MonitorColour Yellow = new MonitorColour(153, 120, 24);
        public static MonitorColour LightYellow = new MonitorColour(124, 124, 20);
        public static MonitorColour Green = new MonitorColour(71, 140, 64);
        public static MonitorColour Purple = new MonitorColour(89, 49, 119);

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public UInt16[] R;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public UInt16[] G;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public UInt16[] B;

        public int RawRed;
        public int RawGreen;
        public int RawBlue;

        private const int MaxValue = 65535;

        public MonitorColour(int red, int green, int blue)
        {
            RawRed = red;
            RawGreen = green;
            RawBlue = blue;

            R = new ushort[256];
            G = new ushort[256];
            B = new ushort[256];

            for (int i = 1; i < 256; i++)
            {
                int redValue = i * (red + 128);
                if (redValue > MaxValue)
                    redValue = MaxValue;
                R[i] = (ushort)redValue;

                int greenValue = i * (green + 128);
                if (greenValue > MaxValue)
                    greenValue = MaxValue;
                G[i] = (ushort)greenValue;

                int blueValue = i * (blue + 128);
                if (blueValue > MaxValue)
                    blueValue = MaxValue;
                B[i] = (ushort)blueValue;
            }
        }

        public static bool operator ==(MonitorColour a, MonitorColour b)
        {
            return (a.R == b.R && a.G == b.G && a.B == b.B);
        }

        public static bool operator !=(MonitorColour a, MonitorColour b)
        {
            return !(a == b);
        }
    }
}
