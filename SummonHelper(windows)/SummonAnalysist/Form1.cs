using SummonHelper_windows_.PresetData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SummonHelper_windows_;
using SummonHelper_windows_.Core;

namespace SummonAnalysist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Spells.Items.AddRange(ActiveSpells.ActiveSpellsList().ToArray());
        }

        private void Spells_SelectedIndexChanged(object sender, EventArgs e)
        {
            Summons.Items.Clear();

            IPreset presetData = new ConjureAnimal();
            if (Spells.SelectedItem.ToString() == "Conjure Animals")
            {
                presetData = new ConjureAnimal();
            }
            Summons.Items.AddRange(presetData.getNames());
        }

        private void Summons_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPreset presetData = new ConjureAnimal();
            if (Spells.SelectedItem.ToString() == "Conjure Animals")
            {
                presetData = new ConjureAnimal();
            }

            Preset currAttack = presetData.getList().ToList().First(x => x.name.Equals(Summons.SelectedItem.ToString()));

            Analysize(currAttack);
        }

        private void Analysize(Preset currAttack)
        {
            string output = currAttack.name + Environment.NewLine;
            output += "To Hit: +" + currAttack.atkMod+ Environment.NewLine;
            output += "Damage: " + currAttack.numDice + "d" + currAttack.diceType + "+" + currAttack.damMod + Environment.NewLine;
            output += Environment.NewLine + "Other Analysis" + Environment.NewLine + "-------------" + Environment.NewLine;
            output += "Average Damage: " + AverageDam(currAttack)+Environment.NewLine;
            output += "Min Damage: " + MinDam(currAttack) + Environment.NewLine;
            output += "Max Damage: " + MaxDam(currAttack) + Environment.NewLine;

            IndividualOut.Text = output;
        }

        private int MaxDam(Preset currAttack)
        {
            return (currAttack.numDice * currAttack.diceType) + currAttack.damMod;
        }

        private int MinDam(Preset currAttack)
        {
            return (currAttack.numDice * 1) + currAttack.damMod;
        }

        private double AverageDam(Preset currAttack)
        {
            return (double)(currAttack.numDice * ((currAttack.diceType + 1) / 2)) + currAttack.damMod;
        }

        private void MassAnalysis_Click(object sender, EventArgs e)
        {
            IPreset presetData = new ConjureAnimal();
            if (Spells.SelectedItem.ToString() == "Conjure Animals")
            {
                presetData = new ConjureAnimal();
            }

            List<Preset> currAttacks = presetData.getList().ToList();

            MassOutput.Text = Mass_Analysis(currAttacks);
        }

        private string Mass_Analysis(List<Preset> currAttacks)
        {
            string output = "";

            Preset MaxDamage = new Preset("temp",0,0,0,0,0);
            Preset MinDamage = new Preset("temp", 0, 0, 0, 0, 0);
            Preset avergeDamage = new Preset("temp", 0, 0, 0, 0, 0);

            foreach (Preset atk in currAttacks)
            {
               if(MaxDam(MaxDamage)*MaxDamage.count < MaxDam(atk)*atk.count)
                {
                    MaxDamage = atk;
                }
                if (MinDam(MinDamage) * MinDamage.count < MinDam(atk) * atk.count)
                {
                    MinDamage = atk;
                }
                if (AverageDam(avergeDamage) * avergeDamage.count < AverageDam(atk) * atk.count)
                {
                    avergeDamage = atk;
                }
            }

            output = "Mass Analysis Results" + Environment.NewLine + "---------------------"+Environment.NewLine;
            output += "Max Damage: " + MaxDamage.name+"("+MaxDamage.count+") with " + MaxDam(MaxDamage) * MaxDamage.count+Environment.NewLine;
            output += "Min Damage: " + MinDamage.name + "(" + MinDamage.count + ") with " + MinDam(MinDamage) * MinDamage.count+Environment.NewLine;
            output += "Aver Damage: " + avergeDamage.name + "(" + avergeDamage.count + ") with " + AverageDam(avergeDamage) * avergeDamage.count + Environment.NewLine;

            output += AC_Analysis(currAttacks, 10);
            output += AC_Analysis(currAttacks, 11);
            output += AC_Analysis(currAttacks, 12);
            output += AC_Analysis(currAttacks, 13);
            output += AC_Analysis(currAttacks, 14);
            output += AC_Analysis(currAttacks, 15);
            output += AC_Analysis(currAttacks, 16);
            output += AC_Analysis(currAttacks, 17);
            output += AC_Analysis(currAttacks, 18);
            output += AC_Analysis(currAttacks, 19);
            output += AC_Analysis(currAttacks, 20);

            return output;
        }

        private string AC_Analysis(List<Preset> currAttacks, int AC)
        {
            string output = Environment.NewLine+"AC "+AC+Environment.NewLine+"------"+Environment.NewLine;

            Preset MaxDamage = new Preset("temp", 0, 0, 0, 0, 0);
            Preset MinDamage = new Preset("temp", 0, 0, 0, 0, 0);
            Preset avergeDamage = new Preset("temp", 0, 0, 0, 0, 0);

            foreach (Preset atk in currAttacks)
            {
                double a = (MaxDam(MaxDamage) * MaxDamage.count) * ACMod(AC, MaxDamage.atkMod);
                double c = ACMod(AC, atk.atkMod);
                double b = (MaxDam(atk) * atk.count) * c;


                if (a < b)
                {
                    MaxDamage = atk;
                }
                if ((MinDam(MinDamage) * MinDamage.count) * ACMod(AC, MinDamage.atkMod) < (MinDam(atk) * atk.count) * ACMod(AC, atk.atkMod))
                {
                    MinDamage = atk;
                }
                if ((AverageDam(avergeDamage) * avergeDamage.count) *ACMod(AC, avergeDamage.atkMod) < (AverageDam(atk) * atk.count) * ACMod(AC, atk.atkMod))
                {
                    avergeDamage = atk;
                }
            }

            output += "Max Damage: " + MaxDamage.name + "(" + MaxDamage.count + ") with " + (MaxDam(MaxDamage) * MaxDamage.count) * ACMod(AC, MaxDamage.atkMod) + Environment.NewLine;
            output += "Min Damage: " + MinDamage.name + "(" + MinDamage.count + ") with " + (MinDam(MinDamage) * MinDamage.count) * ACMod(AC, MinDamage.atkMod) + Environment.NewLine;
            output += "Aver Damage: " + avergeDamage.name + "(" + avergeDamage.count + ") with " + (AverageDam(avergeDamage) * avergeDamage.count)*ACMod(AC, avergeDamage.atkMod) + Environment.NewLine;

            return output;
        }

        private double ACMod(int AC, int atkMod)
        {
            int output = AC - atkMod;
            if(output < 0)
            {
                output = 0;
            }

            return (double)(20 - output) / 20;
        }
    }
}
