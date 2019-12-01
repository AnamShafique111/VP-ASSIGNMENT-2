namespace WindowsFormsApp23
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NAMEtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SEMtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CGPAtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DEPtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UNItextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 93);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(194, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Student Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your Name:";
            // 
            // NAMEtextBox
            // 
            this.NAMEtextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NAMEtextBox.Location = new System.Drawing.Point(266, 176);
            this.NAMEtextBox.Name = "NAMEtextBox";
            this.NAMEtextBox.Size = new System.Drawing.Size(289, 20);
            this.NAMEtextBox.TabIndex = 6;
            this.NAMEtextBox.TextChanged += new System.EventHandler(this.NAMEtextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter your Smester:";
            // 
            // SEMtextBox
            // 
            this.SEMtextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SEMtextBox.Location = new System.Drawing.Point(266, 242);
            this.SEMtextBox.Name = "SEMtextBox";
            this.SEMtextBox.Size = new System.Drawing.Size(289, 20);
            this.SEMtextBox.TabIndex = 8;
            this.SEMtextBox.TextChanged += new System.EventHandler(this.SEMtextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter your CGPA:";
            // 
            // CGPAtextBox
            // 
            this.CGPAtextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CGPAtextBox.Location = new System.Drawing.Point(266, 309);
            this.CGPAtextBox.Name = "CGPAtextBox";
            this.CGPAtextBox.Size = new System.Drawing.Size(289, 20);
            this.CGPAtextBox.TabIndex = 10;
            this.CGPAtextBox.TextChanged += new System.EventHandler(this.CGPAtextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter your Department:";
            // 
            // DEPtextBox
            // 
            this.DEPtextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DEPtextBox.Location = new System.Drawing.Point(266, 381);
            this.DEPtextBox.Name = "DEPtextBox";
            this.DEPtextBox.Size = new System.Drawing.Size(289, 20);
            this.DEPtextBox.TabIndex = 12;
            this.DEPtextBox.TextChanged += new System.EventHandler(this.DEPtextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter your University:";
            // 
            // UNItextBox
            // 
            this.UNItextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UNItextBox.Location = new System.Drawing.Point(266, 451);
            this.UNItextBox.Name = "UNItextBox";
            this.UNItextBox.Size = new System.Drawing.Size(289, 20);
            this.UNItextBox.TabIndex = 14;
            this.UNItextBox.TextChanged += new System.EventHandler(this.UNItextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(486, 498);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(69, 31);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IDtextBox.Location = new System.Drawing.Point(266, 109);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(289, 20);
            this.IDtextBox.TabIndex = 16;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(543, 554);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(69, 25);
            this.Exitbutton.TabIndex = 17;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(266, 498);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(69, 31);
            this.Clearbutton.TabIndex = 18;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(624, 591);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UNItextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DEPtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CGPAtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SEMtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NAMEtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NAMEtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SEMtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CGPAtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DEPtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UNItextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Clearbutton;
    }
}