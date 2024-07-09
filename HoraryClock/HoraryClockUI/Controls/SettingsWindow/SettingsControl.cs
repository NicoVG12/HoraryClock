using Language;
using Settings;
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
    public partial class SettingsControl : UserControl, ILanguageSetter, IResizable
    {
        private const int CONTROL_AMOUNT = 5;

        private const int LANGUAGE_SETTINGS_ID = 0;
        private const int CLOCK_SETTINGS_ID = 1;
        private const int KEY_SETTINGS_ID = 2;
        private const int RESOLUTION_SETTINGS_ID = 3;
        private const int OTHER_SETTINGS_ID = 4;

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

            //No "Other" Options so far
            lblOther.Visible = false;
        }

        private void InitializeLabelArray()
        {
            _labels[LANGUAGE_SETTINGS_ID] = lblLanguage;
            _labels[CLOCK_SETTINGS_ID] = lblPvPOffset;
            _labels[KEY_SETTINGS_ID] = lblKeyBindings;
            _labels[RESOLUTION_SETTINGS_ID] = lblResolution;
            _labels[OTHER_SETTINGS_ID] = lblOther;
        }

        private void InitializeControls()
        {
            _settingsControls[LANGUAGE_SETTINGS_ID] = new LanguageControl(_mainForm);
            _settingsControls[CLOCK_SETTINGS_ID] = new ClockSettingsControl(_mainForm);
            _settingsControls[KEY_SETTINGS_ID] = new KeyBindingsControl(_mainForm);
            _settingsControls[RESOLUTION_SETTINGS_ID] = new ResolutionControl(_mainForm);
        }

        private void SetSelected(int settingId)
        {
            if (!_settingSelected[settingId])
            {
                UnselectAllSettings();
                _settingSelected[settingId] = true;
                _labels[settingId].Image = ImageUtils.ScaleImage(Properties.Resources.btnSettingSelected, _labels[settingId].Width, _labels[settingId].Height);

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
                _labels[i].Image = ImageUtils.ScaleImage(Properties.Resources.btnSettingNotSelected, _labels[i].Width, _labels[i].Height);
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
            for(int i = 0; i < CONTROL_AMOUNT; i++)
            {
                int settingId = i;
                _labels[settingId].MouseEnter += delegate { UpdateImageEnter(settingId); };
                _labels[settingId].MouseLeave += delegate { UpdateImageLeave(settingId); };
            }

            HoverUtils.SetHoverImages(lblGoBack, Properties.Resources.btnRectangle, Properties.Resources.btnRectangleHover);
        }


        private void UpdateImageEnter(int settingId)
        {
            if (!_settingSelected[settingId])
            {
                _labels[settingId].Image = ImageUtils.ScaleImage(Properties.Resources.btnSettingHovered, _labels[settingId].Width, _labels[settingId].Height);
            }
        }

        private void UpdateImageLeave(int settingId)
        {
            if (!_settingSelected[settingId])
            {
                _labels[settingId].Image = ImageUtils.ScaleImage(Properties.Resources.btnSettingNotSelected, _labels[settingId].Width, _labels[settingId].Height);
            }
        }

        private void lblKeyBindings_Click(object sender, EventArgs e)
        {
            SetSelected(KEY_SETTINGS_ID);
        }

        public void SetLanguage(LanguageData languageData)
        {
            lblLanguage.Text = languageData.Settings.Language;
            lblPvPOffset.Text = languageData.Settings.Clock;
            lblKeyBindings.Text = languageData.Settings.KeyBindings;
            lblOther.Text = languageData.Settings.Other;
            lblGoBack.Text = languageData.Settings.Return;

            foreach (Control c in _settingsControls)
            {
                ILanguageSetter languageSetter = c as ILanguageSetter;
                if (languageSetter != null)
                {
                    languageSetter.SetLanguage(languageData);
                }
            }
        }

        private void lblResolution_Click(object sender, EventArgs e)
        {
            SetSelected(RESOLUTION_SETTINGS_ID);
        }

        public void SetResolution(Resolution resolution)
        {
            Size = new Size((int)(resolution.Scale * Width), (int)(resolution.Scale * Height));

            pnlMain.Size = new Size((int)(resolution.Scale * pnlMain.Width), (int)(resolution.Scale * pnlMain.Height));
            pnlMain.BackgroundImage = ImageUtils.ScaleImage(pnlMain.BackgroundImage, pnlMain.Width, pnlMain.Height);

            pnlSpecificSettings.Size = new Size((int)(resolution.Scale * pnlSpecificSettings.Width), (int)(resolution.Scale * pnlSpecificSettings.Height));
            pnlSpecificSettings.Location = new Point((int)(resolution.Scale * pnlSpecificSettings.Location.X), (int)(resolution.Scale * pnlSpecificSettings.Location.Y));

            List<Label> labelsToScale = new List<Label>()
            {
                lblLanguage,
                lblKeyBindings,
                lblPvPOffset,
                lblResolution,
                lblOther,
                lblGoBack
            };

            foreach (Label label in labelsToScale)
            {
                label.Font = new Font("Segoe UI", (float)resolution.FontSize.Menu * 0.9375f, FontStyle.Bold, GraphicsUnit.Point);
            }

            lblGoBack.Font = new Font("Segoe UI", (float)resolution.FontSize.Menu, FontStyle.Bold, GraphicsUnit.Point);

            ImageUtils.ScaleLabels(labelsToScale, resolution.Scale);

            Refresh();
        }
    }
}
