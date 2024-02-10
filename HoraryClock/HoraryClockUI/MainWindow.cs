using Clock;
using HoraryClock;
using HoraryClockUI.Controls;
using HoraryClockUI.Controls.MainWindow;
using HoraryClockUI.Controls.SettingsWindow;
using HoraryEffects;
using Language;
using System.Configuration;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HoraryClockUI
{
    public partial class MainForm : Form, ILanguageSetter
    {
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

        private List<Hotkey> _hotkeys = new List<Hotkey>();
        private Config _config = Config.Instance();
        private LanguageManager _languageManager = LanguageManager.Instance();
        private Control[] _controls = new Control[CONTROL_AMOUNT];
        private Control[] _controlsBeforeResize;
        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            InitializeTitle();
            AttachDelegates();
            LoadConfig();
            LoadKeyBindings();
            ShowTab(CLOCK_ID);
            SetLanguage(_languageManager.GetLanguageData(_config.LanguageId));
        }

        public void LoadConfig()
        {
            TopMost = _config.WindowAlwaysOnTop == Config.CHECKED;
            Opacity = 0.1 * (_config.WindowOpacity + 1);
        }

        private void LoadKeyBindings()
        {
            try
            {
                foreach (Hotkey hk in _hotkeys)
                {
                    hk.Unregister();
                    _hotkeys.Remove(hk);
                }
            }
            catch { }


            Hotkey startHK = new Hotkey();
            Hotkey pauseHK = new Hotkey();
            Hotkey resetHK = new Hotkey();

            startHK.KeyCode = StringToKeys(_config.KeyBindings.StartKey);
            startHK.Pressed += delegate { StartKeyDelegate(); };
            startHK.Register(this);

            pauseHK.KeyCode = StringToKeys(_config.KeyBindings.PauseKey);
            pauseHK.Pressed += delegate { PauseKeyDelegate(); };
            pauseHK.Register(this);

            resetHK.KeyCode = StringToKeys(_config.KeyBindings.ResetKey);
            resetHK.Pressed += delegate { ResetKeyDelegate(); };
            resetHK.Register(this);

            _hotkeys.Add(startHK);
            _hotkeys.Add(pauseHK);
            _hotkeys.Add(resetHK);
        }

        public void RefreshKeyBindings()
        {
            _hotkeys[0].KeyCode = StringToKeys(_config.KeyBindings.StartKey);
            _hotkeys[1].KeyCode = StringToKeys(_config.KeyBindings.PauseKey);
            _hotkeys[2].KeyCode = StringToKeys(_config.KeyBindings.ResetKey);
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
            lblCloseWindow.MouseEnter += OnMouseEnter;
            lblCloseWindow.MouseLeave += OnMouseLeave;

            lblMinimize.MouseEnter += OnMouseEnterMinimize;
            lblMinimize.MouseLeave += OnMouseLeaveMinimize;
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
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(_controls[tabId]);
            mainPanel.Refresh();
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

        private void OnMouseEnter(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnClose_hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            lblCloseWindow.Image = Properties.Resources.btnClose_normal;
        }

        private void OnMouseEnterMinimize(object sender, EventArgs e)
        {
            lblMinimize.Image = Properties.Resources.btnMinimizeHover;
        }

        private void OnMouseLeaveMinimize(object sender, EventArgs e)
        {
            lblMinimize.Image = Properties.Resources.btnMinimize;
        }

        public async void Minimize(string RemainingTimeMessage)
        {
            MiniClockControl MiniClockControl = _controls[MINI_CLOCK_ID] as MiniClockControl;
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
            Size = new Size(239, 104);
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
            Size = new Size(529, 332);
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
    }
}