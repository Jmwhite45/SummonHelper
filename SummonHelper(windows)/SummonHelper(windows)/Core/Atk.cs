using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonHelper_windows_
{
    public class Atk
    {
        int id;

        int atkRoll;
        int otherAtkRoll;

        int atkMod;
        
        int numDice;
        int dice;
        int damMod;

        public int atkTotal;
        public int damTotal;
        RollTypes type;

        public Atk(int ID, int AtkMod, int NumDice, int Dice, int DamMod)
        {
            id = ID;
            atkMod = AtkMod;
            numDice = NumDice;
            dice = Dice;
            damMod = DamMod;
            type = RollTypes.normal;
        }

        public void changeRollType(RollTypes t)
        {
            type = t;
        }

        public void rollAtk(Random rnd)
        {
            atkRoll = rnd.Next(1, 21);
            otherAtkRoll = rnd.Next(1, 21);
            if(type == RollTypes.advantage)
            {
                atkTotal = atkMod + Math.Max(atkRoll, otherAtkRoll);
            }
            else if (type == RollTypes.disadvantage)
            {
                atkTotal = atkMod + Math.Min(atkRoll, otherAtkRoll);
            }
            else
            {
                atkTotal = atkRoll + atkMod;
            }
        }

        public void rollDam(Random rnd)
        {
            int damRoll = 0;
            for (int i = 0; i < numDice; i++)
            {
                damRoll += rnd.Next(1, dice + 1);
            }

            if ((atkTotal-atkMod) ==  20)
            {
                for (int i = 0; i < numDice; i++)
                {
                    damRoll += rnd.Next(1, dice + 1);
                }
            }
            damTotal = damRoll + damMod;
            
        }
        

        public override string ToString()
        {
            string ret = id+". \t";
            int roll = atkTotal-atkMod;

            if (roll == 20)
            {
                ret += "Nat20("+ atkTotal + ")";
            }
            else if (roll == 1)
            {
                ret += "Nat1(" + atkTotal + ")";
            }
            else
            {
                ret += atkTotal.ToString();
            }

            if((type == RollTypes.advantage)||(type == RollTypes.disadvantage))
            {
                ret += " (" + (atkRoll) + "," + (otherAtkRoll) + ")";
            }

            return ret + " for " + damTotal;
        }
    }
}
