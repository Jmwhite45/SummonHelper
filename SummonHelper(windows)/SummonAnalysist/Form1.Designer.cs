namespace SummonAnalysist
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
            this.Spells = new System.Windows.Forms.ComboBox();
            this.MassAnalysis = new System.Windows.Forms.Button();
            this.IndividualOut = new System.Windows.Forms.TextBox();
            this.MassOutput = new System.Windows.Forms.TextBox();
            this.Summons = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Spells
            // 
            this.Spells.FormattingEnabled = true;
            this.Spells.Location = new System.Drawing.Point(246, 12);
            this.Spells.Name = "Spells";
            this.Spells.Size = new System.Drawing.Size(167, 24);
            this.Spells.TabIndex = 0;
            this.Spells.SelectedIndexChanged += new System.EventHandler(this.Spells_SelectedIndexChanged);
            // 
            // MassAnalysis
            // 
            this.MassAnalysis.Location = new System.Drawing.Point(470, 39);
            this.MassAnalysis.Name = "MassAnalysis";
            this.MassAnalysis.Size = new System.Drawing.Size(131, 32);
            this.MassAnalysis.TabIndex = 2;
            this.MassAnalysis.Text = "Mass Analysis";
            this.MassAnalysis.UseVisualStyleBackColor = true;
            this.MassAnalysis.Click += new System.EventHandler(this.MassAnalysis_Click);
            // 
            // IndividualOut
            // 
            this.IndividualOut.Location = new System.Drawing.Point(12, 80);
            this.IndividualOut.Multiline = true;
            this.IndividualOut.Name = "IndividualOut";
            this.IndividualOut.ReadOnly = true;
            this.IndividualOut.Size = new System.Drawing.Size(248, 391);
            this.IndividualOut.TabIndex = 4;
            // 
            // MassOutput
            // 
            this.MassOutput.Location = new System.Drawing.Point(304, 80);
            this.MassOutput.Multiline = true;
            this.MassOutput.Name = "MassOutput";
            this.MassOutput.ReadOnly = true;
            this.MassOutput.Size = new System.Drawing.Size(433, 391);
            this.MassOutput.TabIndex = 5;
            // 
            // Summons
            // 
            this.Summons.FormattingEnabled = true;
            this.Summons.Location = new System.Drawing.Point(66, 47);
            this.Summons.Name = "Summons";
            this.Summons.Size = new System.Drawing.Size(121, 24);
            this.Summons.TabIndex = 6;
            this.Summons.SelectedIndexChanged += new System.EventHandler(this.Summons_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 512);
            this.Controls.Add(this.Summons);
            this.Controls.Add(this.MassOutput);
            this.Controls.Add(this.IndividualOut);
            this.Controls.Add(this.MassAnalysis);
            this.Controls.Add(this.Spells);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Spells;
        private System.Windows.Forms.Button MassAnalysis;
        private System.Windows.Forms.TextBox IndividualOut;
        private System.Windows.Forms.TextBox MassOutput;
        private System.Windows.Forms.ComboBox Summons;
    }
}

