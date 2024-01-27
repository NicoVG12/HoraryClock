using HoraryClockUI.Controls;
using HoraryClockUI.Controls.MainWindow;
using HoraryClockUI.Controls.SettingsWindow;

namespace HoraryClockUI
{
    public partial class MainForm : Form
    {
        private const int CONTROL_AMOUNT = 2;

        public const int CLOCK_ID = 0;
        public const int SETTINGS_ID = 1;

        private Control[] _controls = new Control[CONTROL_AMOUNT];
        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
            InitializeTitle();
            ShowTab(CLOCK_ID);

            this.TopMost = true;
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
    }
}