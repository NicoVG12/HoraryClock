using Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraryClockUI
{
    public interface ILanguageSetter
    {
        public void SetLanguage(LanguageData languageData);
    }
}
