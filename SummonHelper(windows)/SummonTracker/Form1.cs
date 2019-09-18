using SummonCore.Enums;
using SummonCore.Interface;
using SummonCore.Model;
using SummonCore.PresetData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SummonTracker
{
    public partial class Form1 : Form
    {
        public List<Preset> summonedCreatures = new List<Preset>();
        public Settings settings = new Settings();

        private void addSummon(Preset p)
        {
            summonedCreatures.Add(p);
            SummonedCreatures.Items.Add(p);
        }
        private void RemoveSummon(Preset p)
        {
            summonedCreatures.Remove(p);
            int newindex = SummonedCreatures.SelectedIndex - 1;
            if(newindex < 0)
            {
                newindex = 0;
            }

            SummonedCreatures.Items.Remove(p);
            if (SummonedCreatures.Items.Count > 0)
            {
                SummonedCreatures.SelectedIndex = newindex;
            }
        }
        private Preset getSummon(int index)
        {
            if(summonedCreatures.Count == 0)
            {
                return null;
            }
            if(index == -1)
            {
                return summonedCreatures.ElementAt(0);
            }
            return summonedCreatures.ElementAt(index);   
        }
        private Preset getSummon()
        {
            return getSummon(SummonedCreatures.SelectedIndex);
        }
        public Form1()
        {
            InitializeComponent();
            Spells.Items.AddRange(ActiveSpells.ActiveSpellsList().ToArray());
        }

        private void Spells_SelectedIndexChanged(object sender, EventArgs e)
        {
            Creatures.Items.Clear();

            IPreset presetData = ActiveSpells.GetPreset(Spells.SelectedItem.ToString());
            Creatures.Items.AddRange(presetData.getNames());
        }

        private void Creatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPreset presetData = ActiveSpells.GetPreset(Spells.SelectedItem.ToString());

            Preset addCreature = presetData.getList().ToList().First(x => x.name.Equals(Creatures.SelectedItem.ToString()));

            SummonCount.Value = addCreature.count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IPreset presetData = ActiveSpells.GetPreset(Spells.SelectedItem.ToString());

            for (int i = 0; i < SummonCount.Value; i++)
            {
                Preset addCreature = presetData.getList().ToList().First(x => x.name.Equals(Creatures.SelectedItem.ToString()));
                string name = addCreature.name;
                addCreature.name = name + "(" + (i+1) + ")";
                addCreature.atk.id = addCreature.name;
                addSummon(addCreature);
            }
        }

        private void SummonedCreatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(summonedCreatures.Count == 0 )
            {
                return;
            }
            Preset currCreature = getSummon();

            numAC.Value = currCreature.AC;
            numHP.Value = currCreature.Health.currentHP;

            RollTypes type = currCreature.atk.getRollType();
            rbtnAdv.Checked = false;
            rbtnNorm.Checked = false;
            rbtnDis.Checked = false;
            if(type == RollTypes.advantage)
            {
                rbtnAdv.Checked = true;
            }
            if (type == RollTypes.normal)
            {
                rbtnNorm.Checked = true;
            }
            if (type == RollTypes.disadvantage)
            {
                rbtnDis.Checked = true;
            }
        }

        private void btnAtk_Click(object sender, EventArgs e)
        {
            Atk[] atks = getAttackArray(summonedCreatures);
            display(atks);
        }

        private void display(Atk[] atks)
        {
            int damage = 0;
            string val = "";
            foreach (Atk atk in atks)
            {
                damage += atk.damTotal;
                val += atk.ToString() + "  \t Grand Damage: " + damage + "\r\n";
            }
            AtkOuput.Text = val;
        }

        private Atk[] getAttackArray(List<Preset> summons)
        {
            Atk[] atkArray = new Atk[summons.Count];

            Random rnd = new Random();

            for (int i = 0; i < atkArray.Length; i++)
            {
                Atk atk = summons.ElementAt(i).atk;
                atk.rollAtk(rnd);
                atk.rollDam(rnd);
                atkArray[i] = atk;
            }
            atkArray = atkArray.OrderByDescending(x => x.atkTotal).ToArray();

            return atkArray;
        }

        

        private void numHP_ValueChanged(object sender, EventArgs e)
        {
            if (summonedCreatures.Count == 0)
            {
                return;
            }
            getSummon().Health.currentHP = (int)numHP.Value;

            if(getSummon().Health.currentHP < 0)
            {
                RemoveSummon(getSummon());
            }
        }

        private void numAC_ValueChanged(object sender, EventArgs e)
        {
            if (summonedCreatures.Count == 0)
            {
                return;
            }
            getSummon().AC = (int)numAC.Value;
        }

        private void rbtnAdv_CheckedChanged(object sender, EventArgs e)
        {
            if (summonedCreatures.Count == 0)
            {
                return;
            }
            getSummon().atk.changeRollType(RollTypes.advantage);
        }

        private void rbtnNorm_CheckedChanged(object sender, EventArgs e)
        {
            if (summonedCreatures.Count == 0)
            {
                return;
            }
            getSummon().atk.changeRollType(RollTypes.normal);

        }

        private void rbtnDis_CheckedChanged(object sender, EventArgs e)
        {
            if (summonedCreatures.Count == 0)
            {
                return;
            }
            getSummon().atk.changeRollType(RollTypes.disadvantage);

        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            if(ChangeType.SelectedItem == null)
            {
                return;
            }
            string value = ChangeType.SelectedItem.ToString();
            RollTypes changeValue = RollTypes.normal;
            if(value == "Advantage")
            {
                changeValue = RollTypes.advantage;
            }
            else if(value == "Disadvantage")
            {
                changeValue = RollTypes.disadvantage;
            }
            foreach(Preset p in summonedCreatures)
            {
                p.atk.changeRollType(changeValue);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (summonedCreatures.Count == 0)
            {
                return;
            }
            Preset creature = getSummon();

            CreatureModel Model = new CreatureModel();

            Model.AC = creature.AC;
            Model.atk = creature.atk;
            Model.Health = creature.Health;
            Model.Name = creature.name;

            CreatureForm creatureForm = new CreatureForm(Model, this);
            creatureForm.Show();
        }

        public void ReceiveData(CreatureForm form, bool All)
        {
           CreatureModel newData = form.getData();
            bool newHP = form.NewHP();
            form.Close();
            Random rnd = new Random();

            if(All == false)
            {
                summonedCreatures.ElementAt(SummonedCreatures.SelectedIndex).AC = newData.AC;
                summonedCreatures.ElementAt(SummonedCreatures.SelectedIndex).atk = newData.atk;
                summonedCreatures.ElementAt(SummonedCreatures.SelectedIndex).Health = newData.Health;
                summonedCreatures.ElementAt(SummonedCreatures.SelectedIndex).name = newData.Name;

                Preset creature = new Preset("",getSummon().count,0,0,0,0);
                creature.AC = newData.AC;
                creature.atk = newData.atk;

                if (newHP == true)
                {
                    newData.Health.RollHP(rnd,settings);
                }
                else
                {
                    newData.Health.currentHP = creature.Health.currentHP;
                }

                creature.Health = newData.Health;
                creature.name = newData.Name;

                int i = SummonedCreatures.SelectedIndex;

                SummonedCreatures.Items.RemoveAt(i);
                SummonedCreatures.Items.Insert(i, creature);
            }
            else
            {
                for(int i = 0; i<summonedCreatures.Count; i++)
                {
                    summonedCreatures.ElementAt(i).AC = newData.AC;
                    summonedCreatures.ElementAt(i).atk = newData.atk;
                    summonedCreatures.ElementAt(i).Health.DiceType = newData.Health.DiceType;
                    summonedCreatures.ElementAt(i).Health.HPMod = newData.Health.HPMod;
                    summonedCreatures.ElementAt(i).Health.NumDice = newData.Health.NumDice;

                    if (newHP == true)
                    {
                        summonedCreatures.ElementAt(i).Health.RollHP(rnd,settings);
                    }


                    Preset creature = summonedCreatures.ElementAt(i);
                    SummonedCreatures.Items.RemoveAt(i);
                    SummonedCreatures.Items.Insert(i, creature);
                }
            }
        }
    }
}
