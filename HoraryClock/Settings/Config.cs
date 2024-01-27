using System.ComponentModel;

namespace HoraryClock
{
    public class Config
    {
        public const int CHECKED = 1;
        public const int UNCHECKED = 0;

        private static Config _instance = null;

        public int LanguageId { get; set; }
        public int WindowOpacity { get; set; }
        public int PvPOffsett { get; set; }
        public int StartClockOnReset { get; set; }
        public int WindowAlwaysOnTop { get; set; }
        
        public KeyBinding KeyBindings { get; set; }

        //TODO: Add SettingsReader and settings file
        private Config() 
        {
            LanguageId = LanguageIds.ENGLISH;
            PvPOffsett = 0;
            StartClockOnReset = 0;
            WindowOpacity = 9;
            WindowAlwaysOnTop = 0;
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

        public void Load()
        {
            //TODO: Read from file
        }

        public void Save()
        {
            //TODO: Save config to a file
        }
    }
}