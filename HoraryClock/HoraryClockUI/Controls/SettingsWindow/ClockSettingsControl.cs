﻿using HoraryClock;
using Language;
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
    public partial class ClockSettingsControl : UserControl, ILanguageSetter
    {
        private MainForm _mainForm;

        Config _config = Config.Instance();
        public ClockSettingsControl(MainForm mainForm)
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
            chkOffset.CheckState = (CheckState)_config.PvPOffsett;
            chkStartClockOnReset.CheckState = (CheckState)_config.StartClockOnReset;
            chkAlwaysOnTop.CheckState = (CheckState)_config.WindowAlwaysOnTop;
            trkOpacity.Value = _config.WindowOpacity;
            lblOpacityProgress.Text = ((1 + trkOpacity.Value) * 10) + "%";
        }

        private void trkOpacity_Scroll(object sender, EventArgs e)
        {
            int currentValue = trkOpacity.Value;
            lblOpacityProgress.Text = ((1 + currentValue) * 10) + "%";
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            _config.PvPOffsett = (int)chkOffset.CheckState;
            _config.StartClockOnReset = (int)chkStartClockOnReset.CheckState;
            _config.WindowOpacity = trkOpacity.Value;
            _config.WindowAlwaysOnTop = (int)chkAlwaysOnTop.CheckState;
            _mainForm.LoadConfig();

            _config.Save();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            lblSave.Image = Properties.Resources.btnSaveHover1;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            lblSave.Image = Properties.Resources.btnSave;
        }

        public void SetLanguage(LanguageData languageData)
        {
            lblPvPOffsetTitle.Text = languageData.ClockSettings.PvPOffset.Name;
            lblOffsetDescription.Text = languageData.ClockSettings.PvPOffset.Description.Replace("\\r\\n", "\r\n"); ;
            lblStartClockOnReset.Text = languageData.ClockSettings.StartOnClockReset.Name;
            lblStartClockOnResetDescription.Text = languageData.ClockSettings.StartOnClockReset.Description;
            lblOpacity.Text = languageData.ClockSettings.WindowOpacity.Name;
            lblOpacityDescription.Text = languageData.ClockSettings.WindowOpacity.Description.Replace("\\r\\n", "\r\n"); ;
            lblAlwaysOnTop.Text = languageData.ClockSettings.WindowAlwaysOnTop.Name;
            lblAlwaysOnTopDescription.Text = languageData.ClockSettings.WindowAlwaysOnTop.Description;
            lblSave.Text = languageData.Settings.Save;
        }
    }
}
