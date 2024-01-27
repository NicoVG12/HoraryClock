using System.ComponentModel;

namespace HoraryClock
{
    public class Config
    {
        private static Config _instance = null;

        public int LanguageId { get; set; }
        public bool PvPOffsett { get; set; }
        public bool StopClockOnReset { get; set; }
        public bool WindowAlwaysOnTop { get; set; }
        
        public KeyBinding KeyBindings { get; set; }

        //TODO: Add SettingsReader and settings file
        private Config() 
        {
            LanguageId = LanguageIds.ENGLISH;
            PvPOffsett = false;
            StopClockOnReset = false;
            KeyBindings = new KeyBinding();
        }

        public static Config Instance()
        {
            if ( _instance == null )
            {
                _instance = new Config();
            }
            return _instance;
        }

        public void LoadFromStorage()
        {
            //TODO: Read from file
        }
    }
}