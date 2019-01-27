namespace SummonHelper_windows_
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
            this.label1 = new System.Windows.Forms.Label();
            this.numOf = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.atkRollMod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.damDiceMod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.diceType = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.damMod = new System.Windows.Forms.NumericUpDown();
            this.ATTACK = new System.Windows.Forms.Button();
            this.damOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disadvantage = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.advantage = new System.Windows.Forms.RadioButton();
            this.PresetSpells = new System.Windows.Forms.ComboBox();
            this.PresetCreatures = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkRollMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damDiceMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damMod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Creatures";
            // 
            // numOf
            // 
            this.numOf.Location = new System.Drawing.Point(164, 14);
            this.numOf.Margin = new System.Windows.Forms.Padding(4);
            this.numOf.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numOf.Name = "numOf";
            this.numOf.Size = new System.Drawing.Size(160, 22);
            this.numOf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attack Roll Modifier";
            // 
            // atkRollMod
            // 
            this.atkRollMod.Location = new System.Drawing.Point(164, 49);
            this.atkRollMod.Margin = new System.Windows.Forms.Padding(4);
            this.atkRollMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.atkRollMod.Name = "atkRollMod";
            this.atkRollMod.Size = new System.Drawing.Size(160, 22);
            this.atkRollMod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Damage Roll Modifier";
            // 
            // damDiceMod
            // 
            this.damDiceMod.Location = new System.Drawing.Point(164, 90);
            this.damDiceMod.Margin = new System.Windows.Forms.Padding(4);
            this.damDiceMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.damDiceMod.Name = "damDiceMod";
            this.damDiceMod.Size = new System.Drawing.Size(160, 22);
            this.damDiceMod.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "D";
            // 
            // diceType
            // 
            this.diceType.Location = new System.Drawing.Point(357, 90);
            this.diceType.Margin = new System.Windows.Forms.Padding(4);
            this.diceType.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.diceType.Name = "diceType";
            this.diceType.Size = new System.Drawing.Size(160, 22);
            this.diceType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "+";
            // 
            // damMod
            // 
            this.damMod.Location = new System.Drawing.Point(551, 90);
            this.damMod.Margin = new System.Windows.Forms.Padding(4);
            this.damMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.damMod.Name = "damMod";
            this.damMod.Size = new System.Drawing.Size(160, 22);
            this.damMod.TabIndex = 9;
            // 
            // ATTACK
            // 
            this.ATTACK.Location = new System.Drawing.Point(21, 135);
            this.ATTACK.Margin = new System.Windows.Forms.Padding(4);
            this.ATTACK.Name = "ATTACK";
            this.ATTACK.Size = new System.Drawing.Size(148, 41);
            this.ATTACK.TabIndex = 10;
            this.ATTACK.Text = "Attack";
            this.ATTACK.UseVisualStyleBackColor = true;
            this.ATTACK.Click += new System.EventHandler(this.ATTACK_Click);
            // 
            // damOutput
            // 
            this.damOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damOutput.Location = new System.Drawing.Point(191, 135);
            this.damOutput.Margin = new System.Windows.Forms.Padding(4);
            this.damOutput.Multiline = true;
            this.damOutput.Name = "damOutput";
            this.damOutput.ReadOnly = true;
            this.damOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.damOutput.Size = new System.Drawing.Size(859, 351);
            this.damOutput.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disadvantage);
            this.groupBox1.Controls.Add(this.normal);
            this.groupBox1.Controls.Add(this.advantage);
            this.groupBox1.Location = new System.Drawing.Point(27, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(135, 103);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // disadvantage
            // 
            this.disadvantage.AutoSize = true;
            this.disadvantage.Location = new System.Drawing.Point(9, 71);
            this.disadvantage.Margin = new System.Windows.Forms.Padding(4);
            this.disadvantage.Name = "disadvantage";
            this.disadvantage.Size = new System.Drawing.Size(116, 21);
            this.disadvantage.TabIndex = 2;
            this.disadvantage.Text = "Disadvantage";
            this.disadvantage.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Checked = true;
            this.normal.Location = new System.Drawing.Point(9, 43);
            this.normal.Margin = new System.Windows.Forms.Padding(4);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(74, 21);
            this.normal.TabIndex = 1;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // advantage
            // 
            this.advantage.AutoSize = true;
            this.advantage.Location = new System.Drawing.Point(9, 15);
            this.advantage.Margin = new System.Windows.Forms.Padding(4);
            this.advantage.Name = "advantage";
            this.advantage.Size = new System.Drawing.Size(97, 21);
            this.advantage.TabIndex = 0;
            this.advantage.Text = "Advantage";
            this.advantage.UseVisualStyleBackColor = true;
            // 
            // PresetSpells
            // 
            this.PresetSpells.FormattingEnabled = true;
            this.PresetSpells.Location = new System.Drawing.Point(16, 357);
            this.PresetSpells.Margin = new System.Windows.Forms.Padding(4);
            this.PresetSpells.Name = "PresetSpells";
            this.PresetSpells.Size = new System.Drawing.Size(160, 24);
            this.PresetSpells.TabIndex = 13;
            this.PresetSpells.SelectedIndexChanged += new System.EventHandler(this.PresetSpells_SelectedIndexChanged);
            this.PresetSpells.ValueMemberChanged += new System.EventHandler(this.PresetSpells_ValueMemberChanged);
            // 
            // PresetCreatures
            // 
            this.PresetCreatures.FormattingEnabled = true;
            this.PresetCreatures.Location = new System.Drawing.Point(16, 432);
            this.PresetCreatures.Margin = new System.Windows.Forms.Padding(4);
            this.PresetCreatures.Name = "PresetCreatures";
            this.PresetCreatures.Size = new System.Drawing.Size(160, 24);
            this.PresetCreatures.TabIndex = 14;
            this.PresetCreatures.SelectedIndexChanged += new System.EventHandler(this.PresetCreatures_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Presets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Spell";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 412);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Conjured Creature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PresetCreatures);
            this.Controls.Add(this.PresetSpells);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.damOutput);
            this.Controls.Add(this.ATTACK);
            this.Controls.Add(this.damMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diceType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.damDiceMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.atkRollMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOf);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkRollMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damDiceMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damMod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown atkRollMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown damDiceMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown diceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown damMod;
        private System.Windows.Forms.Button ATTACK;
        private System.Windows.Forms.TextBox damOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton disadvantage;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton advantage;
        private System.Windows.Forms.ComboBox PresetSpells;
        private System.Windows.Forms.ComboBox PresetCreatures;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

