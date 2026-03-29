
namespace SpaceShuttleProject_BalázsDávid
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAllMission = new System.Windows.Forms.TextBox();
            this.txtFilterMission = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAllCrew = new System.Windows.Forms.Label();
            this.txtLatest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLeesFive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMostOut = new System.Windows.Forms.TextBox();
            this.btnYear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKennedy = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbFilter = new System.Windows.Forms.RadioButton();
            this.btnSaveTxt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 290);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adatok";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(466, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Megnyitás";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(547, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrő";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(365, 19);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(78, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Legénység";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(284, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Űrközpont";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(235, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(43, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Óra";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(183, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(46, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Nap";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(120, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Űrhajó";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(57, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Dátum";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Kód";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(383, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Frissítés";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(15, 393);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(114, 23);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "Összes Kijelölése";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Összes küldetés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Szűrt küldetés:";
            // 
            // txtAllMission
            // 
            this.txtAllMission.Location = new System.Drawing.Point(588, 72);
            this.txtAllMission.Name = "txtAllMission";
            this.txtAllMission.ReadOnly = true;
            this.txtAllMission.Size = new System.Drawing.Size(31, 20);
            this.txtAllMission.TabIndex = 10;
            this.txtAllMission.Visible = false;
            // 
            // txtFilterMission
            // 
            this.txtFilterMission.Location = new System.Drawing.Point(588, 97);
            this.txtFilterMission.Name = "txtFilterMission";
            this.txtFilterMission.ReadOnly = true;
            this.txtFilterMission.Size = new System.Drawing.Size(31, 20);
            this.txtFilterMission.TabIndex = 11;
            this.txtFilterMission.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Összes utas:";
            // 
            // lblAllCrew
            // 
            this.lblAllCrew.AutoSize = true;
            this.lblAllCrew.Location = new System.Drawing.Point(585, 129);
            this.lblAllCrew.Name = "lblAllCrew";
            this.lblAllCrew.Size = new System.Drawing.Size(35, 13);
            this.lblAllCrew.TabIndex = 13;
            this.lblAllCrew.Text = "label5";
            this.lblAllCrew.Visible = false;
            // 
            // txtLatest
            // 
            this.txtLatest.Location = new System.Drawing.Point(588, 176);
            this.txtLatest.Multiline = true;
            this.txtLatest.Name = "txtLatest";
            this.txtLatest.ReadOnly = true;
            this.txtLatest.Size = new System.Drawing.Size(114, 64);
            this.txtLatest.TabIndex = 14;
            this.txtLatest.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kevesebb mint 5 fő:";
            // 
            // lblLeesFive
            // 
            this.lblLeesFive.AutoSize = true;
            this.lblLeesFive.Location = new System.Drawing.Point(586, 148);
            this.lblLeesFive.Name = "lblLeesFive";
            this.lblLeesFive.Size = new System.Drawing.Size(35, 13);
            this.lblLeesFive.TabIndex = 16;
            this.lblLeesFive.Text = "label6";
            this.lblLeesFive.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLeesFive.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Legutóbbi küldetés:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Legtöbbet távol:";
            this.label7.Visible = false;
            // 
            // txtMostOut
            // 
            this.txtMostOut.Location = new System.Drawing.Point(588, 176);
            this.txtMostOut.Multiline = true;
            this.txtMostOut.Name = "txtMostOut";
            this.txtMostOut.ReadOnly = true;
            this.txtMostOut.Size = new System.Drawing.Size(126, 51);
            this.txtMostOut.TabIndex = 19;
            this.txtMostOut.Visible = false;
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(466, 292);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(75, 23);
            this.btnYear.TabIndex = 20;
            this.btnYear.Text = "Évszám";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Landolások Kennedy-n:";
            // 
            // lblKennedy
            // 
            this.lblKennedy.AutoSize = true;
            this.lblKennedy.Location = new System.Drawing.Point(585, 258);
            this.lblKennedy.Name = "lblKennedy";
            this.lblKennedy.Size = new System.Drawing.Size(35, 13);
            this.lblKennedy.TabIndex = 22;
            this.lblKennedy.Text = "label9";
            this.lblKennedy.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAll);
            this.groupBox2.Controls.Add(this.rdbFilter);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(588, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 82);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mentés Másként";
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(111, 19);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(83, 17);
            this.rdbAll.TabIndex = 5;
            this.rdbAll.Text = "Teljes Tábla";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbFilter
            // 
            this.rdbFilter.AutoSize = true;
            this.rdbFilter.Location = new System.Drawing.Point(6, 19);
            this.rdbFilter.Name = "rdbFilter";
            this.rdbFilter.Size = new System.Drawing.Size(79, 17);
            this.rdbFilter.TabIndex = 4;
            this.rdbFilter.Text = "Szűrt Tábla";
            this.rdbFilter.UseVisualStyleBackColor = true;
            // 
            // btnSaveTxt
            // 
            this.btnSaveTxt.Location = new System.Drawing.Point(624, 292);
            this.btnSaveTxt.Name = "btnSaveTxt";
            this.btnSaveTxt.Size = new System.Drawing.Size(150, 23);
            this.btnSaveTxt.TabIndex = 6;
            this.btnSaveTxt.Text = "Csoportosított napok száma";
            this.btnSaveTxt.UseVisualStyleBackColor = true;
            this.btnSaveTxt.Click += new System.EventHandler(this.btnSaveTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveTxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblKennedy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.txtMostOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLeesFive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLatest);
            this.Controls.Add(this.lblAllCrew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilterMission);
            this.Controls.Add(this.txtAllMission);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
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

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAllMission;
        private System.Windows.Forms.TextBox txtFilterMission;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAllCrew;
        private System.Windows.Forms.TextBox txtLatest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLeesFive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMostOut;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKennedy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbFilter;
        private System.Windows.Forms.Button btnSaveTxt;
    }
}

