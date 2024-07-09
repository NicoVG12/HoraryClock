using Clock;
using HoraryClock;
using HoraryEffects;
using Language;
using Settings;
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
    public partial class ClockControl : UserControl, ILanguageSetter, IResizable
    {
        private ClockManager _clockManager = ClockManager.Instance();
        private EffectManager _effectManager = EffectManager.Instance();

        private Image[] _icons = new Image[4];
        private MainForm _mainForm;
        private Config _config = Config.Instance();

        private int _displayedEffectID;
        private int _refreshDelay = 33;

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
                UpdateLabels(String.Format("{0:0.00}", ((double)_effectManager.CurrentEffect().Duration - elapsedTime / 1000)) + "s");
                await Task.Delay(_refreshDelay);
            }
        }

        public void UpdateLabels(string RemainingTimeMsg)
        {
            EffectType currentEffect = _effectManager.CurrentEffect();

            if (_displayedEffectID != currentEffect.Id)
            {
                lblCurrentEffect.Text = currentEffect.Name;
                lblCurrentEffectIcon.Image = _icons[_effectManager.CurrentEffectId];
                lblFirstDescription.Text = currentEffect.Description[0];
                lblSecondDescription.Text = currentEffect.Description[1];
                _displayedEffectID = currentEffect.Id;
            }

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
            else
            {
                Task.Run(async () => StartClock());
            }
        }

        public void SetInitialLabels()
        {
            LanguageData languageData = LanguageManager.Instance().GetLanguageData(Config.Instance().LanguageId);
            if (Config.Instance().PvPOffsett == Config.CHECKED)
            {
                UpdateLabels("17.00s");
            }
            else
            {
                UpdateLabels("20.00s");
            }

            lblCurrentEffect.Text = languageData.ClockWindow.NotStartedYet;
            lblFirstDescription.Text = languageData.ClockWindow.NoEffectsApplied;
            lblSecondDescription.Text = "";
            lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;
            _displayedEffectID = -1;

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

        private void AttachDelegates()
        {
            HoverUtils.SetHoverImages(lblStart, Properties.Resources.btnRectangle, Properties.Resources.btnRectangleHover);
            HoverUtils.SetHoverImages(lblPause, Properties.Resources.btnRectangle, Properties.Resources.btnRectangleHover);
            HoverUtils.SetHoverImages(lblReset, Properties.Resources.btnRectangle, Properties.Resources.btnRectangleHover);

            HoverUtils.SetHoverImages(lblSettings, Properties.Resources.btnConfig, Properties.Resources.btnConfigHover);
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

        public void SetResolution(Resolution resolution)
        {
            Size = new Size((int)(resolution.Scale * Width), (int)(resolution.Scale * Height));

            pnlMain.Size = new Size((int)(resolution.Scale * pnlMain.Width), (int)(resolution.Scale * pnlMain.Height));
            pnlMain.BackgroundImage = ImageUtils.ScaleImage(pnlMain.BackgroundImage, pnlMain.Width, pnlMain.Height);

            List<Label> labelsToScale = new List<Label>()
            {
                lblCurrentEffect,
                lblCurrentEffectIcon,
                lblFirstDescription,
                lblSecondDescription,

                lblRemainingTime,
                lblRemainingTimeValue,

                lblStart,
                lblPause,
                lblReset,

                lblSettings,
            };

            ImageUtils.ScaleLabels(labelsToScale, _config.Resolution.Scale);

            lblCurrentEffect.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Full, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstDescription.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Menu, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondDescription.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Menu, FontStyle.Bold, GraphicsUnit.Point);

            lblRemainingTime.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Full, FontStyle.Bold, GraphicsUnit.Point);
            lblRemainingTimeValue.Font = new Font("Consolas", (float)resolution.FontSize.Full, FontStyle.Bold, GraphicsUnit.Point);

            lblStart.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Full, FontStyle.Bold, GraphicsUnit.Point);
            lblPause.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Full, FontStyle.Bold, GraphicsUnit.Point);
            lblReset.Font = new Font("Segoe UI Semibold", (float)resolution.FontSize.Full, FontStyle.Bold, GraphicsUnit.Point);

            Refresh();
        }
    }
}
