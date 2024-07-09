using Clock;
using HoraryClock;
using HoraryEffects;
using Language;
using Settings;
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
    public partial class MiniClockControl : UserControl, ILanguageSetter, IResizable
    {
        private MainForm _mainForm;
        private bool _isRunning;
        private Image[] _icons = new Image[4];

        private EffectManager _effectManager = EffectManager.Instance();
        private ClockManager _clockManager = ClockManager.Instance();

        private int _refreshDelay = 33;

        private int _effectIconSideLength = 0;
        private double _currentScale = 1;
        public MiniClockControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            AttachDelegates();
            InitializeImageArray();
            _effectIconSideLength = _icons[0].Width;
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

        private async void lblCloseWindow_Click(object sender, EventArgs e)
        {
            while (_mainForm.Opacity > 0)
            {
                _mainForm.Opacity -= .08;
                _mainForm.Refresh();
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

        public void label1_Click(object sender, EventArgs e)
        {
            if (!_clockManager.IsRunning)
            {
                Task.Run(() => StartClock());
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPauseHover, lblPlay.Width, lblPlay.Height);
            }
            else
            {
                _clockManager.Pause();
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPlayHover, lblPlay.Width, lblPlay.Height);
            }

        }

        internal void UpdateLabels(string remainingTimeMessage)
        {
            lblCurrentEffectIcon.Image = ImageUtils.ScaleImage(_icons[_effectManager.CurrentEffectId], _effectIconSideLength, _effectIconSideLength);
            try
            {
                if (!remainingTimeMessage.StartsWith("-"))
                {
                    lblRemainingTimeValue.Text = remainingTimeMessage;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal void SetInitialLabel()
        {
            lblCurrentEffectIcon.Image = ImageUtils.ScaleImage(Properties.Resources._04noeffect, lblCurrentEffectIcon.Width, lblCurrentEffectIcon.Height);
        }

        internal async Task StartClock()
        {
            Task.Run(() => _clockManager.StartAsync());
            await (Task.Delay(15));
            while (_clockManager.IsRunning)
            {
                double elapsedTime = _clockManager.ElapsedTime;
                UpdateLabels(String.Format("{0:0.00}", ((double)_effectManager.CurrentEffect().Duration - elapsedTime / 1000)) + "s");
                await (Task.Delay(_refreshDelay));
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
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPauseHover, lblPlay.Width, lblPlay.Height);
            }
            else
            {
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPlayHover, lblPlay.Width, lblPlay.Height);
            }
        }

        private void OnMouseLeaveStart(object sender, EventArgs e)
        {
            if (_clockManager.IsRunning)
            {
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPause, lblPlay.Width, lblPlay.Height);
            }
            else
            {
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPlay, lblPlay.Width, lblPlay.Height);
            }
        }

        public void SetInitialPlayLabel()
        {
            if (_clockManager.IsRunning)
            {
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPause, lblPlay.Width, lblPlay.Height);
            }
            else
            {
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPlay, lblPlay.Width, lblPlay.Height);
                lblCurrentEffectIcon.Image = ImageUtils.ScaleImage(Properties.Resources._04noeffect, lblCurrentEffectIcon.Width, lblCurrentEffectIcon.Height);
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

        public void RefreshPlayLabel()
        {
            if (_clockManager.IsRunning)
            {
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPause, lblPlay.Width, lblPlay.Height);
            }
            else
            {
                lblPlay.Image = ImageUtils.ScaleImage(Properties.Resources.miniPlay, lblPlay.Width, lblPlay.Height);
            }
        }

        private void OnMouseEnterReset(object sender, EventArgs e)
        {
            lblReset.Image = ImageUtils.ScaleImage(Properties.Resources.miniResetHover, lblPlay.Width, lblPlay.Height);
        }

        private void OnMouseLeaveReset(object sender, EventArgs e)
        {
            lblReset.Image = ImageUtils.ScaleImage(Properties.Resources.miniReset, lblPlay.Width, lblPlay.Height);
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            lblCloseWindow.Image = ImageUtils.ScaleImage(Properties.Resources.btnMiniCloseHover, lblCloseWindow.Width, lblCloseWindow.Height);
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            lblCloseWindow.Image = ImageUtils.ScaleImage(Properties.Resources.btnMiniClose, lblCloseWindow.Width, lblCloseWindow.Height);
        }

        private void OnMouseEnterMaximize(object sender, EventArgs e)
        {
            lblMaximize.Image = ImageUtils.ScaleImage(Properties.Resources.btnMaximizeHover, lblMaximize.Width, lblMaximize.Height);
        }

        private void OnMouseLeaveMaximize(object sender, EventArgs e)
        {
            lblMaximize.Image = ImageUtils.ScaleImage(Properties.Resources.btnMaximize, lblMaximize.Width, lblMaximize.Height);
        }

        public async void lblReset_Click(object sender, EventArgs e)
        {
            _clockManager.Reset();
            await Task.Delay(20);
            SetInitialPlayLabel();
            if (!_clockManager.IsRunning)
            {
                lblCurrentEffectIcon.Image = ImageUtils.ScaleImage(Properties.Resources._04noeffect, lblCurrentEffectIcon.Width, lblCurrentEffectIcon.Height);
            }
            else
            {
                Task.Run(async () => StartClock());

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void SetLanguage(LanguageData languageData)
        {

        }

        public void SetResolution(Resolution resolution)
        {
            double ScaleRatio = resolution.Scale / _currentScale;
            _effectIconSideLength = (int)(resolution.Scale * _icons[_effectManager.CurrentEffectId].Width);

            Size = new Size((int)(Size.Width * ScaleRatio), (int)(Size.Height * ScaleRatio));

            lblBackground.Size = new Size((int)(lblBackground.Width * ScaleRatio), (int)(lblBackground.Height * ScaleRatio));
            lblBackground.Image = ImageUtils.ScaleImage(lblBackground.Image, lblBackground.Width, lblBackground.Height);

            lblNonHoverArea.Size = new Size((int)(lblNonHoverArea.Width * ScaleRatio), (int)(lblNonHoverArea.Height * ScaleRatio));
            lblNonHoverArea.Image = ImageUtils.ScaleImage(lblNonHoverArea.Image, lblNonHoverArea.Width, lblNonHoverArea.Height);
            lblNonHoverArea.Location = new Point((int)(ScaleRatio * lblNonHoverArea.Location.X), (int)(ScaleRatio * lblNonHoverArea.Location.Y));

            lblCurrentEffectIcon.Size = new Size((int)(lblCurrentEffectIcon.Width * ScaleRatio), (int)(lblCurrentEffectIcon.Height * ScaleRatio));
            lblCurrentEffectIcon.Image = ImageUtils.ScaleImage(lblCurrentEffectIcon.Image, lblCurrentEffectIcon.Width, lblCurrentEffectIcon.Height);
            lblCurrentEffectIcon.Location = new Point((int)(ScaleRatio * lblCurrentEffectIcon.Location.X), (int)(ScaleRatio * lblCurrentEffectIcon.Location.Y));

            lblPlay.Size = new Size((int)(lblPlay.Width * ScaleRatio), (int)(lblPlay.Height * ScaleRatio));
            lblPlay.Image = ImageUtils.ScaleImage(lblPlay.Image, lblPlay.Width, lblPlay.Height);
            lblPlay.Location = new Point((int)(ScaleRatio * lblPlay.Location.X), (int)(ScaleRatio * lblPlay.Location.Y));

            lblReset.Size = new Size((int)(lblReset.Width * ScaleRatio), (int)(lblReset.Height * ScaleRatio));
            lblReset.Image = ImageUtils.ScaleImage(lblReset.Image, lblReset.Width, lblReset.Height);
            lblReset.Location = new Point((int)(ScaleRatio * lblReset.Location.X), (int)(ScaleRatio * lblReset.Location.Y));

            lblCloseWindow.Size = new Size((int)(lblCloseWindow.Width * ScaleRatio), (int)(lblCloseWindow.Height * ScaleRatio));
            lblCloseWindow.Image = ImageUtils.ScaleImage(lblCloseWindow.Image, lblCloseWindow.Width, lblCloseWindow.Height);
            lblCloseWindow.Location = new Point((int)(ScaleRatio * lblCloseWindow.Location.X), (int)(ScaleRatio * lblCloseWindow.Location.Y));

            lblMaximize.Size = new Size((int)(lblMaximize.Width * ScaleRatio), (int)(lblMaximize.Height * ScaleRatio));
            lblMaximize.Image = ImageUtils.ScaleImage(lblMaximize.Image, lblMaximize.Width, lblMaximize.Height);
            lblMaximize.Location = new Point((int)(ScaleRatio * lblMaximize.Location.X), (int)(ScaleRatio * lblMaximize.Location.Y));

            lblRemainingTimeValue.Size = new Size((int)(lblRemainingTimeValue.Width * ScaleRatio), (int)(lblRemainingTimeValue.Height * ScaleRatio));
            lblRemainingTimeValue.Location = new Point((int)(ScaleRatio * lblRemainingTimeValue.Location.X), (int)(ScaleRatio * lblRemainingTimeValue.Location.Y));

            lblBackground.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Title, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRemainingTimeValue.Font = new Font("Consolas", (float)resolution.FontSize.Full, FontStyle.Bold, GraphicsUnit.Point);

            _currentScale = resolution.Scale;
        }
    }
}
