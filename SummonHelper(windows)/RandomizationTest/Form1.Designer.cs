namespace RandomizationTest
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
            this.btnd4 = new System.Windows.Forms.Button();
            this.btnd6 = new System.Windows.Forms.Button();
            this.btnd8 = new System.Windows.Forms.Button();
            this.btnd10 = new System.Windows.Forms.Button();
            this.btnd12 = new System.Windows.Forms.Button();
            this.btnd20 = new System.Windows.Forms.Button();
            this.btnd100 = new System.Windows.Forms.Button();
            this.Rounds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.d4output = new System.Windows.Forms.TextBox();
            this.d6output = new System.Windows.Forms.TextBox();
            this.d8output = new System.Windows.Forms.TextBox();
            this.d10output = new System.Windows.Forms.TextBox();
            this.d12output = new System.Windows.Forms.TextBox();
            this.d20output = new System.Windows.Forms.TextBox();
            this.d100output = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rounds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnd4
            // 
            this.btnd4.Location = new System.Drawing.Point(13, 13);
            this.btnd4.Name = "btnd4";
            this.btnd4.Size = new System.Drawing.Size(63, 40);
            this.btnd4.TabIndex = 0;
            this.btnd4.Text = "D4";
            this.btnd4.UseVisualStyleBackColor = true;
            this.btnd4.Click += new System.EventHandler(this.btnd4_Click);
            // 
            // btnd6
            // 
            this.btnd6.Location = new System.Drawing.Point(82, 13);
            this.btnd6.Name = "btnd6";
            this.btnd6.Size = new System.Drawing.Size(63, 40);
            this.btnd6.TabIndex = 1;
            this.btnd6.Text = "D6";
            this.btnd6.UseVisualStyleBackColor = true;
            this.btnd6.Click += new System.EventHandler(this.btnd6_Click);
            // 
            // btnd8
            // 
            this.btnd8.Location = new System.Drawing.Point(151, 13);
            this.btnd8.Name = "btnd8";
            this.btnd8.Size = new System.Drawing.Size(63, 40);
            this.btnd8.TabIndex = 2;
            this.btnd8.Text = "D8";
            this.btnd8.UseVisualStyleBackColor = true;
            this.btnd8.Click += new System.EventHandler(this.btnd8_Click);
            // 
            // btnd10
            // 
            this.btnd10.Location = new System.Drawing.Point(220, 13);
            this.btnd10.Name = "btnd10";
            this.btnd10.Size = new System.Drawing.Size(63, 40);
            this.btnd10.TabIndex = 3;
            this.btnd10.Text = "D10";
            this.btnd10.UseVisualStyleBackColor = true;
            this.btnd10.Click += new System.EventHandler(this.btnd10_Click);
            // 
            // btnd12
            // 
            this.btnd12.Location = new System.Drawing.Point(289, 13);
            this.btnd12.Name = "btnd12";
            this.btnd12.Size = new System.Drawing.Size(63, 40);
            this.btnd12.TabIndex = 4;
            this.btnd12.Text = "D12";
            this.btnd12.UseVisualStyleBackColor = true;
            this.btnd12.Click += new System.EventHandler(this.btnd12_Click);
            // 
            // btnd20
            // 
            this.btnd20.Location = new System.Drawing.Point(358, 13);
            this.btnd20.Name = "btnd20";
            this.btnd20.Size = new System.Drawing.Size(63, 40);
            this.btnd20.TabIndex = 5;
            this.btnd20.Text = "D20";
            this.btnd20.UseVisualStyleBackColor = true;
            this.btnd20.Click += new System.EventHandler(this.btnd20_Click);
            // 
            // btnd100
            // 
            this.btnd100.Location = new System.Drawing.Point(427, 13);
            this.btnd100.Name = "btnd100";
            this.btnd100.Size = new System.Drawing.Size(63, 40);
            this.btnd100.TabIndex = 6;
            this.btnd100.Text = "D100";
            this.btnd100.UseVisualStyleBackColor = true;
            this.btnd100.Click += new System.EventHandler(this.btnd100_Click);
            // 
            // Rounds
            // 
            this.Rounds.Location = new System.Drawing.Point(496, 31);
            this.Rounds.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.Rounds.Name = "Rounds";
            this.Rounds.Size = new System.Drawing.Size(122, 22);
            this.Rounds.TabIndex = 7;
            this.Rounds.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Rolls";
            // 
            // d4output
            // 
            this.d4output.Location = new System.Drawing.Point(12, 59);
            this.d4output.Multiline = true;
            this.d4output.Name = "d4output";
            this.d4output.ReadOnly = true;
            this.d4output.Size = new System.Drawing.Size(63, 142);
            this.d4output.TabIndex = 11;
            // 
            // d6output
            // 
            this.d6output.Location = new System.Drawing.Point(82, 59);
            this.d6output.Multiline = true;
            this.d6output.Name = "d6output";
            this.d6output.ReadOnly = true;
            this.d6output.Size = new System.Drawing.Size(63, 142);
            this.d6output.TabIndex = 12;
            // 
            // d8output
            // 
            this.d8output.Location = new System.Drawing.Point(151, 59);
            this.d8output.Multiline = true;
            this.d8output.Name = "d8output";
            this.d8output.ReadOnly = true;
            this.d8output.Size = new System.Drawing.Size(63, 142);
            this.d8output.TabIndex = 13;
            // 
            // d10output
            // 
            this.d10output.Location = new System.Drawing.Point(220, 59);
            this.d10output.Multiline = true;
            this.d10output.Name = "d10output";
            this.d10output.ReadOnly = true;
            this.d10output.Size = new System.Drawing.Size(63, 142);
            this.d10output.TabIndex = 14;
            // 
            // d12output
            // 
            this.d12output.Location = new System.Drawing.Point(289, 59);
            this.d12output.Multiline = true;
            this.d12output.Name = "d12output";
            this.d12output.ReadOnly = true;
            this.d12output.Size = new System.Drawing.Size(63, 142);
            this.d12output.TabIndex = 15;
            // 
            // d20output
            // 
            this.d20output.Location = new System.Drawing.Point(358, 59);
            this.d20output.Multiline = true;
            this.d20output.Name = "d20output";
            this.d20output.ReadOnly = true;
            this.d20output.Size = new System.Drawing.Size(63, 142);
            this.d20output.TabIndex = 16;
            // 
            // d100output
            // 
            this.d100output.Location = new System.Drawing.Point(427, 59);
            this.d100output.Multiline = true;
            this.d100output.Name = "d100output";
            this.d100output.ReadOnly = true;
            this.d100output.Size = new System.Drawing.Size(63, 142);
            this.d100output.TabIndex = 17;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(496, 60);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(110, 53);
            this.btnAll.TabIndex = 18;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 214);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.d100output);
            this.Controls.Add(this.d20output);
            this.Controls.Add(this.d12output);
            this.Controls.Add(this.d10output);
            this.Controls.Add(this.d8output);
            this.Controls.Add(this.d6output);
            this.Controls.Add(this.d4output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rounds);
            this.Controls.Add(this.btnd100);
            this.Controls.Add(this.btnd20);
            this.Controls.Add(this.btnd12);
            this.Controls.Add(this.btnd10);
            this.Controls.Add(this.btnd8);
            this.Controls.Add(this.btnd6);
            this.Controls.Add(this.btnd4);
            this.Name = "Form1";
            this.Text = "Averages";
            ((System.ComponentModel.ISupportInitialize)(this.Rounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnd4;
        private System.Windows.Forms.Button btnd6;
        private System.Windows.Forms.Button btnd8;
        private System.Windows.Forms.Button btnd10;
        private System.Windows.Forms.Button btnd12;
        private System.Windows.Forms.Button btnd20;
        private System.Windows.Forms.Button btnd100;
        private System.Windows.Forms.NumericUpDown Rounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox d4output;
        private System.Windows.Forms.TextBox d6output;
        private System.Windows.Forms.TextBox d8output;
        private System.Windows.Forms.TextBox d10output;
        private System.Windows.Forms.TextBox d12output;
        private System.Windows.Forms.TextBox d20output;
        private System.Windows.Forms.TextBox d100output;
        private System.Windows.Forms.Button btnAll;
    }
}

