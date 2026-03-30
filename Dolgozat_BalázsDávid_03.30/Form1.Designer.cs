
namespace Dolgozat_BalázsDávid_03._30
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNewLoad = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lb_adatok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtVaros = new System.Windows.Forms.TextBox();
            this.txtNepesseg = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFelett = new System.Windows.Forms.RadioButton();
            this.rbAlatt = new System.Windows.Forms.RadioButton();
            this.chkStat = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(28, 26);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Megnyitás";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNewLoad
            // 
            this.btnNewLoad.Location = new System.Drawing.Point(148, 26);
            this.btnNewLoad.Name = "btnNewLoad";
            this.btnNewLoad.Size = new System.Drawing.Size(107, 23);
            this.btnNewLoad.TabIndex = 1;
            this.btnNewLoad.Text = "Új adat felvitele";
            this.btnNewLoad.UseVisualStyleBackColor = true;
            this.btnNewLoad.Click += new System.EventHandler(this.btnNewLoad_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(291, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Felvitel";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lb_adatok
            // 
            this.lb_adatok.FormattingEnabled = true;
            this.lb_adatok.Location = new System.Drawing.Point(28, 76);
            this.lb_adatok.Name = "lb_adatok";
            this.lb_adatok.Size = new System.Drawing.Size(120, 316);
            this.lb_adatok.TabIndex = 3;
            this.lb_adatok.SelectedIndexChanged += new System.EventHandler(this.lb_adatok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ország:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Város:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Népesség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "millió fő";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(309, 73);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 9;
            this.txtOrszag.TextChanged += new System.EventHandler(this.txtOrszag_TextChanged);
            // 
            // txtVaros
            // 
            this.txtVaros.Location = new System.Drawing.Point(309, 98);
            this.txtVaros.Name = "txtVaros";
            this.txtVaros.Size = new System.Drawing.Size(100, 20);
            this.txtVaros.TabIndex = 10;
            this.txtVaros.TextChanged += new System.EventHandler(this.txtVaros_TextChanged);
            // 
            // txtNepesseg
            // 
            this.txtNepesseg.Location = new System.Drawing.Point(309, 125);
            this.txtNepesseg.Name = "txtNepesseg";
            this.txtNepesseg.Size = new System.Drawing.Size(100, 20);
            this.txtNepesseg.TabIndex = 11;
            this.txtNepesseg.TextChanged += new System.EventHandler(this.txtNepesseg_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAlatt);
            this.groupBox1.Controls.Add(this.rbFelett);
            this.groupBox1.Location = new System.Drawing.Point(245, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nagyvárosok";
            // 
            // rbFelett
            // 
            this.rbFelett.AutoSize = true;
            this.rbFelett.Location = new System.Drawing.Point(6, 34);
            this.rbFelett.Name = "rbFelett";
            this.rbFelett.Size = new System.Drawing.Size(131, 17);
            this.rbFelett.TabIndex = 0;
            this.rbFelett.TabStop = true;
            this.rbFelett.Text = "10 millió feletti városok";
            this.rbFelett.UseVisualStyleBackColor = true;
            this.rbFelett.CheckedChanged += new System.EventHandler(this.rbFelett_CheckedChanged);
            // 
            // rbAlatt
            // 
            this.rbAlatt.AutoSize = true;
            this.rbAlatt.Location = new System.Drawing.Point(6, 68);
            this.rbAlatt.Name = "rbAlatt";
            this.rbAlatt.Size = new System.Drawing.Size(128, 17);
            this.rbAlatt.TabIndex = 1;
            this.rbAlatt.TabStop = true;
            this.rbAlatt.Text = "10 millió alatti városok";
            this.rbAlatt.UseVisualStyleBackColor = true;
            this.rbAlatt.CheckedChanged += new System.EventHandler(this.rbAlatt_CheckedChanged);
            // 
            // chkStat
            // 
            this.chkStat.AutoSize = true;
            this.chkStat.Location = new System.Drawing.Point(245, 375);
            this.chkStat.Name = "chkStat";
            this.chkStat.Size = new System.Drawing.Size(74, 17);
            this.chkStat.TabIndex = 2;
            this.chkStat.Text = "Statisztika";
            this.chkStat.UseVisualStyleBackColor = true;
            this.chkStat.CheckedChanged += new System.EventHandler(this.chkStat_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(375, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkStat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNepesseg);
            this.Controls.Add(this.txtVaros);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_adatok);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNewLoad);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Balázs Dávid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNewLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lb_adatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtVaros;
        private System.Windows.Forms.TextBox txtNepesseg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAlatt;
        private System.Windows.Forms.RadioButton rbFelett;
        private System.Windows.Forms.CheckBox chkStat;
        private System.Windows.Forms.Button btnExit;
    }
}

