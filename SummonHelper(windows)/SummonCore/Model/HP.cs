using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonCore.Model
{
    public class HP
    {
        public int NumDice { get; set; }
        public int DiceType { get; set; }
        public int HPMod { get; set; }

        public int currentHP { get; set; }

        public int RollHP()
        {
            Random rnd = new Random();
            int ret = HPMod;

            for (int i = 0; i < NumDice; i++)
            {
                ret += rnd.Next(1, DiceType + 1);
            }

            return ret;
        }
    }

}
