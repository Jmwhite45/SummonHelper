using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonCore.Model
{
    public class Preset
    {
        public string name;
        public int count;
        public Atk atk;
        public Special special;

        public int AC;
        public HP Health;

        public Preset(string Name, int Count, int AtkMod, int NumDice, int DiceType, int DamMod)
        {
            name = Name;
            count = Count;

            atk = new Atk(Name, AtkMod, NumDice, DiceType, DamMod);
            special = new Special("","",new Atk(0,0,0,0,0));

            Health = new HP();
        }
        public Preset(string Name, int Count, int AtkMod, int NumDice, int DiceType, int DamMod, Special Special)
        {
            name = Name;
            count = Count;

            atk = new Atk(Name, AtkMod, NumDice, DiceType, DamMod);
            special = new Special("", "", new Atk(0, 0, 0, 0, 0));

            Health = new HP();
            special = Special;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
