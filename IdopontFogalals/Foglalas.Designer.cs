
namespace IdopontFogalals
{
    partial class Foglalas
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbSpecialist = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.btnFoglalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(82, 87);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cbHour.Location = new System.Drawing.Point(309, 87);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(38, 21);
            this.cbHour.TabIndex = 2;
            this.cbHour.Text = "H";
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cbMinute.Location = new System.Drawing.Point(353, 87);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(40, 21);
            this.cbMinute.TabIndex = 3;
            this.cbMinute.Text = "M";
            // 
            // cbSpecialist
            // 
            this.cbSpecialist.FormattingEnabled = true;
            this.cbSpecialist.Location = new System.Drawing.Point(309, 146);
            this.cbSpecialist.Name = "cbSpecialist";
            this.cbSpecialist.Size = new System.Drawing.Size(121, 21);
            this.cbSpecialist.TabIndex = 4;
            this.cbSpecialist.SelectedIndexChanged += new System.EventHandler(this.cbSpecialist_SelectedIndexChanged);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(437, 146);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 5;
            // 
            // btnFoglalas
            // 
            this.btnFoglalas.Location = new System.Drawing.Point(309, 226);
            this.btnFoglalas.Name = "btnFoglalas";
            this.btnFoglalas.Size = new System.Drawing.Size(75, 23);
            this.btnFoglalas.TabIndex = 6;
            this.btnFoglalas.Text = "Foglalás";
            this.btnFoglalas.UseVisualStyleBackColor = true;
            this.btnFoglalas.Click += new System.EventHandler(this.btnFoglalas_Click);
            // 
            // Foglalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFoglalas);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbSpecialist);
            this.Controls.Add(this.cbMinute);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "Foglalas";
            this.Text = "Foglalas";
            this.Load += new System.EventHandler(this.Foglalas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbSpecialist;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Button btnFoglalas;
    }
}