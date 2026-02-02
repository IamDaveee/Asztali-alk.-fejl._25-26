
namespace Checkbox
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
            this.chkbEgyik = new System.Windows.Forms.CheckBox();
            this.chkbMasik = new System.Windows.Forms.CheckBox();
            this.btnÁllapot = new System.Windows.Forms.Button();
            this.btnÉs = new System.Windows.Forms.Button();
            this.btnVagy = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkbEgyik
            // 
            this.chkbEgyik.AutoSize = true;
            this.chkbEgyik.Location = new System.Drawing.Point(74, 64);
            this.chkbEgyik.Name = "chkbEgyik";
            this.chkbEgyik.Size = new System.Drawing.Size(52, 17);
            this.chkbEgyik.TabIndex = 0;
            this.chkbEgyik.Text = "Egyik";
            this.chkbEgyik.ThreeState = true;
            this.chkbEgyik.UseVisualStyleBackColor = true;
            this.chkbEgyik.CheckedChanged += new System.EventHandler(this.chkbEgyik_CheckedChanged);
            // 
            // chkbMasik
            // 
            this.chkbMasik.AutoSize = true;
            this.chkbMasik.Location = new System.Drawing.Point(74, 110);
            this.chkbMasik.Name = "chkbMasik";
            this.chkbMasik.Size = new System.Drawing.Size(54, 17);
            this.chkbMasik.TabIndex = 1;
            this.chkbMasik.Text = "Másik";
            this.chkbMasik.ThreeState = true;
            this.chkbMasik.UseVisualStyleBackColor = true;
            this.chkbMasik.CheckedChanged += new System.EventHandler(this.chkbMasik_CheckedChanged);
            // 
            // btnÁllapot
            // 
            this.btnÁllapot.Location = new System.Drawing.Point(182, 82);
            this.btnÁllapot.Name = "btnÁllapot";
            this.btnÁllapot.Size = new System.Drawing.Size(102, 23);
            this.btnÁllapot.TabIndex = 2;
            this.btnÁllapot.Text = "Állapot Váltása";
            this.btnÁllapot.UseVisualStyleBackColor = true;
            this.btnÁllapot.Click += new System.EventHandler(this.btnÁllapot_Click);
            // 
            // btnÉs
            // 
            this.btnÉs.Location = new System.Drawing.Point(74, 216);
            this.btnÉs.Name = "btnÉs";
            this.btnÉs.Size = new System.Drawing.Size(89, 23);
            this.btnÉs.TabIndex = 3;
            this.btnÉs.Text = "Logikai ÉS";
            this.btnÉs.UseVisualStyleBackColor = true;
            this.btnÉs.Click += new System.EventHandler(this.btnÉs_Click);
            // 
            // btnVagy
            // 
            this.btnVagy.Location = new System.Drawing.Point(74, 262);
            this.btnVagy.Name = "btnVagy";
            this.btnVagy.Size = new System.Drawing.Size(89, 23);
            this.btnVagy.TabIndex = 4;
            this.btnVagy.Text = "Logikai VAGY";
            this.btnVagy.UseVisualStyleBackColor = true;
            this.btnVagy.Click += new System.EventHandler(this.btnVagy_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(184, 242);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(769, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnVagy);
            this.Controls.Add(this.btnÉs);
            this.Controls.Add(this.btnÁllapot);
            this.Controls.Add(this.chkbMasik);
            this.Controls.Add(this.chkbEgyik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbEgyik;
        private System.Windows.Forms.CheckBox chkbMasik;
        private System.Windows.Forms.Button btnÁllapot;
        private System.Windows.Forms.Button btnÉs;
        private System.Windows.Forms.Button btnVagy;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnClose;
    }
}

