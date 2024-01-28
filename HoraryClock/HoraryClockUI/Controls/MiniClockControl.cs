using Clock;
using HoraryEffects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraryClockUI.Controls
{
    public partial class MiniClockControl : UserControl
    {
        private MainForm _mainForm;
        private bool _isRunning;
        private Image[] _icons = new Image[4];

        private EffectManager _effectManager = EffectManager.Instance();
        private ClockManager _clockManager = ClockManager.Instance();
        public MiniClockControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            InitializeImageArray();
        }

        private void InitializeImageArray()
        {
            _icons[0] = Properties.Resources._00blueicon;
            _icons[1] = Properties.Resources._01purpleicon;
            _icons[2] = Properties.Resources._02orangeicon;
            _icons[3] = Properties.Resources._03culminationicon;
        }

        private void lblMaximize_Click(object sender, EventArgs e)
        {
            bool isRunning = _isRunning;
            _isRunning = false;
            _mainForm.Maximize(lblRemainingTimeValue.Text);
        }

        private void lblCloseWindow_Click(object sender, EventArgs e)
        {
            while (_mainForm.Opacity > 0)
            {
                _mainForm.Opacity -= .08;
                Refresh();
            }
            _mainForm.Close();
        }

        private void lblBackground_Click(object sender, EventArgs e)
        {

        }

        private void lblBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainForm.ReleaseCapture();
                MainForm.SendMessage(_mainForm.Handle, MainForm.WM_NCLBUTTONDOWN, MainForm.HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Task.Run(() => StartClock());
        }

        internal void UpdateLabels(string remainingTimeMessage)
        {
            EffectType currentEffect = _effectManager.CurrentEffect();

            lblCurrentEffectIcon.Image = _icons[_effectManager.CurrentEffectId];
            if (!remainingTimeMessage.StartsWith("-"))
            {
                int length = 5;
                if (remainingTimeMessage.Length < 9)
                {
                    length = 4;
                }
                lblRemainingTimeValue.Text = remainingTimeMessage.Substring(0, length) + " s";
            }
        }

        internal async Task StartClock()
        {
            Task.Run(() => _clockManager.StartAsync());
            await (Task.Delay(15));
            while (_clockManager.IsRunning)
            {
                double elapsedTime = _clockManager.ElapsedTime;
                UpdateLabels(String.Format("{0:0.0000}", ((double)_effectManager.CurrentEffect().Duration - elapsedTime / 1000)) + " s");
            }
        }
    }
}
