
namespace Grafikus_Gyak
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVezetek = new System.Windows.Forms.TextBox();
            this.TxtKereszt = new System.Windows.Forms.TextBox();
            this.btnNev = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPow = new System.Windows.Forms.Label();
            this.lblGyok = new System.Windows.Forms.Label();
            this.lblAbs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(321, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gyakorlás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vezetéknév";
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(385, 151);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(35, 13);
            this.lblNev.TabIndex = 2;
            this.lblNev.Text = "label3";
            this.lblNev.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Keresztnév";
            // 
            // TxtVezetek
            // 
            this.TxtVezetek.Location = new System.Drawing.Point(75, 148);
            this.TxtVezetek.Name = "TxtVezetek";
            this.TxtVezetek.Size = new System.Drawing.Size(100, 20);
            this.TxtVezetek.TabIndex = 4;
            // 
            // TxtKereszt
            // 
            this.TxtKereszt.Location = new System.Drawing.Point(218, 148);
            this.TxtKereszt.Name = "TxtKereszt";
            this.TxtKereszt.Size = new System.Drawing.Size(100, 20);
            this.TxtKereszt.TabIndex = 5;
            // 
            // btnNev
            // 
            this.btnNev.Location = new System.Drawing.Point(140, 184);
            this.btnNev.Name = "btnNev";
            this.btnNev.Size = new System.Drawing.Size(112, 23);
            this.btnNev.TabIndex = 6;
            this.btnNev.Text = "Név megjelenítése";
            this.btnNev.UseVisualStyleBackColor = true;
            this.btnNev.Click += new System.EventHandler(this.btnNev_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(772, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adjon meg egy számot: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(215, 251);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 11;
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(388, 253);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 12;
            this.lblNumber.Text = "label5";
            this.lblNumber.Visible = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(115, 408);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Számol";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "A szám négyzete: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "A szám gyöke: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "A szám abszolút értéke: ";
            // 
            // lblPow
            // 
            this.lblPow.AutoSize = true;
            this.lblPow.Location = new System.Drawing.Point(246, 313);
            this.lblPow.Name = "lblPow";
            this.lblPow.Size = new System.Drawing.Size(35, 13);
            this.lblPow.TabIndex = 17;
            this.lblPow.Text = "label8";
            this.lblPow.Visible = false;
            // 
            // lblGyok
            // 
            this.lblGyok.AutoSize = true;
            this.lblGyok.Location = new System.Drawing.Point(246, 344);
            this.lblGyok.Name = "lblGyok";
            this.lblGyok.Size = new System.Drawing.Size(35, 13);
            this.lblGyok.TabIndex = 18;
            this.lblGyok.Text = "label9";
            this.lblGyok.Visible = false;
            // 
            // lblAbs
            // 
            this.lblAbs.AutoSize = true;
            this.lblAbs.Location = new System.Drawing.Point(249, 376);
            this.lblAbs.Name = "lblAbs";
            this.lblAbs.Size = new System.Drawing.Size(41, 13);
            this.lblAbs.TabIndex = 19;
            this.lblAbs.Text = "label10";
            this.lblAbs.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAbs);
            this.Controls.Add(this.lblGyok);
            this.Controls.Add(this.lblPow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNev);
            this.Controls.Add(this.TxtKereszt);
            this.Controls.Add(this.TxtVezetek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVezetek;
        private System.Windows.Forms.TextBox TxtKereszt;
        private System.Windows.Forms.Button btnNev;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPow;
        private System.Windows.Forms.Label lblGyok;
        private System.Windows.Forms.Label lblAbs;
    }
}

