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
            try
            {
                StreamReader sr = new StreamReader("appconfig");
                LanguageId = int.Parse(sr.ReadLine().Split(" ")[1]);
                PvPOffsett = int.Parse(sr.ReadLine().Split(" ")[1]);
                StartClockOnReset = int.Parse(sr.ReadLine().Split(" ")[1]);
                WindowOpacity = int.Parse(sr.ReadLine().Split(" ")[1]);
                WindowAlwaysOnTop = int.Parse(sr.ReadLine().Split(" ")[1]);
                KeyBindings.StartKey = sr.ReadLine().Split(" ")[1];
                KeyBindings.PauseKey = sr.ReadLine().Split(" ")[1];
                KeyBindings.ResetKey = sr.ReadLine().Split(" ")[1];
                sr.Close();
            }
            catch (Exception ex )
            {
                //TODO: Handle wrong config file exception
            }
            //TODO: Read from file
        }

        public void Save()
        {
            try
            {
                StreamWriter sw = new StreamWriter("appconfig");
                sw.WriteLine("LANGUAGE " + LanguageId);
                sw.WriteLine("OFFSET " + PvPOffsett);
                sw.WriteLine("START_ON_RESET " +  StartClockOnReset);
                sw.WriteLine("OPACITY " + WindowOpacity);
                sw.WriteLine("ALWAYS_ON_TOP " + WindowAlwaysOnTop);
                sw.WriteLine("START_KEY " + KeyBindings.StartKey);
                sw.WriteLine("PAUSE_KEY " + KeyBindings.PauseKey);
                sw.WriteLine("RESET_KEY " + KeyBindings.ResetKey);
                sw.Close();
            }
            catch (Exception ex)
            {
                //TODO: Handle error while writing file
            }
            //TODO: Save config to a file
        }
    }
}