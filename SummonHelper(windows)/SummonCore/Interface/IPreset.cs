using SummonCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonCore.Interface
{
    public interface IPreset
    {
        Preset[] getList();
        string[] getNames();
        string getTitle();
    }
}
