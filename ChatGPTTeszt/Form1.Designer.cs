
namespace ChatGPTTeszt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnMegnyitas;
        private System.Windows.Forms.ListBox lstKuldetesek;

        private System.Windows.Forms.Label lblKuldetesDb;
        private System.Windows.Forms.Label lblOsszUtasszam;
        private System.Windows.Forms.Label lblKevesebbMint5;
        private System.Windows.Forms.Label lblColumbia;
        private System.Windows.Forms.Label lblLeghosszabb;
        private System.Windows.Forms.Label lblKennedy;

        private System.Windows.Forms.Label lblEv;
        private System.Windows.Forms.TextBox txtEv;
        private System.Windows.Forms.Button btnEvKereses;
        private System.Windows.Forms.TextBox txtEvEredmeny;

        private System.Windows.Forms.Label lblFajlnev;
        private System.Windows.Forms.TextBox txtFajlnev;
        private System.Windows.Forms.Button btnTxtMentes;

        private System.Windows.Forms.GroupBox grpSzures;
        private System.Windows.Forms.RadioButton rdbOsszes;
        private System.Windows.Forms.RadioButton rdbCsakColumbia;

        private System.Windows.Forms.Label lblUrsikloValaszto;
        private System.Windows.Forms.ComboBox cmbUrsiklok;

        private System.Windows.Forms.GroupBox grpMezok;
        private System.Windows.Forms.CheckBox chkKod;
        private System.Windows.Forms.CheckBox chkDatum;
        private System.Windows.Forms.CheckBox chkUrsiklo;
        private System.Windows.Forms.CheckBox chkIdo;
        private System.Windows.Forms.CheckBox chkLandolas;
        private System.Windows.Forms.CheckBox chkLegenyseg;

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

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMegnyitas = new System.Windows.Forms.Button();
            this.lstKuldetesek = new System.Windows.Forms.ListBox();

            this.lblKuldetesDb = new System.Windows.Forms.Label();
            this.lblOsszUtasszam = new System.Windows.Forms.Label();
            this.lblKevesebbMint5 = new System.Windows.Forms.Label();
            this.lblColumbia = new System.Windows.Forms.Label();
            this.lblLeghosszabb = new System.Windows.Forms.Label();
            this.lblKennedy = new System.Windows.Forms.Label();

            this.lblEv = new System.Windows.Forms.Label();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.btnEvKereses = new System.Windows.Forms.Button();
            this.txtEvEredmeny = new System.Windows.Forms.TextBox();

            this.lblFajlnev = new System.Windows.Forms.Label();
            this.txtFajlnev = new System.Windows.Forms.TextBox();
            this.btnTxtMentes = new System.Windows.Forms.Button();

            this.grpSzures = new System.Windows.Forms.GroupBox();
            this.rdbOsszes = new System.Windows.Forms.RadioButton();
            this.rdbCsakColumbia = new System.Windows.Forms.RadioButton();

            this.lblUrsikloValaszto = new System.Windows.Forms.Label();
            this.cmbUrsiklok = new System.Windows.Forms.ComboBox();

            this.grpMezok = new System.Windows.Forms.GroupBox();
            this.chkKod = new System.Windows.Forms.CheckBox();
            this.chkDatum = new System.Windows.Forms.CheckBox();
            this.chkUrsiklo = new System.Windows.Forms.CheckBox();
            this.chkIdo = new System.Windows.Forms.CheckBox();
            this.chkLandolas = new System.Windows.Forms.CheckBox();
            this.chkLegenyseg = new System.Windows.Forms.CheckBox();

            this.grpSzures.SuspendLayout();
            this.grpMezok.SuspendLayout();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shuttle küldetések";
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // btnMegnyitas
            // 
            this.btnMegnyitas.Location = new System.Drawing.Point(20, 20);
            this.btnMegnyitas.Name = "btnMegnyitas";
            this.btnMegnyitas.Size = new System.Drawing.Size(180, 40);
            this.btnMegnyitas.TabIndex = 0;
            this.btnMegnyitas.Text = "CSV megnyitása";
            this.btnMegnyitas.UseVisualStyleBackColor = true;
            this.btnMegnyitas.Click += new System.EventHandler(this.btnMegnyitas_Click);

            // 
            // lstKuldetesek
            // 
            this.lstKuldetesek.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstKuldetesek.FormattingEnabled = true;
            this.lstKuldetesek.HorizontalScrollbar = true;
            this.lstKuldetesek.ItemHeight = 20;
            this.lstKuldetesek.Location = new System.Drawing.Point(20, 80);
            this.lstKuldetesek.Name = "lstKuldetesek";
            this.lstKuldetesek.Size = new System.Drawing.Size(700, 604);
            this.lstKuldetesek.TabIndex = 1;

            // 
            // lblKuldetesDb
            // 
            this.lblKuldetesDb.AutoSize = false;
            this.lblKuldetesDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKuldetesDb.Location = new System.Drawing.Point(750, 20);
            this.lblKuldetesDb.Name = "lblKuldetesDb";
            this.lblKuldetesDb.Size = new System.Drawing.Size(460, 35);
            this.lblKuldetesDb.TabIndex = 2;
            this.lblKuldetesDb.Text = "Küldetések száma:";
            this.lblKuldetesDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblOsszUtasszam
            // 
            this.lblOsszUtasszam.AutoSize = false;
            this.lblOsszUtasszam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOsszUtasszam.Location = new System.Drawing.Point(750, 60);
            this.lblOsszUtasszam.Name = "lblOsszUtasszam";
            this.lblOsszUtasszam.Size = new System.Drawing.Size(460, 35);
            this.lblOsszUtasszam.TabIndex = 3;
            this.lblOsszUtasszam.Text = "Összes szállított utas:";
            this.lblOsszUtasszam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblKevesebbMint5
            // 
            this.lblKevesebbMint5.AutoSize = false;
            this.lblKevesebbMint5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKevesebbMint5.Location = new System.Drawing.Point(750, 100);
            this.lblKevesebbMint5.Name = "lblKevesebbMint5";
            this.lblKevesebbMint5.Size = new System.Drawing.Size(460, 35);
            this.lblKevesebbMint5.TabIndex = 4;
            this.lblKevesebbMint5.Text = "5 főnél kisebb legénységű küldetések:";
            this.lblKevesebbMint5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblColumbia
            // 
            this.lblColumbia.AutoSize = false;
            this.lblColumbia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColumbia.Location = new System.Drawing.Point(750, 140);
            this.lblColumbia.Name = "lblColumbia";
            this.lblColumbia.Size = new System.Drawing.Size(460, 35);
            this.lblColumbia.TabIndex = 5;
            this.lblColumbia.Text = "A Columbia utolsó útja:";
            this.lblColumbia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblLeghosszabb
            // 
            this.lblLeghosszabb.AutoSize = false;
            this.lblLeghosszabb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeghosszabb.Location = new System.Drawing.Point(750, 180);
            this.lblLeghosszabb.Name = "lblLeghosszabb";
            this.lblLeghosszabb.Size = new System.Drawing.Size(460, 35);
            this.lblLeghosszabb.TabIndex = 6;
            this.lblLeghosszabb.Text = "Leghosszabb küldetés:";
            this.lblLeghosszabb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblKennedy
            // 
            this.lblKennedy.AutoSize = false;
            this.lblKennedy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKennedy.Location = new System.Drawing.Point(750, 220);
            this.lblKennedy.Name = "lblKennedy";
            this.lblKennedy.Size = new System.Drawing.Size(460, 35);
            this.lblKennedy.TabIndex = 7;
            this.lblKennedy.Text = "Kennedy landolások aránya:";
            this.lblKennedy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblEv
            // 
            this.lblEv.AutoSize = true;
            this.lblEv.Location = new System.Drawing.Point(750, 280);
            this.lblEv.Name = "lblEv";
            this.lblEv.Size = new System.Drawing.Size(145, 16);
            this.lblEv.TabIndex = 8;
            this.lblEv.Text = "Adj meg egy évszámot:";

            // 
            // txtEv
            // 
            this.txtEv.Location = new System.Drawing.Point(750, 300);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(120, 22);
            this.txtEv.TabIndex = 9;

            // 
            // btnEvKereses
            // 
            this.btnEvKereses.Location = new System.Drawing.Point(885, 297);
            this.btnEvKereses.Name = "btnEvKereses";
            this.btnEvKereses.Size = new System.Drawing.Size(130, 28);
            this.btnEvKereses.TabIndex = 10;
            this.btnEvKereses.Text = "Keresés";
            this.btnEvKereses.UseVisualStyleBackColor = true;
            this.btnEvKereses.Click += new System.EventHandler(this.btnEvKereses_Click);

            // 
            // txtEvEredmeny
            // 
            this.txtEvEredmeny.Location = new System.Drawing.Point(750, 335);
            this.txtEvEredmeny.Multiline = true;
            this.txtEvEredmeny.Name = "txtEvEredmeny";
            this.txtEvEredmeny.ReadOnly = true;
            this.txtEvEredmeny.Size = new System.Drawing.Size(460, 50);
            this.txtEvEredmeny.TabIndex = 11;

            // 
            // lblFajlnev
            // 
            this.lblFajlnev.AutoSize = true;
            this.lblFajlnev.Location = new System.Drawing.Point(750, 405);
            this.lblFajlnev.Name = "lblFajlnev";
            this.lblFajlnev.Size = new System.Drawing.Size(134, 16);
            this.lblFajlnev.TabIndex = 12;
            this.lblFajlnev.Text = "Kimeneti fájl neve:";

            // 
            // txtFajlnev
            // 
            this.txtFajlnev.Location = new System.Drawing.Point(750, 425);
            this.txtFajlnev.Name = "txtFajlnev";
            this.txtFajlnev.Size = new System.Drawing.Size(265, 22);
            this.txtFajlnev.TabIndex = 13;
            this.txtFajlnev.Text = "statisztika";

            // 
            // btnTxtMentes
            // 
            this.btnTxtMentes.Location = new System.Drawing.Point(1030, 422);
            this.btnTxtMentes.Name = "btnTxtMentes";
            this.btnTxtMentes.Size = new System.Drawing.Size(180, 28);
            this.btnTxtMentes.TabIndex = 14;
            this.btnTxtMentes.Text = "TXT mentése";
            this.btnTxtMentes.UseVisualStyleBackColor = true;
            this.btnTxtMentes.Click += new System.EventHandler(this.btnTxtMentes_Click);

            // 
            // grpSzures
            // 
            this.grpSzures.Controls.Add(this.rdbOsszes);
            this.grpSzures.Controls.Add(this.rdbCsakColumbia);
            this.grpSzures.Location = new System.Drawing.Point(750, 470);
            this.grpSzures.Name = "grpSzures";
            this.grpSzures.Size = new System.Drawing.Size(220, 90);
            this.grpSzures.TabIndex = 15;
            this.grpSzures.TabStop = false;
            this.grpSzures.Text = "Szűrés";

            // 
            // rdbOsszes
            // 
            this.rdbOsszes.AutoSize = true;
            this.rdbOsszes.Location = new System.Drawing.Point(15, 28);
            this.rdbOsszes.Name = "rdbOsszes";
            this.rdbOsszes.Size = new System.Drawing.Size(73, 20);
            this.rdbOsszes.TabIndex = 0;
            this.rdbOsszes.TabStop = true;
            this.rdbOsszes.Text = "Összes";
            this.rdbOsszes.UseVisualStyleBackColor = true;
            this.rdbOsszes.CheckedChanged += new System.EventHandler(this.rdbOsszes_CheckedChanged);

            // 
            // rdbCsakColumbia
            // 
            this.rdbCsakColumbia.AutoSize = true;
            this.rdbCsakColumbia.Location = new System.Drawing.Point(15, 55);
            this.rdbCsakColumbia.Name = "rdbCsakColumbia";
            this.rdbCsakColumbia.Size = new System.Drawing.Size(123, 20);
            this.rdbCsakColumbia.TabIndex = 1;
            this.rdbCsakColumbia.TabStop = true;
            this.rdbCsakColumbia.Text = "Csak Columbia";
            this.rdbCsakColumbia.UseVisualStyleBackColor = true;
            this.rdbCsakColumbia.CheckedChanged += new System.EventHandler(this.rdbCsakColumbia_CheckedChanged);

            // 
            // lblUrsikloValaszto
            // 
            this.lblUrsikloValaszto.AutoSize = true;
            this.lblUrsikloValaszto.Location = new System.Drawing.Point(990, 485);
            this.lblUrsikloValaszto.Name = "lblUrsikloValaszto";
            this.lblUrsikloValaszto.Size = new System.Drawing.Size(119, 16);
            this.lblUrsikloValaszto.TabIndex = 16;
            this.lblUrsikloValaszto.Text = "Űrsikló kiválasztása:";

            // 
            // cmbUrsiklok
            // 
            this.cmbUrsiklok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrsiklok.FormattingEnabled = true;
            this.cmbUrsiklok.Location = new System.Drawing.Point(993, 505);
            this.cmbUrsiklok.Name = "cmbUrsiklok";
            this.cmbUrsiklok.Size = new System.Drawing.Size(217, 24);
            this.cmbUrsiklok.TabIndex = 17;
            this.cmbUrsiklok.SelectedIndexChanged += new System.EventHandler(this.cmbUrsiklok_SelectedIndexChanged);

            // 
            // grpMezok
            // 
            this.grpMezok.Controls.Add(this.chkKod);
            this.grpMezok.Controls.Add(this.chkDatum);
            this.grpMezok.Controls.Add(this.chkUrsiklo);
            this.grpMezok.Controls.Add(this.chkIdo);
            this.grpMezok.Controls.Add(this.chkLandolas);
            this.grpMezok.Controls.Add(this.chkLegenyseg);
            this.grpMezok.Location = new System.Drawing.Point(750, 575);
            this.grpMezok.Name = "grpMezok";
            this.grpMezok.Size = new System.Drawing.Size(460, 110);
            this.grpMezok.TabIndex = 18;
            this.grpMezok.TabStop = false;
            this.grpMezok.Text = "Megjelenő mezők";

            // 
            // chkKod
            // 
            this.chkKod.AutoSize = true;
            this.chkKod.Checked = true;
            this.chkKod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKod.Location = new System.Drawing.Point(15, 28);
            this.chkKod.Name = "chkKod";
            this.chkKod.Size = new System.Drawing.Size(57, 20);
            this.chkKod.TabIndex = 0;
            this.chkKod.Text = "Kód";
            this.chkKod.UseVisualStyleBackColor = true;
            this.chkKod.CheckedChanged += new System.EventHandler(this.chkKod_CheckedChanged);

            // 
            // chkDatum
            // 
            this.chkDatum.AutoSize = true;
            this.chkDatum.Checked = true;
            this.chkDatum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDatum.Location = new System.Drawing.Point(120, 28);
            this.chkDatum.Name = "chkDatum";
            this.chkDatum.Size = new System.Drawing.Size(71, 20);
            this.chkDatum.TabIndex = 1;
            this.chkDatum.Text = "Dátum";
            this.chkDatum.UseVisualStyleBackColor = true;
            this.chkDatum.CheckedChanged += new System.EventHandler(this.chkDatum_CheckedChanged);

            // 
            // chkUrsiklo
            // 
            this.chkUrsiklo.AutoSize = true;
            this.chkUrsiklo.Checked = true;
            this.chkUrsiklo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUrsiklo.Location = new System.Drawing.Point(240, 28);
            this.chkUrsiklo.Name = "chkUrsiklo";
            this.chkUrsiklo.Size = new System.Drawing.Size(76, 20);
            this.chkUrsiklo.TabIndex = 2;
            this.chkUrsiklo.Text = "Űrsikló";
            this.chkUrsiklo.UseVisualStyleBackColor = true;
            this.chkUrsiklo.CheckedChanged += new System.EventHandler(this.chkUrsiklo_CheckedChanged);

            // 
            // chkIdo
            // 
            this.chkIdo.AutoSize = true;
            this.chkIdo.Checked = true;
            this.chkIdo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdo.Location = new System.Drawing.Point(360, 28);
            this.chkIdo.Name = "chkIdo";
            this.chkIdo.Size = new System.Drawing.Size(48, 20);
            this.chkIdo.TabIndex = 3;
            this.chkIdo.Text = "Idő";
            this.chkIdo.UseVisualStyleBackColor = true;
            this.chkIdo.CheckedChanged += new System.EventHandler(this.chkIdo_CheckedChanged);

            // 
            // chkLandolas
            // 
            this.chkLandolas.AutoSize = true;
            this.chkLandolas.Checked = true;
            this.chkLandolas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLandolas.Location = new System.Drawing.Point(15, 65);
            this.chkLandolas.Name = "chkLandolas";
            this.chkLandolas.Size = new System.Drawing.Size(89, 20);
            this.chkLandolas.TabIndex = 4;
            this.chkLandolas.Text = "Landolás";
            this.chkLandolas.UseVisualStyleBackColor = true;
            this.chkLandolas.CheckedChanged += new System.EventHandler(this.chkLandolas_CheckedChanged);

            // 
            // chkLegenyseg
            // 
            this.chkLegenyseg.AutoSize = true;
            this.chkLegenyseg.Checked = true;
            this.chkLegenyseg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLegenyseg.Location = new System.Drawing.Point(120, 65);
            this.chkLegenyseg.Name = "chkLegenyseg";
            this.chkLegenyseg.Size = new System.Drawing.Size(96, 20);
            this.chkLegenyseg.TabIndex = 5;
            this.chkLegenyseg.Text = "Legénység";
            this.chkLegenyseg.UseVisualStyleBackColor = true;
            this.chkLegenyseg.CheckedChanged += new System.EventHandler(this.chkLegenyseg_CheckedChanged);

            // 
            // Controls
            // 
            this.Controls.Add(this.btnMegnyitas);
            this.Controls.Add(this.lstKuldetesek);

            this.Controls.Add(this.lblKuldetesDb);
            this.Controls.Add(this.lblOsszUtasszam);
            this.Controls.Add(this.lblKevesebbMint5);
            this.Controls.Add(this.lblColumbia);
            this.Controls.Add(this.lblLeghosszabb);
            this.Controls.Add(this.lblKennedy);

            this.Controls.Add(this.lblEv);
            this.Controls.Add(this.txtEv);
            this.Controls.Add(this.btnEvKereses);
            this.Controls.Add(this.txtEvEredmeny);

            this.Controls.Add(this.lblFajlnev);
            this.Controls.Add(this.txtFajlnev);
            this.Controls.Add(this.btnTxtMentes);

            this.Controls.Add(this.grpSzures);
            this.Controls.Add(this.lblUrsikloValaszto);
            this.Controls.Add(this.cmbUrsiklok);

            this.Controls.Add(this.grpMezok);

            this.grpSzures.ResumeLayout(false);
            this.grpSzures.PerformLayout();
            this.grpMezok.ResumeLayout(false);
            this.grpMezok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

