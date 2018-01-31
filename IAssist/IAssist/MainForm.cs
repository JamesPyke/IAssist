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

        private bool showBalloon = true;

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref MonitorColour lpRamp);

        private MonitorColour setColour;

        public void SetColourTemperature(MonitorColour colour)
        {
            if(colour != MonitorColour.Default)
            { 
                setColour = colour;
            }
            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref colour);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LblRedAmount.Text = SldrRed.Value.ToString();
            LblGreenAmount.Text = SldrGreen.Value.ToString();
            LblBlueAmount.Text = SldrBlue.Value.ToString();
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
            SetColourTemperature(new MonitorColour(SldrRed.Value, SldrGreen.Value, SldrBlue.Value));
        }

        private void BtnResetColourTemperature_Click(object sender, EventArgs e)
        {
            SetSliderValuesAndMonitorTemperature(MonitorColour.Default);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnResetColourTemperature_Click(this, null);
            Application.Exit();
        }

        private void SetSliderValues(MonitorColour colour)
        {
            SldrRed.Value = colour.RawRed;
            SldrGreen.Value = colour.RawGreen;
            SldrBlue.Value = colour.RawBlue;
        }

        private void SetSliderValuesAndMonitorTemperature(MonitorColour colour)
        {
            SetSliderValues(colour);
            SetColourTemperature(colour);
        }

        private void BtnClickLightBlue(object sender, MouseEventArgs e)
        {
            SetSliderValuesAndMonitorTemperature(MonitorColour.LightBlue);
        }

        private void BtnClickTurquoise(object sender, MouseEventArgs e)
        {
            SetSliderValuesAndMonitorTemperature(MonitorColour.Turquoise);
        }

        private void BtnClickGreen(object sender, MouseEventArgs e)
        {
            SetSliderValuesAndMonitorTemperature(MonitorColour.Green);
        }

        private void BtnClickLightYellow(object sender, MouseEventArgs e)
        {
            SetSliderValuesAndMonitorTemperature(MonitorColour.LightYellow);
        }

        private void BtnClickYellow(object sender, MouseEventArgs e)
        {
            SetSliderValuesAndMonitorTemperature(MonitorColour.Yellow);
        }

        private void BtnClickPurple(object sender, MouseEventArgs e)
        {
            SetSliderValuesAndMonitorTemperature(MonitorColour.Purple);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                tryIcon.Visible = true;
                Hide();
            
                if (showBalloon == true)
                {
                    tryIcon.ShowBalloonTip(1);
                    showBalloon = false;
                }
            }
        }

        private void tryIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            tryIcon.Visible = false;
        }

        private void MenuEnable_Click(object sender, EventArgs e)
        {
            SetColourTemperature(setColour);
        }

        private void MenuDisable_Click(object sender, EventArgs e)
        {
            SetColourTemperature(MonitorColour.Default);
        }
    }
}