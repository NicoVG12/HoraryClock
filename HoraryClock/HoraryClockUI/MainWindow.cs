using Clock;
using HoraryClock;
using HoraryClockUI.Controls;
using HoraryClockUI.Controls.MainWindow;
using HoraryClockUI.Controls.SettingsWindow;
using HoraryEffects;
using Language;
using Settings;
using System.Configuration;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HoraryClockUI
{

    public partial class MainForm : Form, ILanguageSetter
    {
        private Keys StartKey;
        private Keys PauseKey;
        private Keys ResetKey;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int CONTROL_AMOUNT = 3;

        public const int CLOCK_ID = 0;
        public const int SETTINGS_ID = 1;
        public const int MINI_CLOCK_ID = 2;

        private Config _config = Config.Instance();
        private LanguageManager _languageManager = LanguageManager.Instance();
        private Control[] _controls = new Control[CONTROL_AMOUNT];
        private Control[] _controlsBeforeResize;
        public MainForm()
        {
            Visible = false;

            InitializeComponent();
            InitializeControls();
            InitializeTitle();
            
            AttachDelegates();
            LoadConfig();
            Task.Run(() => SetUpKeyBindings());
            LoadKeyBindings();
            
            ShowTab(CLOCK_ID);
            
            SetLanguage(_languageManager.GetLanguageData(_config.LanguageId));
            SetResolution(_config.Resolution);
        }

        public async Task SetUpKeyBindings()
        {
            while (true)
            {
                if (GetAsyncKeyState((int)StartKey) < 0)
                {
                    StartKeyDelegate();
                }

                if (GetAsyncKeyState((int)PauseKey) < 0)
                {
                    PauseKeyDelegate();
                }

                if (GetAsyncKeyState((int)ResetKey) < 0)
                {
                    ResetKeyDelegate();
                }

                await Task.Delay(10);
            }
        }

        public void LoadConfig()
        {
            TopMost = _config.WindowAlwaysOnTop == Config.CHECKED;
            Opacity = 0.1 * (_config.WindowOpacity + 1);
        }

        public void LoadKeyBindings()
        {
            StartKey = StringToKeys(_config.KeyBindings.StartKey);
            PauseKey = StringToKeys(_config.KeyBindings.PauseKey);
            ResetKey = StringToKeys(_config.KeyBindings.ResetKey);
        }

        private void StartKeyDelegate()
        {
            if (!ClockManager.Instance().IsRunning)
            {
                if (!Minimized(Height))
                {
                    ClockControl clockControl = (ClockControl)_controls[CLOCK_ID];
                    Task.Run(() => clockControl.StartClock());
                }
                else
                {
                    MiniClockControl clockControl = (MiniClockControl)_controls[MINI_CLOCK_ID];
                    clockControl.label1_Click(null, null);
                }
            }
        }

        private void PauseKeyDelegate()
        {
            if (!Minimized(Height))
            {
                ClockManager.Instance().Pause();
            }
            else
            {
                MiniClockControl clockControl = (MiniClockControl)_controls[MINI_CLOCK_ID];
                clockControl.label1_Click(null, null);
            }
        }

        private void ResetKeyDelegate()
        {
            if (!Minimized(Height))
            {
                ClockControl clockControl = (ClockControl)_controls[CLOCK_ID];
                clockControl.lblReset_Click(null, null);
            }
            else
            {
                MiniClockControl clockControl = (MiniClockControl)_controls[MINI_CLOCK_ID];
                clockControl.lblReset_Click(null, null);
            }
        }

        private bool Minimized(int height)
        {
            return height == 104;
        }

        private void AttachDelegates()
        {
            HoverUtils.SetHoverImages(lblCloseWindow, Properties.Resources.btnClose, Properties.Resources.btnCloseHover);
            HoverUtils.SetHoverImages(lblMinimize, Properties.Resources.btnMinimize, Properties.Resources.btnMinimizeHover);
        }

        private void InitializeControls()
        {
            _controls[CLOCK_ID] = new ClockControl(this);
            _controls[SETTINGS_ID] = new SettingsControl(this);
            _controls[MINI_CLOCK_ID] = new MiniClockControl(this);
        }

        private void InitializeTitle()
        {
            Text = "Horary Clock Tool v2.0";
            lblBackground.Text = Text;
            Icon = Properties.Resources.Horary1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowTab(int tabId)
        {
            pnlFlow.Controls.Clear();
            pnlFlow.Controls.Add(_controls[tabId]);
            pnlFlow.Refresh();
            Refresh();
        }

        private void lblWindowHover_Click(object sender, EventArgs e)
        {

        }

        private void lblWindowHover_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private async void lblCloseWindow_Click(object sender, EventArgs e)
        {
            while (Opacity > 0)
            {
                Opacity -= .08;
                Refresh();
            }
            Close();
        }

        public async void Minimize(string RemainingTimeMessage)
        {
            MiniClockControl MiniClockControl = _controls[MINI_CLOCK_ID] as MiniClockControl;
            MiniClockControl.SetResolution(_config.Resolution);
            MiniClockControl.UpdateLabels(RemainingTimeMessage);
            MiniClockControl.RefreshPlayLabel();

            _controlsBeforeResize = new Control[Controls.Count];
            Controls.CopyTo(_controlsBeforeResize, 0);
            Controls.Clear();
            Controls.Add(_controls[MINI_CLOCK_ID]);
            if (ClockManager.Instance().IsRunning)
            {
                await Task.Delay(15);
                ClockManager.Instance().Pause();
                Task.Run(() => MiniClockControl.StartClock());
            }
            else if (ClockManager.Instance().ElapsedTime == 0 || ClockManager.Instance().ElapsedTime == 3000)
            {
                MiniClockControl.SetInitialLabel();
            }
            Size = new Size(_config.Resolution.MiniWindow.Width, _config.Resolution.MiniWindow.Height);
        }

        public async void Maximize(string RemainingTimeMessage)
        {
            ClockControl clockControl = _controls[CLOCK_ID] as ClockControl;
            clockControl.UpdateLabels(RemainingTimeMessage);
            Controls.Clear();
            foreach (Control c in _controlsBeforeResize)
            {
                Controls.Add(c);
            }

            if (ClockManager.Instance().IsRunning)
            {
                ClockManager.Instance().Pause();
                await Task.Delay(15);
                Task.Run(() => clockControl.StartClock());
            }
            else if (ClockManager.Instance().ElapsedTime == 0 || ClockManager.Instance().ElapsedTime == 3000)
            {
                clockControl.SetInitialLabels();
            }
            Size = new Size(_config.Resolution.FullWindow.Width, _config.Resolution.FullWindow.Height);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            ClockControl clockControl = _controls[CLOCK_ID] as ClockControl;
            Minimize(clockControl.GetRemainingTime());
        }

        public Keys StringToKeys(string key)
        {
            switch (key)
            {
                case "F1": return Keys.F1;
                case "F2": return Keys.F2;
                case "F3": return Keys.F3;
                case "F4": return Keys.F4;
                case "F5": return Keys.F5;
                case "F6": return Keys.F6;
                case "F7": return Keys.F7;
                case "F8": return Keys.F8;
                case "F9": return Keys.F9;
                case "F10": return Keys.F10;
                case "F11": return Keys.F11;
                case "F12": return Keys.F12;
                default: return Keys.F1;
            }
        }

        public void SetLanguage(LanguageData languageData)
        {
            foreach (Control control in _controls)
            {
                ILanguageSetter controlLanguageSetter = control as ILanguageSetter;
                controlLanguageSetter.SetLanguage(languageData);
            }
            EffectManager.Instance().SetLanguage(languageData);
        }

        internal void SetResolution(Resolution newResolution)
        {
            Size = new Size(newResolution.FullWindow.Width, newResolution.FullWindow.Height);

            pnlMain.Size = new Size(newResolution.FullWindow.Width, newResolution.FullWindow.Height);
            pnlMain.BackgroundImage = ImageUtils.ScaleImage(pnlMain.BackgroundImage, pnlMain.Width, pnlMain.Height);

            pnlFlow.Size = new Size((int)(newResolution.Scale* pnlFlow.Width), (int)(newResolution.Scale * pnlFlow.Height));
            pnlFlow.Location = new Point((int)(newResolution.Scale * pnlFlow.Location.X), (int)(newResolution.Scale * pnlFlow.Location.Y));

            lblBackground.Font = new Font("Segoe UI Semibold", (float)newResolution.FontSize.Title, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);

            foreach (Control control in _controls)
            {
                IResizable controlResizable = control as IResizable;
                controlResizable?.SetResolution(newResolution);
            }

            List<Label> labelsToScale = new List<Label>()
            {
                lblCloseWindow,
                lblMinimize,
                lblBackground,
            };

            ImageUtils.ScaleLabels(labelsToScale, newResolution.Scale);

            Refresh();

            Visible = true;
        }
    }
}