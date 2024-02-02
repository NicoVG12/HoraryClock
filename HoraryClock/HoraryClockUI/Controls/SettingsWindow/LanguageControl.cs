using HoraryClock;
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
    public partial class LanguageControl : UserControl, ILanguageSetter
    {
        private MainForm _mainForm;
        private Config _config = Config.Instance();
        private LanguageManager _languageManager = LanguageManager.Instance();
        private Label[] _languageButtons = new Label[LanguageManager.LANGUAGE_AMOUNT];
        private string[] _languageMessages = new string[LanguageManager.LANGUAGE_AMOUNT];
        public LanguageControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadLanguageButtons();
            SetLanguage(_languageManager.GetLanguageData(_config.LanguageId));

            lblLanguageSample.Visible = false;
        }

        private void LoadLanguageButtons()
        {
            int lblWidth = 118;
            int lblHeight = 33;
            int LocationXDefault = 35;
            int LocationX = 10;
            int LocationY = 16;

            for (int i = 0; i < LanguageManager.LANGUAGE_AMOUNT; i++)
            {
                LanguageData languageData = _languageManager.GetLanguageData(i);
                Label lblLanguage = new Label();
                lblLanguage.BringToFront();

                lblLanguage.Text = languageData.Name;
                lblLanguage.AutoSize = false;
                lblLanguage.Location = new Point(LocationY, LocationY);
                lblLanguage.Size = new Size(lblWidth, lblHeight);
                lblLanguage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
                lblLanguage.ForeColor = Color.White;
                lblLanguage.Margin = new Padding(0);
                lblLanguage.Name = "lblLanguage" + i;
                lblLanguage.TabIndex = 17 + i;
                lblLanguage.TextAlign = ContentAlignment.MiddleCenter;
                lblLanguage.Visible = true;

                _languageButtons[i] = lblLanguage;
                _languageMessages[i] = languageData.SampleMessage;
                lblLanguage.Click += delegate { SetActiveLanguage(i); };


                LocationX += 118;
                if (LocationX > lblWidth + LocationXDefault)
                {
                    LocationX = LocationXDefault;
                    LocationY += lblHeight;
                }
            }


            Refresh();
            SetActiveLanguage(_config.LanguageId);
        }

        private void SetActiveLanguage(int languageId)
        {
            foreach (Label languageButton in _languageButtons)
            {
                languageButton.Image = Properties.Resources.btnRoundRct_Unactive;
            }

            _languageButtons[languageId].Image = Properties.Resources.btnRoundRct_Active;
            lblLanguageSampleMessage.Text = _languageMessages[languageId];
        }

        public void SetLanguage(LanguageData languageData)
        {
            lblSave.Text = languageData.Settings.Save;
            lblLanguageSampleMessage.Text = languageData.SampleMessage;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            _mainForm.LoadConfig();
            _mainForm.SetLanguage(GetActiveLanguage());
            _config.LanguageId = GetActiveLanguageId();
            _config.Save();
        }

        private int GetActiveLanguageId()
        {
            return 0;
        }
        private LanguageData GetActiveLanguage()
        {
            throw new NotImplementedException();
        }

        private void lblBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
