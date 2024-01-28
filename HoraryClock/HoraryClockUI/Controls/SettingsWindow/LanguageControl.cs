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
        public LanguageControl()
        {
            InitializeComponent();
        }

        public void SetLanguage(LanguageData languageData)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
