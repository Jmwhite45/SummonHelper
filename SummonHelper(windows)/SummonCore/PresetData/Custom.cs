using SummonCore.Interface;
using SummonCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonCore.PresetData
{
    public class Custom : IPreset
    {
        public Preset[] getList()
        {
            List<Preset> ret = new List<Preset>();

            ret.Add(new Preset("Hakrim", 1, 5, 2, 4, 3));

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

        public string getTitle()
        {
            return "Custom";
        }

    }
}
