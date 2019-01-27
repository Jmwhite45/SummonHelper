using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonHelper_windows_.Core
{
    public class Special
    {
        public string name { get; set; }
        string description { get; set; }
        Atk extra { get; set; }


        public Special(string Name, string Description, Atk Extra)
        {
            name = Name;
            description = Description;
            extra = Extra;
        }
    }
}
