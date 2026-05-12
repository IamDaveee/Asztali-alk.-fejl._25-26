
namespace IdopontFogalals
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFoglalas = new System.Windows.Forms.Button();
            this.btnLekerdezes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(328, 83);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(180, 13);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Please Log in to use all the functions";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(632, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnFoglalas
            // 
            this.btnFoglalas.Location = new System.Drawing.Point(153, 169);
            this.btnFoglalas.Name = "btnFoglalas";
            this.btnFoglalas.Size = new System.Drawing.Size(175, 130);
            this.btnFoglalas.TabIndex = 3;
            this.btnFoglalas.Text = "Időpont foglalás";
            this.btnFoglalas.UseVisualStyleBackColor = true;
            // 
            // btnLekerdezes
            // 
            this.btnLekerdezes.Location = new System.Drawing.Point(497, 169);
            this.btnLekerdezes.Name = "btnLekerdezes";
            this.btnLekerdezes.Size = new System.Drawing.Size(175, 130);
            this.btnLekerdezes.TabIndex = 4;
            this.btnLekerdezes.Text = "Időpont lekérdezése";
            this.btnLekerdezes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLekerdezes);
            this.Controls.Add(this.btnFoglalas);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblGreeting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFoglalas;
        private System.Windows.Forms.Button btnLekerdezes;
    }
}

