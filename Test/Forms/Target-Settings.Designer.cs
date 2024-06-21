namespace MissileControl.Forms
{
    partial class Zielerkennung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RotBoxU = new System.Windows.Forms.TextBox();
			this.GruenBoxU = new System.Windows.Forms.TextBox();
			this.BlauBoxU = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BlauBoxO = new System.Windows.Forms.TextBox();
			this.GruenBoxO = new System.Windows.Forms.TextBox();
			this.RotBoxO = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 26);
			this.button1.TabIndex = 1;
			this.button1.Text = "Choose color";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new System.Drawing.Point(180, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(185, 20);
			this.panel1.TabIndex = 2;
			// 
			// RotBoxU
			// 
			this.RotBoxU.Location = new System.Drawing.Point(9, 32);
			this.RotBoxU.Name = "RotBoxU";
			this.RotBoxU.ReadOnly = true;
			this.RotBoxU.Size = new System.Drawing.Size(51, 20);
			this.RotBoxU.TabIndex = 3;
			// 
			// GruenBoxU
			// 
			this.GruenBoxU.Location = new System.Drawing.Point(66, 32);
			this.GruenBoxU.Name = "GruenBoxU";
			this.GruenBoxU.ReadOnly = true;
			this.GruenBoxU.Size = new System.Drawing.Size(51, 20);
			this.GruenBoxU.TabIndex = 4;
			// 
			// BlauBoxU
			// 
			this.BlauBoxU.Location = new System.Drawing.Point(123, 32);
			this.BlauBoxU.Name = "BlauBoxU";
			this.BlauBoxU.ReadOnly = true;
			this.BlauBoxU.Size = new System.Drawing.Size(51, 20);
			this.BlauBoxU.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Red";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Green";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(120, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Blue";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.RotBoxU);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BlauBoxU);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.GruenBoxU);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 108);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lower color limit";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(177, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Color";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.BlauBoxO);
			this.groupBox2.Controls.Add(this.GruenBoxO);
			this.groupBox2.Controls.Add(this.RotBoxO);
			this.groupBox2.Location = new System.Drawing.Point(12, 142);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(371, 108);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Upper color limit";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 26);
			this.button2.TabIndex = 10;
			this.button2.Text = "Choose color";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(177, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Color";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Location = new System.Drawing.Point(180, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(185, 20);
			this.panel2.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(120, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Blue";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Green";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Red";
			// 
			// BlauBoxO
			// 
			this.BlauBoxO.Location = new System.Drawing.Point(123, 36);
			this.BlauBoxO.Name = "BlauBoxO";
			this.BlauBoxO.ReadOnly = true;
			this.BlauBoxO.Size = new System.Drawing.Size(51, 20);
			this.BlauBoxO.TabIndex = 2;
			// 
			// GruenBoxO
			// 
			this.GruenBoxO.Location = new System.Drawing.Point(66, 36);
			this.GruenBoxO.Name = "GruenBoxO";
			this.GruenBoxO.ReadOnly = true;
			this.GruenBoxO.Size = new System.Drawing.Size(51, 20);
			this.GruenBoxO.TabIndex = 1;
			// 
			// RotBoxO
			// 
			this.RotBoxO.Location = new System.Drawing.Point(9, 36);
			this.RotBoxO.Name = "RotBoxO";
			this.RotBoxO.ReadOnly = true;
			this.RotBoxO.Size = new System.Drawing.Size(51, 20);
			this.RotBoxO.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 259);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 26);
			this.button3.TabIndex = 11;
			this.button3.Text = "Accept";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Zielerkennung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 291);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Zielerkennung";
			this.Text = "Target tagging";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        void button3_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        void button2_Click(object sender, System.EventArgs e)
        {
            colorDialog1.Color = ZielfarbeO;
            colorDialog1.ShowDialog();
            ZielfarbeO = colorDialog1.Color;
            panel2.BackColor = ZielfarbeO;
            RotBoxO.Text = ZielfarbeO.R.ToString();
            GruenBoxO.Text = ZielfarbeO.G.ToString();
            BlauBoxO.Text = ZielfarbeO.B.ToString();
        }

        void button1_Click(object sender, System.EventArgs e)
        {
            colorDialog1.Color = ZielfarbeU;
            colorDialog1.ShowDialog();
            ZielfarbeU = colorDialog1.Color;
            panel1.BackColor = ZielfarbeU;
            RotBoxU.Text = ZielfarbeU.R.ToString();
            GruenBoxU.Text = ZielfarbeU.G.ToString();
            BlauBoxU.Text = ZielfarbeU.B.ToString();
        }

        #endregion

        public void GetColor(out System.Drawing.Color U,
                      out System.Drawing.Color O)
        {
            U = this.ZielfarbeU;
            O = this.ZielfarbeO;
        }

        public void SetColor(System.Drawing.Color U,
                             System.Drawing.Color O)
        {
            this.ZielfarbeU = U;
            this.ZielfarbeO = O;

            panel1.BackColor = ZielfarbeU;
            RotBoxU.Text = ZielfarbeU.R.ToString();
            GruenBoxU.Text = ZielfarbeU.G.ToString();
            BlauBoxU.Text = ZielfarbeU.B.ToString();

            panel2.BackColor = ZielfarbeO;
            RotBoxO.Text = ZielfarbeO.R.ToString();
            GruenBoxO.Text = ZielfarbeO.G.ToString();
            BlauBoxO.Text = ZielfarbeO.B.ToString();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RotBoxU;
        private System.Windows.Forms.TextBox GruenBoxU;
        private System.Windows.Forms.TextBox BlauBoxU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Drawing.Color ZielfarbeU;
        private System.Drawing.Color ZielfarbeO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BlauBoxO;
        private System.Windows.Forms.TextBox GruenBoxO;
        private System.Windows.Forms.TextBox RotBoxO;
        private System.Windows.Forms.Button button3;
    }
}