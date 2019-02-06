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

        private Form1 returnform;

        public CreatureForm(CreatureModel Model, Form1 form)
        {
            InitializeComponent();
            returnform = form;

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

        private void btnUpdThis_Click(object sender, EventArgs e)
        {
            returnform.ReceiveData(this, false);
        }

        public bool NewHP()
        {
            return newHP.Checked;
        }

        public CreatureModel getData()
        {
            CreatureModel Model = new CreatureModel();

            Model.Name = txtName.Text;
            Model.atk.atkMod = (int)atkMod.Value;

            Model.atk.numDice = (int)NumDamDice.Value;
            Model.atk.dice = (int)DamDiceType.Value;
            Model.atk.damMod = (int)DamMod.Value;

            Model.AC = (int)numAC.Value;

            Model.Health.NumDice = (int)numHPDice.Value;
            Model.Health.DiceType = (int)HPDiceType.Value;
            Model.Health.HPMod = (int)HPMod.Value;
            
            return Model;
        }

        private void btnUpdAll_Click(object sender, EventArgs e)
        {
            returnform.ReceiveData(this, true);
        }
    }
}
