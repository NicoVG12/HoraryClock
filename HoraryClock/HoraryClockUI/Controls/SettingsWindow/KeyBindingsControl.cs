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
    public partial class KeyBindingsControl : UserControl
    {
        private MainForm _mainForm;
        private Config _config = Config.Instance();
        public KeyBindingsControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            InitializeHoveringIcons();
            LoadConfig();
        }

        private void InitializeHoveringIcons()
        {
            lblSave.MouseEnter += OnMouseEnter;
            lblSave.MouseLeave += OnMouseLeave;
        }

        private void LoadConfig()
        {
            txtStartKey.Text = _config.KeyBindings.StartKey;
            txtPauseKey.Text = _config.KeyBindings.PauseKey;
            txtResetKey.Text = _config.KeyBindings.ResetKey;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            lblSave.Image = Properties.Resources.btnSaveHover1;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            lblSave.Image = Properties.Resources.btnSave;
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            _config.KeyBindings.StartKey = txtStartKey.Text;
            _config.KeyBindings.PauseKey = txtPauseKey.Text;
            _config.KeyBindings.ResetKey = txtPauseKey.Text;

            _mainForm.LoadConfig();
            _config.Save();
        }

        private void txtStartKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtStartKey.Text = "";
        }

        private void txtStartKey_KeyUp(object sender, KeyEventArgs e)
        {
            string newKey = e.KeyCode.ToString();
            newKey = _mainForm.StringToKeys(newKey).ToString();
            txtStartKey.Text = newKey;
        }
    }
}
