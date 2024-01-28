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
            if (KeysRepeated())
            {
                lblMessage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
                lblMessage.Text = "The same key cannot be bound to multiple actions.";
               
            } else
            {
                _config.KeyBindings.StartKey = txtStartKey.Text;
                _config.KeyBindings.PauseKey = txtPauseKey.Text;
                _config.KeyBindings.ResetKey = txtResetKey.Text;

                _mainForm.LoadConfig();
                _mainForm.RefreshKeyBindings();
                _config.Save();
            }

        }

        private bool KeysRepeated()
        {
            bool repeated = false;

            repeated |= txtStartKey.Text == txtPauseKey.Text;
            repeated |= txtStartKey.Text == txtResetKey.Text;
            repeated |= txtPauseKey.Text == txtResetKey.Text;

            return repeated;
        }

        private void SetText(TextBox textBox, KeyEventArgs e)
        {
            string newKey = e.KeyCode.ToString();
            newKey = _mainForm.StringToKeys(newKey).ToString();
            textBox.Text = newKey;
        }

        private void txtStartKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtStartKey.Text = "";
        }

        private void txtStartKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtStartKey, e);
        }

        private void txtPauseKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtPauseKey.Text = "";
        }

        private void txtPauseKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPauseKey.Text = "";
        }

        private void txtPauseKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtPauseKey, e);
        }

        private void txtResetKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtResetKey.Text = "";
        }

        private void txtResetKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtResetKey.Text = "";
        }

        private void txtResetKey_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(txtResetKey, e);
        }

        private void txtStartKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtStartKey.Text = "";
        }
    }
}
