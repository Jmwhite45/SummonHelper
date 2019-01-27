using SummonHelper_windows_.Core;
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

namespace SummonHelper_windows_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PresetSpells.Items.AddRange(ActiveSpells.ActiveSpellsList().ToArray());
        }

        private void ATTACK_Click(object sender, EventArgs e)
        {
            Atk[] atks = getAttackArray();
            display(atks);
        }

        private Atk[] getAttackArray()
        {
            Atk[] atkArray = new Atk[(int)numOf.Value];

            Random rnd = new Random();

            for (int i = 0; i<atkArray.Length; i++)
           {
                Atk atk = new Atk((int)atkRollMod.Value, (int)damDiceMod.Value, (int)diceType.Value, (int)damMod.Value);
                atk.changeRollType(rolltwo());
                atk.rollAtk(rnd);
                atk.rollDam(rnd);
                atkArray[i] = atk;
           }
            atkArray = atkArray.OrderByDescending(x => x.atkTotal).ToArray();

            return atkArray;
        }

        private void display(Atk[] atks)
        {
            int damage = 0;
            string val = "";
            int i = 1;
            foreach(Atk atk in atks)
            {
                damage += atk.damTotal;
                val += i + ". \t" + atk.ToString() + "  \t Grand Damage: " + damage + "\r\n";
                i++;
            }
            damOutput.Text = val;
        }

        private RollTypes rolltwo()
        {
            if(advantage.Checked == true)
            {
                return RollTypes.advantage;
            }
            else if (normal.Checked == true)
            {
                return RollTypes.normal;
            }
            else if(disadvantage.Checked == true)
            {
                return RollTypes.disadvantage;
            }
            else
            {
                return RollTypes.normal;
            }
        }

        private void PresetSpells_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void PresetSpells_SelectedIndexChanged(object sender, EventArgs e)
        {
            PresetCreatures.Items.Clear();

            IPreset presetData = ActiveSpells.GetPreset(PresetSpells.SelectedItem.ToString());
            PresetCreatures.Items.AddRange(presetData.getNames());
        }

        private void PresetCreatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPreset presetData = ActiveSpells.GetPreset(PresetSpells.SelectedItem.ToString());

            Preset currAttack = presetData.getList().ToList().First(x => x.name.Equals(PresetCreatures.SelectedItem.ToString()));

            numOf.Value = currAttack.count;
            atkRollMod.Value = currAttack.atkMod;
            damDiceMod.Value = currAttack.numDice;
            diceType.Value = currAttack.diceType;
            damMod.Value = currAttack.damMod;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
