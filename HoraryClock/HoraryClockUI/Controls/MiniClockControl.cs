using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraryClockUI.Controls
{
    public partial class MiniClockControl : UserControl
    {
        private MainForm _mainForm;
        private bool _isRunning;
        private double _elapsedTime;
        public MiniClockControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void lblMaximize_Click(object sender, EventArgs e)
        {
            bool isRunning = _isRunning;
            _isRunning = false;
            _mainForm.Maximize(0, false);
        }
    }
}
