using SummonHelper_windows_.Core;
using SummonHelper_windows_.PresetData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonHelper_windows_.Core
{
    public interface IPreset
    {
        Preset[] getList();
        string[] getNames();
        string getTitle();
    }
}
