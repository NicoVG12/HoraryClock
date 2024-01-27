using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraryEffects
{
    public class EffectManager
    {
        public List<EffectType> Effects { get { return new List<EffectType>(Effects); } set { Effects = value; } }
        public int CurrentEffectId { get; set; }

        public int NextEffectId()
        {
            return (CurrentEffectId + 1) % Effects.Count;
        }

        public void AdvanceEffect()
        {
            CurrentEffectId = NextEffectId();
        }

        public EffectManager()
        {
            CurrentEffectId = 0;
            EffectInitializer.InitializeEffects(Effects);
        }
    }
}
