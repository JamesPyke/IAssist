using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IAssist
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref Colour lpRamp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Colour
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        public static void SetColourTemperature(int red, int green, int blue)
        {
            int maxValue = 65535;

            Colour colour = new Colour
            {
                Red = new ushort[256],
                Green = new ushort[256],
                Blue = new ushort[256]
            };

            for (int i = 1; i < 256; i++)
            {
                int redValue = i * (red + 128);
                if (redValue > maxValue)
                    redValue = maxValue;
               
                colour.Red[i] = (ushort)redValue;

                int greenValue = i * (green + 128);
                if (greenValue > maxValue)
                    greenValue = maxValue;
                colour.Green[i] = (ushort)greenValue;

                int blueValue = i * (blue + 128);
                if (blueValue > maxValue)
                    blueValue = maxValue;
                colour.Blue[i] = (ushort)blueValue;
            }

            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref colour);
        }

        private void UpdateSliderLabels()
        {
            LblRedAmount.Text = SldrRed.Value.ToString();
            LblGreenAmount.Text = SldrGreen.Value.ToString();
            LblBlueAmount.Text = SldrBlue.Value.ToString();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateSliderLabels();
        }

        private void SldrRed_ValueChanged(object sender, EventArgs e)
        {
            LblRedAmount.Text = SldrRed.Value.ToString();
        }

        private void SldrGreen_ValueChanged(object sender, EventArgs e)
        {
            LblGreenAmount.Text = SldrGreen.Value.ToString();
        }

        private void SldrBlue_ValueChanged(object sender, EventArgs e)
        {
            LblBlueAmount.Text = SldrBlue.Value.ToString();
        }

        private void BtnSetColourTemperature_Click(object sender, EventArgs e)
        {
            SetColourTemperature(SldrRed.Value, SldrGreen.Value, SldrBlue.Value);
        }

        private void BtnResetColourTemperature_Click(object sender, EventArgs e)
        {
            SldrRed.Value = SldrGreen.Value = SldrBlue.Value = 128;
            BtnSetColourTemperature_Click(this, null);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnResetColourTemperature_Click(this, null);
        }

        private void BtnClickLightBlue(object sender, MouseEventArgs e)
        {
            SldrRed.Value = 84;
            SldrGreen.Value = 113;
            SldrBlue.Value = 179;
            BtnSetColourTemperature_Click(this, null);
        }

        private void BtnClickTurquoise(object sender, MouseEventArgs e)
        {
            SldrRed.Value = 58;
            SldrGreen.Value = 137;
            SldrBlue.Value = 117;
            BtnSetColourTemperature_Click(this, null);
        }

        private void BtnClickGreen(object sender, MouseEventArgs e)
        {
            SldrRed.Value = 71;
            SldrGreen.Value = 140;
            SldrBlue.Value = 64;
            BtnSetColourTemperature_Click(this, null);
        }

        private void BtnClickLightYellow(object sender, MouseEventArgs e)
        {
            SldrRed.Value = 124;
            SldrGreen.Value = 124;
            SldrBlue.Value = 20;
            BtnSetColourTemperature_Click(this, null);
        }

        private void BtnClickYellow(object sender, MouseEventArgs e)
        {
            SldrRed.Value = 153;
            SldrGreen.Value = 120;
            SldrBlue.Value = 24;
            BtnSetColourTemperature_Click(this, null);
        }

        private void BtnClickPurple(object sender, MouseEventArgs e)
        {
            SldrRed.Value = 89;
            SldrGreen.Value = 49;
            SldrBlue.Value = 119;
            BtnSetColourTemperature_Click(this, null);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                tryIcon.Visible = true;
                this.Hide();
            }
        }

        private void tryIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            tryIcon.Visible = false;
        }
    }
}