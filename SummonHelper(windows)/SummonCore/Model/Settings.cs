using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonCore.Model
{
    public class Settings
    {
        public bool Druidlv6 { get; set; } // Beast fey +2 hp per hit dice
        public bool Wizardlv14 { get; set; }// +30 hp;

        public Settings()
        {
            Druidlv6 = false;
            Wizardlv14 = false;
        }
    }

}
