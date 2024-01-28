using Clock;
using HoraryClock;
using HoraryClockUI.Controls;
using HoraryClockUI.Controls.MainWindow;
using HoraryClockUI.Controls.SettingsWindow;
using System.Configuration;
using System.Runtime.InteropServices;

namespace HoraryClockUI
{
    public partial class MainForm : Form
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

        private Config _config = Config.Instance();
        private Control[] _controls = new Control[CONTROL_AMOUNT];
        private Control[] _controlsBeforeResize;
        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            InitializeTitle();
            AttachDelegates();
            LoadConfig();
            ShowTab(CLOCK_ID);
        }

        public void LoadConfig()
        {
            TopMost = _config.WindowAlwaysOnTop == Config.CHECKED;
            Opacity = 0.1 * (_config.WindowOpacity + 1);
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

        private void lblCloseWindow_Click(object sender, EventArgs e)
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
            MiniClockControl.SetInitialPlayLabel();

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
    }
}