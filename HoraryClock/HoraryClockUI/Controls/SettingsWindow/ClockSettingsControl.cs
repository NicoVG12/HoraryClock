using HoraryClock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraryClockUI.Controls.SettingsWindow
{
    public partial class ClockSettingsControl : UserControl
    {
        Config _config = Config.Instance();
        public ClockSettingsControl()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            chkOffset.CheckState = (CheckState)_config.PvPOffsett;
            chkStartClockOnReset.CheckState = (CheckState)_config.StartClockOnReset;
            chkAlwaysOnTop.CheckState = (CheckState)_config.WindowAlwaysOnTop;
            trkOpacity.Value = _config.WindowOpacity;
        }

        private void trkOpacity_Scroll(object sender, EventArgs e)
        {
            int currentValue = trkOpacity.Value;
            lblOpacityProgress.Text = ((1 + currentValue) * 10) + "%";
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            _config.Save();
        }
    }
}
