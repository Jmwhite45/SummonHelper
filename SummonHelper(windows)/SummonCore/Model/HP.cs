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

        public void RollHP(Random rnd, Settings settings)
        {
            int ret = HPMod;

            for (int i = 0; i < NumDice; i++)
            {
                ret += rnd.Next(1, DiceType + 1);
                if (settings.Druidlv6 == true)
                {
                    ret += 2;
                }
            }
            if(settings.Wizardlv14 == true)
            {
                ret += 30;
            }

            currentHP = ret;
        }

        public HP(int num,int dice, int mod, Settings settings)
        {
            NumDice = num;
            DiceType = dice;
            HPMod = mod;

            RollHP(new Random(), settings);
        }
        public HP()
        {
            NumDice = 0;
            DiceType = 0;
            HPMod = 0;

            currentHP = 0;
        }
    }

}
