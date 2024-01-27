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
        private const int LANGUAGE_SETTINGS_ID = 0;
        private const int CLOCK_SETTINGS_ID = 1;
        private const int KEY_SETTINGS_ID = 2;
        private const int OTHER_SETTINGS_ID = 3;

        private Label[] _labels;
        private bool[] settingSelected = new bool[4];
        private Control[] settingsControls = new Control[4];
        public SettingsControl()
        {
            InitializeComponent();
            InitializeLabelArray();
            InitializeControls();
            SetSelected(LANGUAGE_SETTINGS_ID);
        }

        private void InitializeLabelArray()
        {
            _labels = new Label[4];
            _labels[LANGUAGE_SETTINGS_ID] = lblLanguage;
            _labels[CLOCK_SETTINGS_ID] = lblPvPOffset;
            _labels[KEY_SETTINGS_ID] = lblKeyBindings;
            _labels[OTHER_SETTINGS_ID] = lblOther;
        }

        private void InitializeControls()
        {
            settingsControls[0] = new LanguageControl();

            flowLayoutPanel1.Controls.Add(settingsControls[0]);
        }

        private void SetSelected(int settingId)
        {
            UnselectAllSettings();
            settingSelected[settingId] = true;
            _labels[settingId].Image = Properties.Resources.btnSettingSelected;

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(settingsControls[settingId]);
        }

        private void UnselectAllSettings()
        {
            for (int i = 0; i < settingSelected.Length; i++)
            {
                settingSelected[i] = false;
                _labels[i].Image = Properties.Resources.btnSettingNotSelected;
            }
        }
    }
}
