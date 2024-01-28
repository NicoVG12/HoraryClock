using Clock;
using HoraryClock;
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
            AttachDelegates();
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
            if (!_clockManager.IsRunning)
            {
                Task.Run(() => StartClock());
                lblPlay.Image = Properties.Resources.miniPauseHover;
            }
            else
            {
                _clockManager.Pause();
                lblPlay.Image = Properties.Resources.miniPlayHover;
            }

        }

        internal void UpdateLabels(string remainingTimeMessage)
        {
            EffectType currentEffect = _effectManager.CurrentEffect();

            lblCurrentEffectIcon.Image = _icons[_effectManager.CurrentEffectId];
            if (!remainingTimeMessage.StartsWith("-"))
            {
                string message = "";
                int length = 5;
                if (remainingTimeMessage.Length < 8)
                {
                    length = 4;
                    message = "0";
                }
                lblRemainingTimeValue.Text = message + remainingTimeMessage.Substring(0, length) + "s";
            }
        }

        internal async Task StartClock()
        {
            Task.Run(() => _clockManager.StartAsync());
            await (Task.Delay(15));
            while (_clockManager.IsRunning)
            {
                double elapsedTime = _clockManager.ElapsedTime;
                UpdateLabels(String.Format("{0:0.0000}", ((double)_effectManager.CurrentEffect().Duration - elapsedTime / 1000)) + "s");
            }
        }

        private void AttachDelegates()
        {
            lblPlay.MouseEnter += OnMouseEnterStart;
            lblPlay.MouseLeave += OnMouseLeaveStart;
            lblReset.MouseEnter += OnMouseEnterReset;
            lblReset.MouseLeave += OnMouseLeaveReset;

            lblCloseWindow.MouseEnter += OnMouseEnterClose;
            lblCloseWindow.MouseLeave += OnMouseLeaveClose;
            lblMaximize.MouseEnter += OnMouseEnterMaximize;
            lblMaximize.MouseLeave += OnMouseLeaveMaximize;

        }

        private void OnMouseEnterStart(object sender, EventArgs e)
        {
            if (_clockManager.IsRunning)
            {
                lblPlay.Image = Properties.Resources.miniPauseHover;
            }
            else
            {
                lblPlay.Image = Properties.Resources.miniPlayHover;
            }
        }

        private void OnMouseLeaveStart(object sender, EventArgs e)
        {
            if (_clockManager.IsRunning)
            {
                lblPlay.Image = Properties.Resources.miniPause;
            }
            else
            {
                lblPlay.Image = Properties.Resources.miniPlay;
            }
        }

        public void SetInitialPlayLabel()
        {
            if (_clockManager.IsRunning)
            {
                lblPlay.Image = Properties.Resources.miniPause;
            }
            else
            {
                lblPlay.Image = Properties.Resources.miniPlay;
                lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;
            }
            if (Config.Instance().PvPOffsett == Config.CHECKED)
            {
                lblRemainingTimeValue.Text = "17.00s";
            }
            else
            {
                lblRemainingTimeValue.Text = "20.00s";
            }
        }

        private void OnMouseEnterReset(object sender, EventArgs e)
        {
            lblReset.Image = Properties.Resources.miniResetHover;
        }

        private void OnMouseLeaveReset(object sender, EventArgs e)
        {
            lblReset.Image = Properties.Resources.miniReset;
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnMiniCloseHover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnMiniClose;
        }

        private void OnMouseEnterMaximize(object sender, EventArgs e)
        {
            lblMaximize.Image = Properties.Resources.btnMaximizeHover;
        }

        private void OnMouseLeaveMaximize(object sender, EventArgs e)
        {
            lblMaximize.Image = Properties.Resources.btnMaximize;
        }

        private async void lblReset_Click(object sender, EventArgs e)
        {
            _clockManager.Reset();
            await Task.Delay(20);
            SetInitialPlayLabel();
            if (!_clockManager.IsRunning)
            {
                lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
