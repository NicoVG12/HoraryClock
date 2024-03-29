using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraryClock
{
    public class KeyBinding
    {
        public string StartKey { get; set; }
        public string PauseKey { get; set; }
        public string ResetKey { get; set; }

        public KeyBinding()
        {
            StartKey = "F1";
            PauseKey = "F2";
            ResetKey = "F3";
        }
    }
}
