namespace MyCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelruselt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OP2 = new System.Windows.Forms.TextBox();
            this.OP1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonequal = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.buttonmul = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(48, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 524);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelruselt);
            this.panel4.Location = new System.Drawing.Point(32, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 82);
            this.panel4.TabIndex = 3;
            // 
            // labelruselt
            // 
            this.labelruselt.AutoSize = true;
            this.labelruselt.Location = new System.Drawing.Point(23, 26);
            this.labelruselt.Name = "labelruselt";
            this.labelruselt.Size = new System.Drawing.Size(53, 20);
            this.labelruselt.TabIndex = 0;
            this.labelruselt.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OP2);
            this.panel2.Controls.Add(this.OP1);
            this.panel2.Location = new System.Drawing.Point(32, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 172);
            this.panel2.TabIndex = 2;
            // 
            // OP2
            // 
            this.OP2.Location = new System.Drawing.Point(52, 97);
            this.OP2.Name = "OP2";
            this.OP2.Size = new System.Drawing.Size(297, 27);
            this.OP2.TabIndex = 1;
            this.OP2.TextChanged += new System.EventHandler(this.OP2_TextChanged);
            // 
            // OP1
            // 
            this.OP1.Location = new System.Drawing.Point(52, 39);
            this.OP1.Name = "OP1";
            this.OP1.Size = new System.Drawing.Size(297, 27);
            this.OP1.TabIndex = 0;
            this.OP1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonequal);
            this.panel3.Controls.Add(this.buttondiv);
            this.panel3.Controls.Add(this.buttonmul);
            this.panel3.Controls.Add(this.buttonsub);
            this.panel3.Controls.Add(this.buttonadd);
            this.panel3.Location = new System.Drawing.Point(598, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 369);
            this.panel3.TabIndex = 1;
            // 
            // buttonequal
            // 
            this.buttonequal.Location = new System.Drawing.Point(50, 317);
            this.buttonequal.Name = "buttonequal";
            this.buttonequal.Size = new System.Drawing.Size(85, 38);
            this.buttonequal.TabIndex = 4;
            this.buttonequal.Text = "=";
            this.buttonequal.UseVisualStyleBackColor = true;
            this.buttonequal.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Location = new System.Drawing.Point(50, 242);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(85, 45);
            this.buttondiv.TabIndex = 3;
            this.buttondiv.Text = "➗";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonmul
            // 
            this.buttonmul.Location = new System.Drawing.Point(50, 171);
            this.buttonmul.Name = "buttonmul";
            this.buttonmul.Size = new System.Drawing.Size(85, 46);
            this.buttonmul.TabIndex = 2;
            this.buttonmul.Text = "✖";
            this.buttonmul.UseVisualStyleBackColor = true;
            this.buttonmul.Click += new System.EventHandler(this.buttonmul_Click);
            // 
            // buttonsub
            // 
            this.buttonsub.Location = new System.Drawing.Point(50, 98);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(85, 45);
            this.buttonsub.TabIndex = 1;
            this.buttonsub.Text = "➖";
            this.buttonsub.UseVisualStyleBackColor = true;
            this.buttonsub.Click += new System.EventHandler(this.buttonsub_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(50, 31);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(85, 45);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "➕";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 548);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox OP2;
        private System.Windows.Forms.TextBox OP1;
        private System.Windows.Forms.Button buttonequal;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button buttonmul;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelruselt;
    }
}

