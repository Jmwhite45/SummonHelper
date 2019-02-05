using SummonCore.Model;
using System;
using System.Windows.Forms;

namespace SummonTracker
{
    public partial class CreatureForm : Form
    {
        public CreatureForm()
        {
            InitializeComponent();
        }
        public CreatureForm(CreatureModel Model)
        {
            InitializeComponent();

            txtName.Text = Model.Name;

            atkMod.Value = Model.atk.atkMod;

            NumDamDice.Value = Model.atk.numDice;
            DamDiceType.Value = Model.atk.dice;
            DamMod.Value = Model.atk.damMod;

            numAC.Value = Model.AC;

            numHPDice.Value = Model.Health.NumDice;
            HPDiceType.Value = Model.Health.DiceType;
            HPMod.Value = Model.Health.HPMod;
        }

        private void CreatureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
