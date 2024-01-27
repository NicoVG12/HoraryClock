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

        private const int CONTROL_AMOUNT = 2;

        public const int CLOCK_ID = 0;
        public const int SETTINGS_ID = 1;

        private Config _config = Config.Instance();
        private Control[] _controls = new Control[CONTROL_AMOUNT];
        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            InitializeTitle();
            AttachDelegates();
            ShowTab(CLOCK_ID);
            SetAlwaysOnTop(true);
        }

        private void AttachDelegates()
        {
            lblCloseWindow.MouseEnter += OnMouseEnter;
            lblCloseWindow.MouseLeave += OnMouseLeave;
        }

        private void InitializeControls()
        {
            _controls[CLOCK_ID] = new ClockControl(this);
            _controls[SETTINGS_ID] = new SettingsControl(this);
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

        public void SetAlwaysOnTop(bool alwaysOnTop)
        {
            TopMost = alwaysOnTop;
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
    }
}