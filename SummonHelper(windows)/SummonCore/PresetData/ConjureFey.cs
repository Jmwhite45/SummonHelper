using SummonCore.Interface;
using SummonCore.Model;
using System.Collections.Generic;

namespace SummonCore.PresetData
{
    public class ConjureFey : IPreset
    {
        bool minor;

        public ConjureFey(bool Minor)
        {
            minor = Minor;
        }

        public Preset[] getList()
        {
            List<Preset> ret = new List<Preset>();

            ret.Add(new Preset("Dryad", getCount(1),2,1,4,0));
            ret.Add(new Preset("Green Hag", getCount(3),6,2,8,4));
            ret.Add(new Preset("Night Hag", getCount(5),7,2,8,4));
            ret.Add(new Preset("Sea Hag", getCount(2),5,2,6,3));
            ret.Add(new Preset("Pixie", getCount(.25),0,0,0,0));
            ret.Add(new Preset("Satyr(Ram)", getCount(.5), 3, 2, 4, 1));
            ret.Add(new Preset("Satyr(Shortsword)", getCount(.5), 5, 1, 6, 3));
            ret.Add(new Preset("Satyr(Shortbow)", getCount(.5), 5, 1, 6, 3));
            ret.Add(new Preset("Sprite(longsword)", getCount(.25),2,1,1,0));
            ret.Add(new Preset("Sprite(shortbow)", getCount(.25), 6, 1, 1, 0));
            ret.Add(new Preset("Blink Dog", getCount(.25),3,1,6,1));
            ret.Add(new Preset("Autumn Eladrin(longsword 1H)", getCount(10),5,1,8,1));
            ret.Add(new Preset("Autumn Eladrin(longsword 2H)", getCount(10), 5, 1, 10, 1));
            ret.Add(new Preset("Autumn Eladrin(Longbow)", getCount(10), 7, 1, 8, 3));
            ret.Add(new Preset("Spring Eladrin(longsword 1H)", getCount(10), 6, 1, 8, 2));
            ret.Add(new Preset("Spring Eladrin(longsword 2H)", getCount(10), 6, 1, 10, 2));
            ret.Add(new Preset("Spring Eladrin(Longbow)", getCount(10), 7, 1, 8, 3));
            ret.Add(new Preset("Summer Eladrin(longsword 1H)", getCount(10), 8, 2, 8, 4));
            ret.Add(new Preset("Summer Eladrin(longsword 2H)", getCount(10), 8, 2, 10, 4));
            ret.Add(new Preset("Summer Eladrin(Longbow)", getCount(10), 9, 2, 8, 5));
            ret.Add(new Preset("Winter Eladrin(longsword 1H)", getCount(10), 4, 1, 8, 0));
            ret.Add(new Preset("Winter Eladrin(longsword 2H)", getCount(10),4, 1, 10, 0));
            ret.Add(new Preset("Winter Eladrin(Longbow)", getCount(10), 4, 1, 8, 0));
            ret.Add(new Preset("Conclave Dryad(vine staff)", getCount(9),9,2,6,5));
            ret.Add(new Preset("Conclave Dryad(Longbow)", getCount(9), 8, 1, 8, 4));
            ret.Add(new Preset("Trostani(contrict)", getCount(18),11,3,6,5));
            ret.Add(new Preset("Trostani(Touch of order)", getCount(18), 16, 3, 8, 10));
            ret.Add(new Preset("Boggle", getCount((1 / 8)), 1, 1, 6, -1));
            ret.Add(new Preset("Darkling", getCount(.5), 5, 1, 4, 3));
            ret.Add(new Preset("Darkling Elder", getCount(2), 5, 1, 6, 3));
            ret.Add(new Preset("Annis Hag(bite)",getCount(6),8,3,6,5));
            ret.Add(new Preset("Annis Hag(claw)", getCount(6), 8, 3, 6, 5));
            ret.Add(new Preset("Bheur Hag",getCount(7),4,2,8,1));
            ret.Add(new Preset("Korred(great Club)", getCount(7), 9, 1, 8, 6));
            ret.Add(new Preset("Korred(Rock)", getCount(7), 9, 2, 8, 6));
            ret.Add(new Preset("Meenlock", getCount(2), 4, 2, 4, 2));
            ret.Add(new Preset("quickling", getCount(1), 8, 1, 4, 6));
            ret.Add(new Preset("Redcap", getCount(3), 6, 2, 4, 4));
            ret.Add(new Preset("Yeth", getCount(4), 6, 2, 6, 4));

            return ret.ToArray();
        }

        public string[] getNames()
        {
            List<string> ret = new List<string>();
            Preset[] presets = getList();

            foreach (Preset preset in presets)
            {
                ret.Add(preset.ToString());
            }

            return ret.ToArray();
        }
        public int getCount(double cr)
        {
            if (minor == true)
            {
                if (cr > 2)
                {
                    return 0;
                }
                else if (cr == 2)
                {
                    return 1;
                }
                else if (cr == 1)
                {
                    return 2;
                }
                else if (cr == .5)
                {
                    return 4;
                }
                else if (cr <= .25)
                {
                    return 8;
                }
            }
            else if (minor == false)
            {
                if (cr <= 6)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
        public string getTitle()
        {
            return "Conjure Fey";
        }
    }
}
