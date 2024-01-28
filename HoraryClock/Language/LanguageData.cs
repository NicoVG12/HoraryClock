using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language
{
    public class LanguageData
    {
        public string Name { get; set; }
        public struct ClockWindow
        {
            public string NotStartedYet { get; set; }
            public string NoEffectsApplied { get; set; }
            public string RemainingTime { get; set; }
            public string Start { get; set; }
            public string Pause { get; set; }
            public string Reset { get; set; }
        }

        public struct HoraryEffects
        {
            public struct CollectionOfLight
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
            }

            public struct VoidOfCurse
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
                public string Description2 { get; set; }
            }

            public struct Judgement
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
            }

            public struct Culmination
            {
                public string Name { get; set; }
                public string Description0 { get; set; }
                public string Description1 { get; set; }
                public string Description2 { get; set; }
                public string Description3 { get; set; }
            }
        }

        public struct Settings
        {
            public string Language { get; set; }
            public string Clock { get; set; }
            public string KeyBindings { get; set; }
            public string Other { get; set; }
            public string Return { get; set; }
            public string Save { get; set; }
        }

        public struct ClockSettings
        {
            public struct PvPOffset
            {
                public string Name { get; set; }
                public string Description { get; set; }
            };

            public struct StartClockOnReset
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public struct WindowOpacity
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public struct WindowAlwaysOnTop
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }
        }

        public struct KeySettings
        {
            public struct StartKey
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public struct PauseKey
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public struct ResetKey
            {
                public string Name { get; set; }
                public string Description { get; set; }
            }

            public string KeysAllowed { get; set; }
            public string CannotBoundSameKeyToMultipleActions { get; set; }
        }
    }
}
