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
            _settingsControls[CLOCK_SETTINGS_ID] = new ClockSettingsControl();
        }

        private void SetSelected(int settingId)
        {
            UnselectAllSettings();
            _settingSelected[settingId] = true;
            _labels[settingId].Image = Properties.Resources.btnSettingSelected;

            pnlSpecificSettings.Controls.Clear();
            pnlSpecificSettings.Controls.Add(_settingsControls[settingId]);
            pnlSpecificSettings.Refresh();
            Refresh();
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
    }
}
