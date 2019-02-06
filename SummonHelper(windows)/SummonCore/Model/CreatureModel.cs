using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummonCore.Model
{
    public class CreatureModel
    {
        public Atk atk { get; set; }
        public string Name { get; set; }
        public int AC { get; set; }
        public HP Health { get; set; }

        public CreatureModel()
        {
            Name = "";
            AC = 10;
            atk = new Atk(0, 0, 0, 0, 0);
            Health = new HP();
        }
    }
    
}
