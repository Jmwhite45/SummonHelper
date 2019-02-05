using SummonCore.Interface;
using System.Collections.Generic;

namespace SummonCore.PresetData
{
    public class ActiveSpells
    {

        public static string[] ActiveSpellsList()
        {
            List<string> ret = new List<string>();

            ret.Add("Custom");
            ret.Add("Conjure Animals");
            ret.Add("Conjure Minor Elementals");
            ret.Add("Conjure Elemental");
            ret.Add("Conjure woodland Beings");
            ret.Add("Conjure Fey");

            return ret.ToArray();
        }
        public static IPreset GetPreset(string preset)
        {
            IPreset presetData = new ConjureAnimal();
            if (preset == "Conjure Animals")
            {
                presetData = new ConjureAnimal();
            }
            else if (preset == "Conjure Minor Elementals")
            {
                presetData = new ConjureElemetals(true);
            }
            else if (preset == "Conjure Elemental")
            {
                presetData = new ConjureElemetals(false);
            }
            else if (preset == "Conjure woodland Beings")
            {
                presetData = new ConjureFey(true);
            }
            else if (preset == "Conjure Fey")
            {
                presetData = new ConjureFey(false);
            }
            else if(preset == "Custom")
            {
                presetData = new Custom();
            }

            return presetData;
        }
    }
}
