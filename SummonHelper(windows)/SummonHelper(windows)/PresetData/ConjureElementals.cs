using SummonHelper_windows_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonHelper_windows_.PresetData
{
    public class ConjureElemetals : IPreset
    {
        bool minor;

        public ConjureElemetals(bool Minor)
        {
            minor = Minor;
        }
        public Preset[] getList()
        {
            List<Preset> ret = new List<Preset>();

            ret.Add(new Preset("Azer", getCount(2, minor),5,1,8,3));
            ret.Add(new Preset("Air Elemental", getCount(5, minor),8,2,8,5));
            ret.Add(new Preset("Earth Elemental", getCount(5, minor),8,2,8,5));
            ret.Add(new Preset("Fire Elemental", getCount(5, minor),6,2,6,3));
            ret.Add(new Preset("Water Elemental", getCount(5, minor),7,2,8,4));
            ret.Add(new Preset("Galeb Duhr", getCount(6, minor),8,2,6,5));
            ret.Add(new Preset("Gargoyle(Bite)", getCount(2, minor),4,1,6,2));
            ret.Add(new Preset("Gargoyle(Claws)", getCount(2, minor), 4, 1, 6, 2));
            ret.Add(new Preset("Dao(Fist)", getCount(11, minor),10,2,8,6));
            ret.Add(new Preset("Dao(Maul)", getCount(11, minor), 10, 4, 6, 6));
            ret.Add(new Preset("Djinni", getCount(11, minor),9,2,6,5));
            ret.Add(new Preset("Efreeti(scimitar)", getCount(11, minor),10,4,6,6));
            ret.Add(new Preset("Efreeti(Hurl Flame)", getCount(11, minor), 7, 5, 6, 0));
            ret.Add(new Preset("Marid(1H)", getCount(11, minor),10,2,6,6));
            ret.Add(new Preset("Marid(2H)", getCount(11, minor), 10, 2, 8, 6));
            ret.Add(new Preset("Invisible Stalker", getCount(6, minor),6,2,6,3));
            ret.Add(new Preset("Magmin", getCount(.5, minor),4,2,6,0));
            ret.Add(new Preset("Dust Mephit", getCount(.5, minor),3,3,4,1));
            ret.Add(new Preset("Magma Mephit", getCount(.5, minor),3,2,4,1));
            ret.Add(new Preset("Ice Mephit", getCount(.5, minor),3,2,4,1));
            ret.Add(new Preset("Mud Mephit", getCount(.25, minor),3,1,6,1));
            ret.Add(new Preset("Smoke Mephit", getCount(.25, minor),4,1,4,2));
            ret.Add(new Preset("Steam Mephit", getCount(.25, minor),2,2,4,0));
            ret.Add(new Preset("fire Snake(Bite/tail)", getCount(1, minor),3,1,4,1));
            ret.Add(new Preset("Salamander(Spear 1h)", getCount(5, minor),7,3,6,4));
            ret.Add(new Preset("Salamander(Spear 2h)", getCount(5, minor), 7, 2, 8, 4));
            ret.Add(new Preset("Salamander(Tail)", getCount(5, minor), 7, 4, 6, 4));
            ret.Add(new Preset("Water weird", getCount(3, minor),5,3,6,3));
            ret.Add(new Preset("Blistercoil Weird(Medium)", getCount(4, minor),5,1,8,3));
            ret.Add(new Preset("Blistercoil Weird(Large)", getCount(4, minor), 5, 2, 8, 3));
            ret.Add(new Preset("Fluxcharger(slam)", getCount(7, minor),7,2,8,4));
            ret.Add(new Preset("Fluxcharger(Arc Lightning)", getCount(7, minor), 7, 3, 10, 0));
            ret.Add(new Preset("Galvanice Weird", getCount(1, minor),4,1,6,2));
            ret.Add(new Preset("Frost Salamader(Claw)", getCount(9, minor),9,1,6,5));
            ret.Add(new Preset("Frost Salamader(Bite)", getCount(9, minor), 9, 1, 8, 5));
            ret.Add(new Preset("Leviathan(Slam)", getCount(20, minor),16,1,10,10));
            ret.Add(new Preset("Leviathan(Tail)", getCount(20, minor), 16, 1, 12, 10));
            ret.Add(new Preset("Phonix(Beak)", getCount(16, minor),13,2,6,8));
            ret.Add(new Preset("Phonix(Talons)", getCount(16, minor), 13, 2, 8, 8));
            ret.Add(new Preset("Elder Tempest", getCount(23, minor),16,4,6,9));
            ret.Add(new Preset("Zaratan(Bite)", getCount(22, minor),17,4,8,10));
            ret.Add(new Preset("Zaratan(stomp)", getCount(22, minor), 17, 3, 10, 10));
            ret.Add(new Preset("Zaratan(Spit Rock)", getCount(22, minor), 17, 6, 8, 10));
            ret.Add(new Preset("Air Elemental Myrmidon", getCount(7, minor),7,1,8,4));
            ret.Add(new Preset("Earth Elemental Myrmidon", getCount(7, minor), 7,2, 6, 4));
            ret.Add(new Preset("Fire Elemental Myrmidon", getCount(7, minor), 7, 1, 6, 4));
            ret.Add(new Preset("Water Elemental Myrmidon(1H)", getCount(7, minor), 7, 1, 6, 4));
            ret.Add(new Preset("Water Elemental Myrmidon(2H)", getCount(7, minor), 7, 1, 8, 4));
            ret.Add(new Preset("Flail Snail", getCount(3,minor),5,1,6,3));

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

        public int getCount(double cr, bool minor)
        {
            if(minor == true)
            {
                if(cr > 2)
                {
                    return 0;
                }
                else if(cr == 2)
                {
                    return 1;
                }
                else if(cr == 1)
                {
                    return 2;
                }
                else if(cr == .5)
                {
                    return 4;
                }
                else if(cr <= .25)
                {
                    return 8;
                }
            }
            else if(minor == false)
            {
                if(cr<= 5)
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
            return "Conjure Elementals";
        }
    }
}
