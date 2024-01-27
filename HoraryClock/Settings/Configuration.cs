namespace HoraryClock
{
    public class Configuration
    {
        public int LanguageId { get; set; }
        public bool PvPOffsett { get; set; }
        public bool StopClockOnReset { get; set; }
        public bool WindowAlwaysOnTop { get; set; }
        
        public KeyBinding KeyBindings { get; set; }

        //TODO: Add SettingsReader and settings file
        public Configuration() 
        {
            LanguageId = LanguageIds.ENGLISH;
            PvPOffsett = false;
            StopClockOnReset = false;
            KeyBindings = new KeyBinding();
        }

        public void LoadFromStorage()
        {
            //TODO: Read from file
        }
    }
}