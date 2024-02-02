using Clock;
using HoraryClock;
using HoraryEffects;
using Language;
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
    public partial class ClockControl : UserControl, ILanguageSetter
    {
        private ClockManager _clockManager = ClockManager.Instance();
        private EffectManager _effectManager = EffectManager.Instance();
        private Image[] _icons = new Image[4];

        private MainForm _mainForm;
        public ClockControl(MainForm mainForm)
        {
            InitializeComponent();
            AttachDelegates();
            InitializeImageArray();
            SetInitialLabels();
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

        public async Task StartClock()
        {
            Task.Run(() => _clockManager.StartAsync());
            await (Task.Delay(15));
            while (_clockManager.IsRunning)
            {
                double elapsedTime = _clockManager.ElapsedTime;
                UpdateLabels(String.Format("{0:0.0000}", ((double)_effectManager.CurrentEffect().Duration - elapsedTime / 1000)) + "s");
            }
        }

        public void UpdateLabels(string RemainingTimeMsg)
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

        public async void lblReset_Click(object sender, EventArgs e)
        {
            _clockManager.Reset();
            await Task.Delay(20);

            if (!_clockManager.IsRunning)
            {
                SetInitialLabels();
            }
        }

        public void SetInitialLabels()
        {
            LanguageData languageData = LanguageManager.Instance().GetLanguageData(Config.Instance().LanguageId);
            if (Config.Instance().PvPOffsett == Config.CHECKED)
            {
                UpdateLabels("17.0000s");
            }
            else
            {
                UpdateLabels("20.0000s");
            }

            lblCurrentEffect.Text = languageData.ClockWindow.NotStartedYet;
            lblFirstDescription.Text = languageData.ClockWindow.NoEffectsApplied;
            lblSecondDescription.Text = "";
            lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;

            if (!_clockManager.IsRunning)
            {
                lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;
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

            lblSettings.MouseEnter += OnMouseEnterSettings;
            lblSettings.MouseLeave += OnMouseLeaveSettings;
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
            _mainForm.Minimize(lblRemainingTimeValue.Text);

        }

        private void OnMouseEnterSettings(object sender, EventArgs e)
        {
            lblSettings.Image = Properties.Resources.btnSettingsDarkBackground;
        }

        private void OnMouseLeaveSettings(object sender, EventArgs e)
        {
            lblSettings.Image = Properties.Resources.btnSettingsDarkBackgroundNotHovered;
        }

        internal string GetRemainingTime()
        {
            return lblRemainingTimeValue.Text;
        }

        public void SetLanguage(LanguageData languageData)
        {
            lblCurrentEffect.Text = languageData.ClockWindow.NotStartedYet;
            lblFirstDescription.Text = languageData.ClockWindow.NoEffectsApplied;
            lblSecondDescription.Text = "";
            lblRemainingTime.Text = languageData.ClockWindow.RemainingTime;

            lblStart.Text = languageData.ClockWindow.Start;
            lblPause.Text = languageData.ClockWindow.Pause;
            lblReset.Text = languageData.ClockWindow.Reset;
        }
    }
}
