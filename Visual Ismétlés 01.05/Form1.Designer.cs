
namespace Visual_Ismétlés_01._05
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
            this.lblSzoveg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbKor = new System.Windows.Forms.RadioButton();
            this.rdbNegyzet = new System.Windows.Forms.RadioButton();
            this.txtSugar = new System.Windows.Forms.TextBox();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblKerület = new System.Windows.Forms.Label();
            this.lblTerület = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbLNKO = new System.Windows.Forms.RadioButton();
            this.rdbLKKT = new System.Windows.Forms.RadioButton();
            this.btnRekurziv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.AutoSize = true;
            this.lblSzoveg.Location = new System.Drawing.Point(353, 52);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(35, 13);
            this.lblSzoveg.TabIndex = 0;
            this.lblSzoveg.Text = "label1";
            this.lblSzoveg.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNegyzet);
            this.groupBox1.Controls.Add(this.rdbKor);
            this.groupBox1.Location = new System.Drawing.Point(277, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kör vagy Négyzet?";
            // 
            // rdbKor
            // 
            this.rdbKor.AutoSize = true;
            this.rdbKor.Location = new System.Drawing.Point(24, 49);
            this.rdbKor.Name = "rdbKor";
            this.rdbKor.Size = new System.Drawing.Size(41, 17);
            this.rdbKor.TabIndex = 0;
            this.rdbKor.TabStop = true;
            this.rdbKor.Text = "Kör";
            this.rdbKor.UseVisualStyleBackColor = true;
            // 
            // rdbNegyzet
            // 
            this.rdbNegyzet.AutoSize = true;
            this.rdbNegyzet.Location = new System.Drawing.Point(103, 49);
            this.rdbNegyzet.Name = "rdbNegyzet";
            this.rdbNegyzet.Size = new System.Drawing.Size(64, 17);
            this.rdbNegyzet.TabIndex = 1;
            this.rdbNegyzet.TabStop = true;
            this.rdbNegyzet.Text = "Négyzet";
            this.rdbNegyzet.UseVisualStyleBackColor = true;
            // 
            // txtSugar
            // 
            this.txtSugar.Location = new System.Drawing.Point(277, 219);
            this.txtSugar.Name = "txtSugar";
            this.txtSugar.Size = new System.Drawing.Size(100, 20);
            this.txtSugar.TabIndex = 2;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(277, 254);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 3;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(767, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblKerület
            // 
            this.lblKerület.AutoSize = true;
            this.lblKerület.Location = new System.Drawing.Point(277, 297);
            this.lblKerület.Name = "lblKerület";
            this.lblKerület.Size = new System.Drawing.Size(0, 13);
            this.lblKerület.TabIndex = 5;
            // 
            // lblTerület
            // 
            this.lblTerület.AutoSize = true;
            this.lblTerület.Location = new System.Drawing.Point(277, 325);
            this.lblTerület.Name = "lblTerület";
            this.lblTerület.Size = new System.Drawing.Size(0, 13);
            this.lblTerület.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "b";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(636, 68);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 9;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(636, 139);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLKKT);
            this.groupBox2.Controls.Add(this.rdbLNKO);
            this.groupBox2.Location = new System.Drawing.Point(588, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LNKO / LKKT";
            // 
            // rdbLNKO
            // 
            this.rdbLNKO.AutoSize = true;
            this.rdbLNKO.Location = new System.Drawing.Point(7, 44);
            this.rdbLNKO.Name = "rdbLNKO";
            this.rdbLNKO.Size = new System.Drawing.Size(54, 17);
            this.rdbLNKO.TabIndex = 0;
            this.rdbLNKO.TabStop = true;
            this.rdbLNKO.Text = "LNKO";
            this.rdbLNKO.UseVisualStyleBackColor = true;
            this.rdbLNKO.CheckedChanged += new System.EventHandler(this.rdbLNKO_CheckedChanged);
            // 
            // rdbLKKT
            // 
            this.rdbLKKT.AutoSize = true;
            this.rdbLKKT.Location = new System.Drawing.Point(110, 44);
            this.rdbLKKT.Name = "rdbLKKT";
            this.rdbLKKT.Size = new System.Drawing.Size(52, 17);
            this.rdbLKKT.TabIndex = 1;
            this.rdbLKKT.TabStop = true;
            this.rdbLKKT.Text = "LKKT";
            this.rdbLKKT.UseVisualStyleBackColor = true;
            // 
            // btnRekurziv
            // 
            this.btnRekurziv.Location = new System.Drawing.Point(647, 283);
            this.btnRekurziv.Name = "btnRekurziv";
            this.btnRekurziv.Size = new System.Drawing.Size(75, 23);
            this.btnRekurziv.TabIndex = 12;
            this.btnRekurziv.Text = "Rekurziv";
            this.btnRekurziv.UseVisualStyleBackColor = true;
            this.btnRekurziv.Click += new System.EventHandler(this.btnRekurziv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRekurziv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTerület);
            this.Controls.Add(this.lblKerület);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.txtSugar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSzoveg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSzoveg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNegyzet;
        private System.Windows.Forms.RadioButton rdbKor;
        private System.Windows.Forms.TextBox txtSugar;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblKerület;
        private System.Windows.Forms.Label lblTerület;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbLKKT;
        private System.Windows.Forms.RadioButton rdbLNKO;
        private System.Windows.Forms.Button btnRekurziv;
    }
}

