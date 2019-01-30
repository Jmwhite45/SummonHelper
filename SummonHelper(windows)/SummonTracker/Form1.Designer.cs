namespace SummonTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SummonedCreatures = new System.Windows.Forms.ListBox();
            this.Spells = new System.Windows.Forms.ComboBox();
            this.Creatures = new System.Windows.Forms.ComboBox();
            this.SummonCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AtkOuput = new System.Windows.Forms.TextBox();
            this.HP = new System.Windows.Forms.Label();
            this.numHP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numAC = new System.Windows.Forms.NumericUpDown();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAtk = new System.Windows.Forms.Button();
            this.rbtnAdv = new System.Windows.Forms.RadioButton();
            this.rbtnNorm = new System.Windows.Forms.RadioButton();
            this.rbtnDis = new System.Windows.Forms.RadioButton();
            this.btnChangeType = new System.Windows.Forms.Button();
            this.ChangeType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SummonCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAC)).BeginInit();
            this.SuspendLayout();
            // 
            // SummonedCreatures
            // 
            this.SummonedCreatures.FormattingEnabled = true;
            this.SummonedCreatures.ItemHeight = 16;
            this.SummonedCreatures.Location = new System.Drawing.Point(13, 157);
            this.SummonedCreatures.MultiColumn = true;
            this.SummonedCreatures.Name = "SummonedCreatures";
            this.SummonedCreatures.Size = new System.Drawing.Size(194, 276);
            this.SummonedCreatures.TabIndex = 0;
            this.SummonedCreatures.SelectedIndexChanged += new System.EventHandler(this.SummonedCreatures_SelectedIndexChanged);
            // 
            // Spells
            // 
            this.Spells.FormattingEnabled = true;
            this.Spells.Location = new System.Drawing.Point(13, 33);
            this.Spells.Name = "Spells";
            this.Spells.Size = new System.Drawing.Size(194, 24);
            this.Spells.TabIndex = 1;
            this.Spells.SelectedIndexChanged += new System.EventHandler(this.Spells_SelectedIndexChanged);
            // 
            // Creatures
            // 
            this.Creatures.FormattingEnabled = true;
            this.Creatures.Location = new System.Drawing.Point(13, 83);
            this.Creatures.Name = "Creatures";
            this.Creatures.Size = new System.Drawing.Size(194, 24);
            this.Creatures.TabIndex = 2;
            this.Creatures.SelectedIndexChanged += new System.EventHandler(this.Creatures_SelectedIndexChanged);
            // 
            // SummonCount
            // 
            this.SummonCount.Location = new System.Drawing.Point(13, 121);
            this.SummonCount.Name = "SummonCount";
            this.SummonCount.Size = new System.Drawing.Size(85, 22);
            this.SummonCount.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Spell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Creature";
            // 
            // AtkOuput
            // 
            this.AtkOuput.Location = new System.Drawing.Point(214, 157);
            this.AtkOuput.Multiline = true;
            this.AtkOuput.Name = "AtkOuput";
            this.AtkOuput.ReadOnly = true;
            this.AtkOuput.Size = new System.Drawing.Size(574, 276);
            this.AtkOuput.TabIndex = 7;
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Location = new System.Drawing.Point(211, 9);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(31, 17);
            this.HP.TabIndex = 8;
            this.HP.Text = "HP:";
            // 
            // numHP
            // 
            this.numHP.Location = new System.Drawing.Point(240, 7);
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(87, 22);
            this.numHP.TabIndex = 9;
            this.numHP.ValueChanged += new System.EventHandler(this.numHP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "AC:";
            // 
            // numAC
            // 
            this.numAC.Location = new System.Drawing.Point(240, 35);
            this.numAC.Name = "numAC";
            this.numAC.Size = new System.Drawing.Size(87, 22);
            this.numAC.TabIndex = 12;
            this.numAC.ValueChanged += new System.EventHandler(this.numAC_ValueChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(214, 64);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(113, 43);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open creature\r\n";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnAtk
            // 
            this.btnAtk.Location = new System.Drawing.Point(215, 112);
            this.btnAtk.Name = "btnAtk";
            this.btnAtk.Size = new System.Drawing.Size(113, 39);
            this.btnAtk.TabIndex = 15;
            this.btnAtk.Text = "Attack";
            this.btnAtk.UseVisualStyleBackColor = true;
            this.btnAtk.Click += new System.EventHandler(this.btnAtk_Click);
            // 
            // rbtnAdv
            // 
            this.rbtnAdv.AutoSize = true;
            this.rbtnAdv.Location = new System.Drawing.Point(333, 5);
            this.rbtnAdv.Name = "rbtnAdv";
            this.rbtnAdv.Size = new System.Drawing.Size(97, 21);
            this.rbtnAdv.TabIndex = 16;
            this.rbtnAdv.Text = "Advantage";
            this.rbtnAdv.UseVisualStyleBackColor = true;
            this.rbtnAdv.CheckedChanged += new System.EventHandler(this.rbtnAdv_CheckedChanged);
            // 
            // rbtnNorm
            // 
            this.rbtnNorm.AutoSize = true;
            this.rbtnNorm.Checked = true;
            this.rbtnNorm.Location = new System.Drawing.Point(333, 32);
            this.rbtnNorm.Name = "rbtnNorm";
            this.rbtnNorm.Size = new System.Drawing.Size(74, 21);
            this.rbtnNorm.TabIndex = 17;
            this.rbtnNorm.TabStop = true;
            this.rbtnNorm.Text = "Normal";
            this.rbtnNorm.UseVisualStyleBackColor = true;
            this.rbtnNorm.CheckedChanged += new System.EventHandler(this.rbtnNorm_CheckedChanged);
            // 
            // rbtnDis
            // 
            this.rbtnDis.AutoSize = true;
            this.rbtnDis.Location = new System.Drawing.Point(333, 59);
            this.rbtnDis.Name = "rbtnDis";
            this.rbtnDis.Size = new System.Drawing.Size(116, 21);
            this.rbtnDis.TabIndex = 18;
            this.rbtnDis.Text = "Disadvantage";
            this.rbtnDis.UseVisualStyleBackColor = true;
            this.rbtnDis.CheckedChanged += new System.EventHandler(this.rbtnDis_CheckedChanged);
            // 
            // btnChangeType
            // 
            this.btnChangeType.Location = new System.Drawing.Point(334, 112);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(120, 39);
            this.btnChangeType.TabIndex = 19;
            this.btnChangeType.Text = "Change All";
            this.btnChangeType.UseVisualStyleBackColor = true;
            this.btnChangeType.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // ChangeType
            // 
            this.ChangeType.FormattingEnabled = true;
            this.ChangeType.Items.AddRange(new object[] {
            "Advantage",
            "Normal",
            "Disadvantage"});
            this.ChangeType.Location = new System.Drawing.Point(333, 83);
            this.ChangeType.Name = "ChangeType";
            this.ChangeType.Size = new System.Drawing.Size(121, 24);
            this.ChangeType.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeType);
            this.Controls.Add(this.btnChangeType);
            this.Controls.Add(this.rbtnDis);
            this.Controls.Add(this.rbtnNorm);
            this.Controls.Add(this.rbtnAdv);
            this.Controls.Add(this.btnAtk);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.numAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numHP);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.AtkOuput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.SummonCount);
            this.Controls.Add(this.Creatures);
            this.Controls.Add(this.Spells);
            this.Controls.Add(this.SummonedCreatures);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SummonCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SummonedCreatures;
        private System.Windows.Forms.ComboBox Spells;
        private System.Windows.Forms.ComboBox Creatures;
        private System.Windows.Forms.NumericUpDown SummonCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AtkOuput;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.NumericUpDown numHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAC;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAtk;
        private System.Windows.Forms.RadioButton rbtnAdv;
        private System.Windows.Forms.RadioButton rbtnNorm;
        private System.Windows.Forms.RadioButton rbtnDis;
        private System.Windows.Forms.Button btnChangeType;
        private System.Windows.Forms.ComboBox ChangeType;
    }
}

