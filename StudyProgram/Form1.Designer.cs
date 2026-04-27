
namespace StudyProgram
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnPrew = new System.Windows.Forms.Button();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Location = new System.Drawing.Point(176, 98);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(103, 59);
            this.txtQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Location = new System.Drawing.Point(176, 98);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(103, 59);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.Visible = false;
            // 
            // btnPrew
            // 
            this.btnPrew.Location = new System.Drawing.Point(176, 214);
            this.btnPrew.Name = "btnPrew";
            this.btnPrew.Size = new System.Drawing.Size(28, 23);
            this.btnPrew.TabIndex = 2;
            this.btnPrew.Text = "<--";
            this.btnPrew.UseVisualStyleBackColor = true;
            this.btnPrew.Click += new System.EventHandler(this.btnPrew_Click);
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(211, 217);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(34, 20);
            this.numeric1.TabIndex = 3;
            this.numeric1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric1.ValueChanged += new System.EventHandler(this.numeric1_ValueChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(251, 214);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "-->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(325, 98);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(325, 127);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(325, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(190, 185);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 23);
            this.btnFlip.TabIndex = 9;
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.btnPrew);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnPrew;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnAdd;
    }
}

