
namespace Dolgozat_BalázsDávid_02._16
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbElemek = new System.Windows.Forms.ListBox();
            this.lbHarom = new System.Windows.Forms.ListBox();
            this.lbOt = new System.Windows.Forms.ListBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkbox1 = new System.Windows.Forms.CheckBox();
            this.chkbox2 = new System.Windows.Forms.CheckBox();
            this.chkbox3 = new System.Windows.Forms.CheckBox();
            this.combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(28, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 31);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Feltöltés";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(539, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Munka Fefejezése";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(28, 355);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 31);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Keresés";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbElemek
            // 
            this.lbElemek.FormattingEnabled = true;
            this.lbElemek.Location = new System.Drawing.Point(28, 61);
            this.lbElemek.Name = "lbElemek";
            this.lbElemek.Size = new System.Drawing.Size(120, 238);
            this.lbElemek.TabIndex = 3;
            // 
            // lbHarom
            // 
            this.lbHarom.FormattingEnabled = true;
            this.lbHarom.Location = new System.Drawing.Point(448, 223);
            this.lbHarom.Name = "lbHarom";
            this.lbHarom.Size = new System.Drawing.Size(120, 95);
            this.lbHarom.TabIndex = 4;
            this.lbHarom.Visible = false;
            // 
            // lbOt
            // 
            this.lbOt.FormattingEnabled = true;
            this.lbOt.Location = new System.Drawing.Point(609, 223);
            this.lbOt.Name = "lbOt";
            this.lbOt.Size = new System.Drawing.Size(120, 95);
            this.lbOt.TabIndex = 5;
            this.lbOt.Visible = false;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(28, 315);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(120, 20);
            this.txtBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Location = new System.Drawing.Point(202, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listafeladatok";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 26);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(147, 17);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Text = "Legkisebb negatív száma";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 49);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(152, 17);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "Legnagyobb pozitív száma";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbox1);
            this.groupBox2.Controls.Add(this.chkbox2);
            this.groupBox2.Controls.Add(this.chkbox3);
            this.groupBox2.Location = new System.Drawing.Point(202, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek";
            // 
            // chkbox1
            // 
            this.chkbox1.AutoSize = true;
            this.chkbox1.Location = new System.Drawing.Point(6, 19);
            this.chkbox1.Name = "chkbox1";
            this.chkbox1.Size = new System.Drawing.Size(141, 17);
            this.chkbox1.TabIndex = 10;
            this.chkbox1.Text = "Lista elemeinek összege";
            this.chkbox1.UseVisualStyleBackColor = true;
            this.chkbox1.CheckedChanged += new System.EventHandler(this.chkbox1_CheckedChanged);
            // 
            // chkbox2
            // 
            this.chkbox2.AutoSize = true;
            this.chkbox2.Location = new System.Drawing.Point(6, 42);
            this.chkbox2.Name = "chkbox2";
            this.chkbox2.Size = new System.Drawing.Size(158, 17);
            this.chkbox2.TabIndex = 11;
            this.chkbox2.Text = "Pozitív számok darabszáma";
            this.chkbox2.UseVisualStyleBackColor = true;
            this.chkbox2.CheckedChanged += new System.EventHandler(this.chkbox2_CheckedChanged);
            // 
            // chkbox3
            // 
            this.chkbox3.AutoSize = true;
            this.chkbox3.Location = new System.Drawing.Point(6, 65);
            this.chkbox3.Name = "chkbox3";
            this.chkbox3.Size = new System.Drawing.Size(93, 17);
            this.chkbox3.TabIndex = 12;
            this.chkbox3.Text = "Szétválogatás";
            this.chkbox3.UseVisualStyleBackColor = true;
            this.chkbox3.CheckedChanged += new System.EventHandler(this.chkbox3_CheckedChanged);
            // 
            // combox
            // 
            this.combox.FormattingEnabled = true;
            this.combox.Location = new System.Drawing.Point(202, 142);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(200, 21);
            this.combox.TabIndex = 0;
            this.combox.SelectedIndexChanged += new System.EventHandler(this.combox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elemek darabszáma: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lbOt);
            this.Controls.Add(this.lbHarom);
            this.Controls.Add(this.lbElemek);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lbElemek;
        private System.Windows.Forms.ListBox lbHarom;
        private System.Windows.Forms.ListBox lbOt;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkbox1;
        private System.Windows.Forms.CheckBox chkbox2;
        private System.Windows.Forms.CheckBox chkbox3;
        private System.Windows.Forms.ComboBox combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

