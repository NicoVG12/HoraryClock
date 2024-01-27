using HoraryClock;
using HoraryEffects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraryClockUI.Controls
{
    public partial class ClockControl : UserControl
    {
        private bool _isRunning = false;
        private bool _wasReset = true;
        private double _elapsedTime = 0;
        private DateTime _lastCheck;
        private EffectManager _effectManager;
        private Image[] _icons = new Image[4];

        private MainForm _mainForm;
        public ClockControl(MainForm mainForm)
        {
            InitializeComponent();
            InitializeImageArray();
            _mainForm = mainForm;
            _effectManager = EffectManager.Instance();
        }

        private void InitializeImageArray()
        {
            _icons[0] = Properties.Resources._00blueicon;
            _icons[1] = Properties.Resources._01purpleicon;
            _icons[2] = Properties.Resources._02orangeicon;
            _icons[3] = Properties.Resources._03culminationicon;
        }

        private async Task StartClock()
        {
            UpdateLabels();
            if (!_isRunning)
            {
                if (_wasReset)
                {
                    _wasReset = false;
                    _elapsedTime = 0;
                }
                _lastCheck = DateTime.Now;
                _isRunning = true;
                while (_isRunning)
                {
                    DateTime newCheck = DateTime.Now;

                    _elapsedTime += ((newCheck - _lastCheck).TotalMilliseconds);
                    if (_elapsedTime <= _effectManager.CurrentEffect().Duration * 1000)
                    {
                        lblRemainingTimeValue.Text = String.Format("{0:0.0000}", ((double)_effectManager.CurrentEffect().Duration - _elapsedTime / 1000)) + " s";
                    }
                    await Task.Delay(10);

                    if (_elapsedTime > _effectManager.CurrentEffect().Duration * 1000)
                    {
                        _elapsedTime -= _effectManager.CurrentEffect().Duration * 1000;
                        _effectManager.AdvanceEffect();
                        UpdateLabels();
                    }

                    _lastCheck = newCheck;
                }
            }
        }

        private void UpdateLabels()
        {
            EffectType currentEffect = _effectManager.CurrentEffect();

            lblCurrentEffect.Text = currentEffect.Name;
            lblCurrentEffectIcon.Image = _icons[_effectManager.CurrentEffectId];
            lblFirstDescription.Text = currentEffect.Description[0];
            lblSecondDescription.Text = currentEffect.Description[1];
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            _mainForm.ShowTab(MainForm.SETTINGS_ID);
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            if (Config.Instance().StopClockOnReset)
            {
                _isRunning = false;
            }
            if (Config.Instance().PvPOffsett)
            {
                _elapsedTime = 3;
                lblRemainingTimeValue.Text = "17.0000 s";
            }
            else
            {
                _elapsedTime = 0;
                lblRemainingTimeValue.Text = "20.0000 s";
            }
            _effectManager.Reset();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => StartClock());
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            _isRunning = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
