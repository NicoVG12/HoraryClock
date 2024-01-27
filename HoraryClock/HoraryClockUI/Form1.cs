using HoraryClockUI.Controls.MainWindow;

namespace HoraryClockUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeTitle();
        }

        private void InitializeTitle()
        {
            Text = "Horary Clock Tool v2.0";
            lblBackground.Text = Text;

            //Icon
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}