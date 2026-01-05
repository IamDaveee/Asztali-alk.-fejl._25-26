
namespace AutoMárkaVálasztás
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAudi = new System.Windows.Forms.RadioButton();
            this.rbBmw = new System.Windows.Forms.RadioButton();
            this.rbMerceddes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPiros = new System.Windows.Forms.RadioButton();
            this.rbKek = new System.Windows.Forms.RadioButton();
            this.rbSarga = new System.Windows.Forms.RadioButton();
            this.btnPick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMerceddes);
            this.groupBox1.Controls.Add(this.rbBmw);
            this.groupBox1.Controls.Add(this.rbAudi);
            this.groupBox1.Location = new System.Drawing.Point(56, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autómárka";
            // 
            // rbAudi
            // 
            this.rbAudi.AutoSize = true;
            this.rbAudi.Location = new System.Drawing.Point(6, 29);
            this.rbAudi.Name = "rbAudi";
            this.rbAudi.Size = new System.Drawing.Size(46, 17);
            this.rbAudi.TabIndex = 0;
            this.rbAudi.TabStop = true;
            this.rbAudi.Text = "Audi";
            this.rbAudi.UseVisualStyleBackColor = true;
            // 
            // rbBmw
            // 
            this.rbBmw.AutoSize = true;
            this.rbBmw.Location = new System.Drawing.Point(6, 52);
            this.rbBmw.Name = "rbBmw";
            this.rbBmw.Size = new System.Drawing.Size(52, 17);
            this.rbBmw.TabIndex = 1;
            this.rbBmw.TabStop = true;
            this.rbBmw.Text = "BMW";
            this.rbBmw.UseVisualStyleBackColor = true;
            // 
            // rbMerceddes
            // 
            this.rbMerceddes.AutoSize = true;
            this.rbMerceddes.Location = new System.Drawing.Point(6, 75);
            this.rbMerceddes.Name = "rbMerceddes";
            this.rbMerceddes.Size = new System.Drawing.Size(72, 17);
            this.rbMerceddes.TabIndex = 2;
            this.rbMerceddes.TabStop = true;
            this.rbMerceddes.Text = "Mercedes";
            this.rbMerceddes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSarga);
            this.groupBox2.Controls.Add(this.rbKek);
            this.groupBox2.Controls.Add(this.rbPiros);
            this.groupBox2.Location = new System.Drawing.Point(56, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autó Színe";
            // 
            // rbPiros
            // 
            this.rbPiros.AutoSize = true;
            this.rbPiros.Location = new System.Drawing.Point(7, 20);
            this.rbPiros.Name = "rbPiros";
            this.rbPiros.Size = new System.Drawing.Size(48, 17);
            this.rbPiros.TabIndex = 0;
            this.rbPiros.Text = "Piros";
            this.rbPiros.UseVisualStyleBackColor = true;
            this.rbPiros.CheckedChanged += new System.EventHandler(this.rbPiros_CheckedChanged);
            // 
            // rbKek
            // 
            this.rbKek.AutoSize = true;
            this.rbKek.Location = new System.Drawing.Point(7, 43);
            this.rbKek.Name = "rbKek";
            this.rbKek.Size = new System.Drawing.Size(44, 17);
            this.rbKek.TabIndex = 1;
            this.rbKek.TabStop = true;
            this.rbKek.Text = "Kék";
            this.rbKek.UseVisualStyleBackColor = true;
            // 
            // rbSarga
            // 
            this.rbSarga.AutoSize = true;
            this.rbSarga.Location = new System.Drawing.Point(7, 68);
            this.rbSarga.Name = "rbSarga";
            this.rbSarga.Size = new System.Drawing.Size(53, 17);
            this.rbSarga.TabIndex = 2;
            this.rbSarga.TabStop = true;
            this.rbSarga.Text = "Sárga";
            this.rbSarga.UseVisualStyleBackColor = true;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(331, 60);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(106, 46);
            this.btnPick.TabIndex = 2;
            this.btnPick.Text = "Kiválasztott Autó";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(502, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 236);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMerceddes;
        private System.Windows.Forms.RadioButton rbBmw;
        private System.Windows.Forms.RadioButton rbAudi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSarga;
        private System.Windows.Forms.RadioButton rbKek;
        private System.Windows.Forms.RadioButton rbPiros;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

