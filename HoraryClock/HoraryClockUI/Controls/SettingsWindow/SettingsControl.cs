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
    public partial class SettingsControl : UserControl
    {
        private const int CONTROL_AMOUNT = 4;

        private const int LANGUAGE_SETTINGS_ID = 0;
        private const int CLOCK_SETTINGS_ID = 1;
        private const int KEY_SETTINGS_ID = 2;
        private const int OTHER_SETTINGS_ID = 3;

        private Label[] _labels = new Label[CONTROL_AMOUNT];
        private bool[] _settingSelected = new bool[CONTROL_AMOUNT];
        private Control[] _settingsControls = new Control[CONTROL_AMOUNT];
        private MainForm _mainForm;
        public SettingsControl(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
            InitializeLabelArray();
            InitializeControls();
            InitializeHoverIcons();
            SetSelected(LANGUAGE_SETTINGS_ID);
            Refresh();
        }

        private void InitializeLabelArray()
        {
            _labels[LANGUAGE_SETTINGS_ID] = lblLanguage;
            _labels[CLOCK_SETTINGS_ID] = lblPvPOffset;
            _labels[KEY_SETTINGS_ID] = lblKeyBindings;
            _labels[OTHER_SETTINGS_ID] = lblOther;
        }

        private void InitializeControls()
        {
            _settingsControls[LANGUAGE_SETTINGS_ID] = new LanguageControl();
            _settingsControls[CLOCK_SETTINGS_ID] = new ClockSettingsControl(_mainForm);
            _settingsControls[KEY_SETTINGS_ID] = new KeyBindingsControl(_mainForm);
        }

        private void SetSelected(int settingId)
        {
            if (!_settingSelected[settingId])
            {
                UnselectAllSettings();
                _settingSelected[settingId] = true;
                _labels[settingId].Image = Properties.Resources.btnSettingSelected;

                pnlSpecificSettings.Controls.Clear();
                pnlSpecificSettings.Controls.Add(_settingsControls[settingId]);
                pnlSpecificSettings.Refresh();
                Refresh();
            }
        }

        private void UnselectAllSettings()
        {
            for (int i = 0; i < _settingSelected.Length; i++)
            {
                _settingSelected[i] = false;
                _labels[i].Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void lblLanguage_Click(object sender, EventArgs e)
        {
            SetSelected(LANGUAGE_SETTINGS_ID);
        }

        private void lblPvPOffset_Click(object sender, EventArgs e)
        {
            SetSelected(CLOCK_SETTINGS_ID);
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            _mainForm.ShowTab(MainForm.CLOCK_ID);
        }

        private void InitializeHoverIcons()
        {
            lblLanguage.MouseEnter += OnMouseEnterLanguage;
            lblLanguage.MouseLeave += OnMouseLeaveLanguage;
            lblPvPOffset.MouseEnter += OnMouseEnterClock;
            lblPvPOffset.MouseLeave += OnMouseLeaveClock;
            lblKeyBindings.MouseEnter += OnMouseEnterKeys;
            lblKeyBindings.MouseLeave += OnMouseLeaveKeys;
            lblOther.MouseEnter += OnMouseEnterOther;
            lblOther.MouseLeave += OnMouseLeaveOther;

            lblGoBack.MouseEnter += OnMouseEnterReturn;
            lblGoBack.MouseLeave += OnMouseLeaveReturn;

        }

        private void Other_MouseEnter(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnMouseEnterLanguage(object sender, EventArgs e)
        {
            if (!_settingSelected[LANGUAGE_SETTINGS_ID])
            {
                lblLanguage.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveLanguage(object sender, EventArgs e)
        {
            if (!_settingSelected[LANGUAGE_SETTINGS_ID])
            {
                lblLanguage.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterClock(object sender, EventArgs e)
        {
            if (!_settingSelected[CLOCK_SETTINGS_ID])
            {
                lblPvPOffset.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveClock(object sender, EventArgs e)
        {
            if (!_settingSelected[CLOCK_SETTINGS_ID])
            {
                lblPvPOffset.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterKeys(object sender, EventArgs e)
        {
            if (!_settingSelected[KEY_SETTINGS_ID])
            {
                lblKeyBindings.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveKeys(object sender, EventArgs e)
        {
            if (!_settingSelected[KEY_SETTINGS_ID])
            {
                lblKeyBindings.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterOther(object sender, EventArgs e)
        {
            if (!_settingSelected[OTHER_SETTINGS_ID])
            {
                lblOther.Image = Properties.Resources.btnSettingHovered;
            }
        }

        private void OnMouseLeaveOther(object sender, EventArgs e)
        {
            if (!_settingSelected[OTHER_SETTINGS_ID])
            {
                lblOther.Image = Properties.Resources.btnSettingNotSelected;
            }
        }

        private void OnMouseEnterReturn(object sender, EventArgs e)
        {
            lblGoBack.Image = Properties.Resources.btnReturnToClockHover;
        }

        private void OnMouseLeaveReturn(object sender, EventArgs e)
        {
            lblGoBack.Image = Properties.Resources.btnReturnToClock;
        }

        private void lblKeyBindings_Click(object sender, EventArgs e)
        {
            SetSelected(KEY_SETTINGS_ID);
        }
    }
}
