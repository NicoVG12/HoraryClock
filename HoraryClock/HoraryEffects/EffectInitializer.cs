using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraryEffects
{
    public class EffectInitializer
    {
        public static void InitializeEffects(List<EffectType> effects)
        {
            string[] lightDescription = { "Ally All Damage Increase +" + EffectData.LIGHT_DAMAGE + "%.", "" };
            string[] curseDescription = { "Ignores " + EffectData.CURSE_DEFENCE_IGNORE + "% of enemy's defence.", "Amount of hits increased to " + EffectData.CURSE_HITS + "." };
            string[] judgementDescription = { "Ally Special Resources Consumption " + EffectData.JUDGEMENT_COST + "%.", "" };
            string[] culminationDescription = { "Ally All Damage Increase +" + EffectData.CULMINATION_DAMAGE + "%.", "Ally Special Resources Consumption " + EffectData.CULMINATION_COST + "%." };

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = "[Collection Of Light]",
                Description = lightDescription,
                Duration = EffectData.LIGHT_DURATION
            });

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = "[Void of Curse]",
                Description = curseDescription,
                Duration = EffectData.CURSE_DURATION
            });

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = "[Judgement]",
                Description = judgementDescription,
                Duration = EffectData.JUDGEMENT_DURATION
            });

            effects.Add(new EffectType()
            {
                Id = effects.Count,
                Name = "[Culmination]",
                Description = culminationDescription,
                Duration = EffectData.CULMINATION_DURATION
            });
        }
    }
}
