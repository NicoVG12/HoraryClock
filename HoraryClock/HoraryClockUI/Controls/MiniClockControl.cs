using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void lblCloseWindow_Click(object sender, EventArgs e)
        {
            while (_mainForm.Opacity > 0)
            {
                _mainForm.Opacity -= .08;
                Refresh();
            }
            _mainForm.Close();
        }

        private void lblBackground_Click(object sender, EventArgs e)
        {

        }

        private void lblBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainForm.ReleaseCapture();
                MainForm.SendMessage(_mainForm.Handle, MainForm.WM_NCLBUTTONDOWN, MainForm.HT_CAPTION, 0);
            }
        }


    }
}
