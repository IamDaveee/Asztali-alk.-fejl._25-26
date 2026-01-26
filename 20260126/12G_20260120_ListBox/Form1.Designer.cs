
namespace _12G_20260120_ListBox
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
            this.txtb_elem = new System.Windows.Forms.TextBox();
            this.lB_elemek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_darab = new System.Windows.Forms.TextBox();
            this.btn_HozzaAd = new System.Windows.Forms.Button();
            this.btn_KijelöltTörlése = new System.Windows.Forms.Button();
            this.btn_ÖsszesTörlése = new System.Windows.Forms.Button();
            this.btn_Feltölt = new System.Windows.Forms.Button();
            this.btn_ElemVizsgalat = new System.Windows.Forms.Button();
            this.btn_Feltölt2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_elem
            // 
            this.txtb_elem.Location = new System.Drawing.Point(28, 34);
            this.txtb_elem.Name = "txtb_elem";
            this.txtb_elem.Size = new System.Drawing.Size(127, 20);
            this.txtb_elem.TabIndex = 0;
            // 
            // lB_elemek
            // 
            this.lB_elemek.FormattingEnabled = true;
            this.lB_elemek.Items.AddRange(new object[] {
            "első elem",
            "második elem",
            "1",
            "2",
            "cica"});
            this.lB_elemek.Location = new System.Drawing.Point(28, 84);
            this.lB_elemek.Name = "lB_elemek";
            this.lB_elemek.Size = new System.Drawing.Size(127, 199);
            this.lB_elemek.TabIndex = 1;
            this.lB_elemek.SelectedIndexChanged += new System.EventHandler(this.lB_elemek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elemek száma:";
            // 
            // txtB_darab
            // 
            this.txtB_darab.Location = new System.Drawing.Point(109, 309);
            this.txtB_darab.Name = "txtB_darab";
            this.txtB_darab.Size = new System.Drawing.Size(46, 20);
            this.txtB_darab.TabIndex = 3;
            // 
            // btn_HozzaAd
            // 
            this.btn_HozzaAd.Location = new System.Drawing.Point(218, 34);
            this.btn_HozzaAd.Name = "btn_HozzaAd";
            this.btn_HozzaAd.Size = new System.Drawing.Size(75, 37);
            this.btn_HozzaAd.TabIndex = 4;
            this.btn_HozzaAd.Text = "Elem hozzáadása";
            this.btn_HozzaAd.UseVisualStyleBackColor = true;
            this.btn_HozzaAd.Click += new System.EventHandler(this.btn_HozzaAd_Click);
            // 
            // btn_KijelöltTörlése
            // 
            this.btn_KijelöltTörlése.Location = new System.Drawing.Point(218, 98);
            this.btn_KijelöltTörlése.Name = "btn_KijelöltTörlése";
            this.btn_KijelöltTörlése.Size = new System.Drawing.Size(75, 39);
            this.btn_KijelöltTörlése.TabIndex = 5;
            this.btn_KijelöltTörlése.Text = "Kijelölt törlése";
            this.btn_KijelöltTörlése.UseVisualStyleBackColor = true;
            this.btn_KijelöltTörlése.Click += new System.EventHandler(this.btn_KijelöltTörlése_Click);
            // 
            // btn_ÖsszesTörlése
            // 
            this.btn_ÖsszesTörlése.Location = new System.Drawing.Point(218, 158);
            this.btn_ÖsszesTörlése.Name = "btn_ÖsszesTörlése";
            this.btn_ÖsszesTörlése.Size = new System.Drawing.Size(75, 40);
            this.btn_ÖsszesTörlése.TabIndex = 6;
            this.btn_ÖsszesTörlése.Text = "Összes Törlése";
            this.btn_ÖsszesTörlése.UseVisualStyleBackColor = true;
            this.btn_ÖsszesTörlése.Click += new System.EventHandler(this.btn_ÖsszesTörlése_Click);
            // 
            // btn_Feltölt
            // 
            this.btn_Feltölt.Location = new System.Drawing.Point(218, 215);
            this.btn_Feltölt.Name = "btn_Feltölt";
            this.btn_Feltölt.Size = new System.Drawing.Size(75, 23);
            this.btn_Feltölt.TabIndex = 7;
            this.btn_Feltölt.Text = "Feltölt";
            this.btn_Feltölt.UseVisualStyleBackColor = true;
            this.btn_Feltölt.Click += new System.EventHandler(this.btn_Feltölt_Click);
            // 
            // btn_ElemVizsgalat
            // 
            this.btn_ElemVizsgalat.Location = new System.Drawing.Point(218, 268);
            this.btn_ElemVizsgalat.Name = "btn_ElemVizsgalat";
            this.btn_ElemVizsgalat.Size = new System.Drawing.Size(75, 40);
            this.btn_ElemVizsgalat.TabIndex = 8;
            this.btn_ElemVizsgalat.Text = "Elem vizsgálata";
            this.btn_ElemVizsgalat.UseVisualStyleBackColor = true;
            this.btn_ElemVizsgalat.Click += new System.EventHandler(this.btn_ElemVizsgalat_Click);
            // 
            // btn_Feltölt2
            // 
            this.btn_Feltölt2.Location = new System.Drawing.Point(218, 333);
            this.btn_Feltölt2.Name = "btn_Feltölt2";
            this.btn_Feltölt2.Size = new System.Drawing.Size(75, 23);
            this.btn_Feltölt2.TabIndex = 9;
            this.btn_Feltölt2.Text = "Feltölt2";
            this.btn_Feltölt2.UseVisualStyleBackColor = true;
            this.btn_Feltölt2.Click += new System.EventHandler(this.btn_Feltölt2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rendezés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Beszúrás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(28, 336);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 427);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Feltölt2);
            this.Controls.Add(this.btn_ElemVizsgalat);
            this.Controls.Add(this.btn_Feltölt);
            this.Controls.Add(this.btn_ÖsszesTörlése);
            this.Controls.Add(this.btn_KijelöltTörlése);
            this.Controls.Add(this.btn_HozzaAd);
            this.Controls.Add(this.txtB_darab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lB_elemek);
            this.Controls.Add(this.txtb_elem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_elem;
        private System.Windows.Forms.ListBox lB_elemek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_darab;
        private System.Windows.Forms.Button btn_HozzaAd;
        private System.Windows.Forms.Button btn_KijelöltTörlése;
        private System.Windows.Forms.Button btn_ÖsszesTörlése;
        private System.Windows.Forms.Button btn_Feltölt;
        private System.Windows.Forms.Button btn_ElemVizsgalat;
        private System.Windows.Forms.Button btn_Feltölt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

