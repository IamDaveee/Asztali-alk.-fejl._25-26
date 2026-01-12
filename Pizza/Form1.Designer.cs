
namespace Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSzámol = new System.Windows.Forms.Button();
            this.btnTöröl = new System.Windows.Forms.Button();
            this.btnKilép = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbVegan = new System.Windows.Forms.CheckBox();
            this.chkbMagyar = new System.Windows.Forms.CheckBox();
            this.chkbNegysajt = new System.Windows.Forms.CheckBox();
            this.chkbSonka = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb1_1 = new System.Windows.Forms.RadioButton();
            this.rb1_2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb2_2 = new System.Windows.Forms.RadioButton();
            this.rb2_1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb3_1 = new System.Windows.Forms.RadioButton();
            this.rb3_2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb4_1 = new System.Windows.Forms.RadioButton();
            this.rb4_2 = new System.Windows.Forms.RadioButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txtÖsszegSum = new System.Windows.Forms.TextBox();
            this.txtDarabSum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 253);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSzámol
            // 
            this.btnSzámol.Location = new System.Drawing.Point(13, 272);
            this.btnSzámol.Name = "btnSzámol";
            this.btnSzámol.Size = new System.Drawing.Size(94, 23);
            this.btnSzámol.TabIndex = 1;
            this.btnSzámol.Text = "Számol";
            this.btnSzámol.UseVisualStyleBackColor = true;
            this.btnSzámol.Click += new System.EventHandler(this.btnSzámol_Click);
            // 
            // btnTöröl
            // 
            this.btnTöröl.Location = new System.Drawing.Point(12, 301);
            this.btnTöröl.Name = "btnTöröl";
            this.btnTöröl.Size = new System.Drawing.Size(94, 23);
            this.btnTöröl.TabIndex = 2;
            this.btnTöröl.Text = "Töröl";
            this.btnTöröl.UseVisualStyleBackColor = true;
            this.btnTöröl.Click += new System.EventHandler(this.btnTöröl_Click);
            // 
            // btnKilép
            // 
            this.btnKilép.Location = new System.Drawing.Point(12, 330);
            this.btnKilép.Name = "btnKilép";
            this.btnKilép.Size = new System.Drawing.Size(94, 23);
            this.btnKilép.TabIndex = 3;
            this.btnKilép.Text = "Kilép";
            this.btnKilép.UseVisualStyleBackColor = true;
            this.btnKilép.Click += new System.EventHandler(this.btnKilép_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(416, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menüválaszték";
            // 
            // chkbVegan
            // 
            this.chkbVegan.AutoSize = true;
            this.chkbVegan.Location = new System.Drawing.Point(269, 88);
            this.chkbVegan.Name = "chkbVegan";
            this.chkbVegan.Size = new System.Drawing.Size(88, 17);
            this.chkbVegan.TabIndex = 5;
            this.chkbVegan.Text = "Vegetáriánus";
            this.chkbVegan.UseVisualStyleBackColor = true;
            this.chkbVegan.CheckedChanged += new System.EventHandler(this.chkbVegan_CheckedChanged);
            // 
            // chkbMagyar
            // 
            this.chkbMagyar.AutoSize = true;
            this.chkbMagyar.Location = new System.Drawing.Point(269, 137);
            this.chkbMagyar.Name = "chkbMagyar";
            this.chkbMagyar.Size = new System.Drawing.Size(72, 17);
            this.chkbMagyar.TabIndex = 6;
            this.chkbMagyar.Text = "Magyaros";
            this.chkbMagyar.UseVisualStyleBackColor = true;
            this.chkbMagyar.CheckedChanged += new System.EventHandler(this.chkbMagyar_CheckedChanged);
            // 
            // chkbNegysajt
            // 
            this.chkbNegysajt.AutoSize = true;
            this.chkbNegysajt.Location = new System.Drawing.Point(269, 196);
            this.chkbNegysajt.Name = "chkbNegysajt";
            this.chkbNegysajt.Size = new System.Drawing.Size(78, 17);
            this.chkbNegysajt.TabIndex = 7;
            this.chkbNegysajt.Text = "Négysajtos";
            this.chkbNegysajt.UseVisualStyleBackColor = true;
            this.chkbNegysajt.CheckedChanged += new System.EventHandler(this.chkbNegysajt_CheckedChanged);
            // 
            // chkbSonka
            // 
            this.chkbSonka.AutoSize = true;
            this.chkbSonka.Location = new System.Drawing.Point(269, 250);
            this.chkbSonka.Name = "chkbSonka";
            this.chkbSonka.Size = new System.Drawing.Size(94, 17);
            this.chkbSonka.TabIndex = 8;
            this.chkbSonka.Text = "Sonka-Gomba";
            this.chkbSonka.UseVisualStyleBackColor = true;
            this.chkbSonka.CheckedChanged += new System.EventHandler(this.chkbSonka_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kicsi (30 cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nagy (45 cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mennyiség (db)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb1_2);
            this.groupBox1.Controls.Add(this.rb1_1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(414, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 36);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rb1_1
            // 
            this.rb1_1.AutoSize = true;
            this.rb1_1.Location = new System.Drawing.Point(9, 9);
            this.rb1_1.Name = "rb1_1";
            this.rb1_1.Size = new System.Drawing.Size(61, 17);
            this.rb1_1.TabIndex = 0;
            this.rb1_1.Text = "2690 Ft";
            this.rb1_1.UseVisualStyleBackColor = true;
            // 
            // rb1_2
            // 
            this.rb1_2.AutoSize = true;
            this.rb1_2.Location = new System.Drawing.Point(102, 9);
            this.rb1_2.Name = "rb1_2";
            this.rb1_2.Size = new System.Drawing.Size(61, 17);
            this.rb1_2.TabIndex = 1;
            this.rb1_2.Text = "3650 Ft";
            this.rb1_2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb3_2);
            this.groupBox4.Controls.Add(this.rb3_1);
            this.groupBox4.Location = new System.Drawing.Point(414, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 55);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // rb2_2
            // 
            this.rb2_2.AutoSize = true;
            this.rb2_2.Location = new System.Drawing.Point(102, 16);
            this.rb2_2.Name = "rb2_2";
            this.rb2_2.Size = new System.Drawing.Size(61, 17);
            this.rb2_2.TabIndex = 1;
            this.rb2_2.Text = "4890 Ft";
            this.rb2_2.UseVisualStyleBackColor = true;
            // 
            // rb2_1
            // 
            this.rb2_1.AutoSize = true;
            this.rb2_1.Location = new System.Drawing.Point(9, 16);
            this.rb2_1.Name = "rb2_1";
            this.rb2_1.Size = new System.Drawing.Size(61, 17);
            this.rb2_1.TabIndex = 0;
            this.rb2_1.Text = "2895 Ft";
            this.rb2_1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb2_2);
            this.groupBox3.Controls.Add(this.rb2_1);
            this.groupBox3.Location = new System.Drawing.Point(414, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 48);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // rb3_1
            // 
            this.rb3_1.AutoSize = true;
            this.rb3_1.Location = new System.Drawing.Point(9, 21);
            this.rb3_1.Name = "rb3_1";
            this.rb3_1.Size = new System.Drawing.Size(61, 17);
            this.rb3_1.TabIndex = 0;
            this.rb3_1.Text = "2790 Ft";
            this.rb3_1.UseVisualStyleBackColor = true;
            // 
            // rb3_2
            // 
            this.rb3_2.AutoSize = true;
            this.rb3_2.Location = new System.Drawing.Point(102, 21);
            this.rb3_2.Name = "rb3_2";
            this.rb3_2.Size = new System.Drawing.Size(61, 17);
            this.rb3_2.TabIndex = 1;
            this.rb3_2.Text = "4790 Ft";
            this.rb3_2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb4_2);
            this.groupBox2.Controls.Add(this.rb4_1);
            this.groupBox2.Location = new System.Drawing.Point(414, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 51);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // rb4_1
            // 
            this.rb4_1.AutoSize = true;
            this.rb4_1.Location = new System.Drawing.Point(9, 14);
            this.rb4_1.Name = "rb4_1";
            this.rb4_1.Size = new System.Drawing.Size(61, 17);
            this.rb4_1.TabIndex = 0;
            this.rb4_1.Text = "2450 Ft";
            this.rb4_1.UseVisualStyleBackColor = true;
            // 
            // rb4_2
            // 
            this.rb4_2.AutoSize = true;
            this.rb4_2.Location = new System.Drawing.Point(102, 14);
            this.rb4_2.Name = "rb4_2";
            this.rb4_2.Size = new System.Drawing.Size(61, 17);
            this.rb4_2.TabIndex = 1;
            this.rb4_2.Text = "3990 Ft";
            this.rb4_2.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(645, 86);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(50, 20);
            this.txt1.TabIndex = 16;
            this.txt1.Text = "0";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(645, 135);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(50, 20);
            this.txt2.TabIndex = 17;
            this.txt2.Text = "0";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(645, 194);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(50, 20);
            this.txt3.TabIndex = 18;
            this.txt3.Text = "0";
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(645, 248);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(50, 20);
            this.txt4.TabIndex = 19;
            this.txt4.Text = "0";
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtÖsszegSum
            // 
            this.txtÖsszegSum.Location = new System.Drawing.Point(414, 303);
            this.txtÖsszegSum.Name = "txtÖsszegSum";
            this.txtÖsszegSum.Size = new System.Drawing.Size(200, 20);
            this.txtÖsszegSum.TabIndex = 20;
            this.txtÖsszegSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDarabSum
            // 
            this.txtDarabSum.Enabled = false;
            this.txtDarabSum.Location = new System.Drawing.Point(645, 303);
            this.txtDarabSum.Name = "txtDarabSum";
            this.txtDarabSum.ReadOnly = true;
            this.txtDarabSum.Size = new System.Drawing.Size(50, 20);
            this.txtDarabSum.TabIndex = 21;
            this.txtDarabSum.Text = "0";
            this.txtDarabSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fizetendő:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDarabSum);
            this.Controls.Add(this.txtÖsszegSum);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkbSonka);
            this.Controls.Add(this.chkbNegysajt);
            this.Controls.Add(this.chkbMagyar);
            this.Controls.Add(this.chkbVegan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKilép);
            this.Controls.Add(this.btnTöröl);
            this.Controls.Add(this.btnSzámol);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSzámol;
        private System.Windows.Forms.Button btnTöröl;
        private System.Windows.Forms.Button btnKilép;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbVegan;
        private System.Windows.Forms.CheckBox chkbMagyar;
        private System.Windows.Forms.CheckBox chkbNegysajt;
        private System.Windows.Forms.CheckBox chkbSonka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb1_2;
        private System.Windows.Forms.RadioButton rb1_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb3_2;
        private System.Windows.Forms.RadioButton rb3_1;
        private System.Windows.Forms.RadioButton rb2_2;
        private System.Windows.Forms.RadioButton rb2_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb4_2;
        private System.Windows.Forms.RadioButton rb4_1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txtÖsszegSum;
        private System.Windows.Forms.TextBox txtDarabSum;
        private System.Windows.Forms.Label label5;
    }
}

