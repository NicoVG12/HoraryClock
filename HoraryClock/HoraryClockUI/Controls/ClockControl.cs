using Clock;
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
        private ClockManager _clockManager;
        private EffectManager _effectManager;
        private Image[] _icons = new Image[4];

        private MainForm _mainForm;
        public ClockControl(MainForm mainForm)
        {
            InitializeComponent();
            AttachDelegates();
            InitializeImageArray();
            _mainForm = mainForm;
            _clockManager = ClockManager.Instance();
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
            Task.Run(() => _clockManager.StartAsync());
            await (Task.Delay(15));
            while (_clockManager.IsRunning)
            {
                double elapsedTime = _clockManager.ElapsedTime;
                UpdateLabels(String.Format("{0:0.0000}", ((double)_effectManager.CurrentEffect().Duration - elapsedTime / 1000)) + " s");
            }
        }

        private void UpdateLabels(string RemainingTimeMsg)
        {
            EffectType currentEffect = _effectManager.CurrentEffect();

            lblCurrentEffect.Text = currentEffect.Name;
            lblCurrentEffectIcon.Image = _icons[_effectManager.CurrentEffectId];
            lblFirstDescription.Text = currentEffect.Description[0];
            lblSecondDescription.Text = currentEffect.Description[1];
            if (!RemainingTimeMsg.StartsWith("-"))
            {
                lblRemainingTimeValue.Text = RemainingTimeMsg;
            }
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            _mainForm.ShowTab(MainForm.SETTINGS_ID);
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            _clockManager.Reset();
            if (Config.Instance().PvPOffsett == Config.CHECKED)
            {
                UpdateLabels("17.0000 s");
            } else
            {
                UpdateLabels("20.0000 s");
            }
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => StartClock());
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            _clockManager.Pause();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AttachDelegates()
        {
            lblStart.MouseEnter += OnMouseEnterStart;
            lblStart.MouseLeave += OnMouseLeaveStart;
            lblPause.MouseEnter += OnMouseEnterPause;
            lblPause.MouseLeave += OnMouseLeavePause;
            lblReset.MouseEnter += OnMouseEnterReset;
            lblReset.MouseLeave += OnMouseLeaveReset;
        }

        private void OnMouseEnterStart(object sender, EventArgs e)
        {
            lblStart.Image = Properties.Resources.btnRctg_1;
        }

        private void OnMouseLeaveStart(object sender, EventArgs e)
        {
            lblStart.Image = Properties.Resources.btnRctg_0;
        }

        private void OnMouseEnterPause(object sender, EventArgs e)
        {
            lblPause.Image = Properties.Resources.btnRctg_1;
        }

        private void OnMouseLeavePause(object sender, EventArgs e)
        {
            lblPause.Image = Properties.Resources.btnRctg_0;
        }

        private void OnMouseEnterReset(object sender, EventArgs e)
        {
            lblReset.Image = Properties.Resources.btnRctg_1;
        }

        private void OnMouseLeaveReset(object sender, EventArgs e)
        {
            lblReset.Image = Properties.Resources.btnRctg_0;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            _mainForm.Minimize();
            
        }
    }
}
