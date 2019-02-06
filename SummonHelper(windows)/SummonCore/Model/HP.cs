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

        public void RollHP()
        {
            Random rnd = new Random();
            int ret = HPMod;

            for (int i = 0; i < NumDice; i++)
            {
                ret += rnd.Next(1, DiceType + 1);
            }

            currentHP = ret;
        }

        public HP(int num,int dice, int mod)
        {
            NumDice = num;
            DiceType = dice;
            HPMod = mod;

            RollHP();
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
