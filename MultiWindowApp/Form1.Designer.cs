
namespace MultiWindowApp
{
    partial class MainForm
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
            this.btnOpenSecondForm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenSecondForm
            // 
            this.btnOpenSecondForm.Location = new System.Drawing.Point(98, 123);
            this.btnOpenSecondForm.Name = "btnOpenSecondForm";
            this.btnOpenSecondForm.Size = new System.Drawing.Size(180, 36);
            this.btnOpenSecondForm.TabIndex = 0;
            this.btnOpenSecondForm.Text = "Open Second Window";
            this.btnOpenSecondForm.UseVisualStyleBackColor = true;
            this.btnOpenSecondForm.Click += new System.EventHandler(this.btnOpenSecondForm_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOpenSecondForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSecondForm;
        private System.Windows.Forms.TextBox txtName;
    }
}

