using SummonHelper_windows_.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonHelper_windows_.PresetData
{
    public class Preset
    {
        public string name;
        public int count;
        public int atkMod;
        public int numDice;
        public int diceType;
        public int damMod;
        public Special special;

        public Preset(string Name, int Count, int AtkMod, int NumDice, int DiceType, int DamMod)
        {
            name = Name;
            count = Count;
            atkMod = AtkMod;
            numDice = NumDice;
            diceType = DiceType;
            damMod = DamMod;
            special = new Special("","",new Atk(0,0,0,0));
        }
        public Preset(string Name, int Count, int AtkMod, int NumDice, int DiceType, int DamMod, Special Special)
        {
            name = Name;
            count = Count;
            atkMod = AtkMod;
            numDice = NumDice;
            diceType = DiceType;
            damMod = DamMod;
            special = Special;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
