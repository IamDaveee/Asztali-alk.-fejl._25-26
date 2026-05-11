
namespace OrvosiNobeldijasokGUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtSzul = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SZ/H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // txtEv
            // 
            this.txtEv.Location = new System.Drawing.Point(147, 68);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(47, 20);
            this.txtEv.TabIndex = 4;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(147, 94);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(178, 20);
            this.txtNev.TabIndex = 5;
            // 
            // txtSzul
            // 
            this.txtSzul.Location = new System.Drawing.Point(147, 120);
            this.txtSzul.Name = "txtSzul";
            this.txtSzul.Size = new System.Drawing.Size(100, 20);
            this.txtSzul.TabIndex = 6;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(147, 146);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(47, 20);
            this.txtOrszag.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Adatok mentése";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtSzul);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.txtEv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEv;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.TextBox txtSzul;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.Button btnSave;
    }
}

