using HoraryClock;
using Language;
using Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraryClockUI.Controls.SettingsWindow
{
    public partial class ResolutionControl : UserControl, ILanguageSetter
    {
        private GroupBox _btnGroup = new GroupBox();
        private List<RadioButton> _resolutionButtons = new List<RadioButton>();
        private string[] _resolutions = { Resolution.HIGH, Resolution.MID, Resolution.LOW };

        private MainForm _mainForm;
        private Config _config = Config.Instance();
        private LanguageManager _languageManager = LanguageManager.Instance();
        private Label[] _languageButtons = new Label[LanguageManager.LANGUAGE_AMOUNT];
        private string[] _languageMessages = new string[LanguageManager.LANGUAGE_AMOUNT];
        private int _newActiveLanguage = 0;
        public ResolutionControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            _newActiveLanguage = _config.LanguageId;

            InitializeComponent();
            LoadResolutions();
            LoadHoverImages();

            lblSampleResolution.Visible = false;
            _btnGroup.BringToFront();
            Controls.Add(_btnGroup);
        }

        private void LoadHoverImages()
        {
            HoverUtils.SetHoverImages(lblSave, Properties.Resources.btnSave, Properties.Resources.btnSaveHover1);
        }

        private void LoadResolutions()
        {
            int separation = 54;

            Point resolutionLocation = lblSampleResolution.Location;
            Point descriptionLocation = lblSampleDescription.Location;
            Point buttonLocation = btnSample.Location;

            for (int i = 0; i < _resolutions.Count(); i++)
            {
                Resolution currentResolution = Resolution.GetResolution(_resolutions[i]);

                Label lblResolution = new Label();
                Label lblDescription = new Label();
                RadioButton btnActive = new RadioButton();

                Controls.Add(lblResolution);
                Controls.Add(lblDescription);
                Controls.Add(btnActive);

                lblResolution.BringToFront();
                lblDescription.BringToFront();
                btnActive.BringToFront();

                lblResolution.Text = "Scale: " + currentResolution.Scale + "x (" + currentResolution.FullWindow.Width + "x" + currentResolution.FullWindow.Height + ")";
                lblResolution.AutoSize = false;
                lblResolution.Location = new Point(resolutionLocation.X, resolutionLocation.Y);
                lblResolution.Size = new Size(lblSampleResolution.Width, lblSampleResolution.Height);
                lblResolution.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
                lblResolution.ForeColor = lblSampleResolution.ForeColor;
                lblResolution.Margin = new Padding(0);
                lblResolution.TextAlign = lblSampleResolution.TextAlign;
                lblResolution.Image = lblSampleResolution.Image;
                lblResolution.Visible = true;

                lblDescription.Text = currentResolution.Description;
                lblDescription.AutoSize = false;
                lblDescription.Location = new Point(descriptionLocation.X, descriptionLocation.Y);
                lblDescription.Size = new Size(lblSampleDescription.Width, lblSampleDescription.Height);
                lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
                lblDescription.ForeColor = lblSampleDescription.ForeColor;
                lblDescription.Margin = new Padding(0);
                lblDescription.TextAlign = lblSampleDescription.TextAlign;
                lblDescription.Visible = true;

                btnActive.Name = currentResolution.Name;
                btnActive.AutoSize = false;
                btnActive.Size = btnSample.Size;
                btnActive.Location = new Point(buttonLocation.X, buttonLocation.Y);
                btnActive.Visible = true;
                _resolutionButtons.Add(btnActive);

                if (_config.Resolution.Name == _resolutions[i])
                {
                    btnActive.Checked = true;
                }

                resolutionLocation.Y += separation;
                descriptionLocation.Y += separation;
                buttonLocation.Y += separation;
            }

            Refresh();
        }


        public void MouseLeave(Label label, int languageId)
        {
            if (languageId == _newActiveLanguage)
            {
                label.Image = Properties.Resources.btnRoundRct_Active_Small;
            }
            else
            {
                label.Image = Properties.Resources.btnRoundRct_Unactive_Small;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            Resolution newResolution = Resolution.GetResolution(GetActiveResolution());

            _config.Resolution = newResolution;
            _config.Save();

            Application.Restart();
            Environment.Exit(0);
        }

        private string GetActiveResolution()
        {
            string activeResolution = Resolution.LOW;

            foreach (RadioButton button in _resolutionButtons)
            {
                if (button.Checked)
                {
                    activeResolution = button.Name;
                    break;
                }
            }

            return activeResolution;
        }

        private void lblBackground_Click(object sender, EventArgs e)
        {

        }

        public void SetLanguage(LanguageData languageData)
        {
            //throw new NotImplementedException();
        }
    }
}
