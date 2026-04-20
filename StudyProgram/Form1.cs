using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Cards> adatok = new List<Cards>();
        static int count=1;
        bool answerShown = false;

        private void btnImport_Click(object sender, EventArgs e)
        {
            File.ReadAllLines("flashcards.csv", Encoding.Default).Skip(1).ToList().ForEach(x=>adatok.Add(new Cards(x)));

            MessageBox.Show("Sikeres importálás.");

            txtQuestion.Text = Convert.ToString(adatok[count-1].question);
            txtAnswer.Text = Convert.ToString(adatok[count - 1].answer);
            txtQuestion.Visible = true;
            txtAnswer.Visible = false;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (answerShown)
            {
                txtQuestion.Visible = true;
                txtAnswer.Visible = false;
                answerShown = false;
            }
            else
            {
                txtAnswer.Visible = true;
                txtQuestion.Visible = false;
                answerShown = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numeric1.Value++;
            count = Convert.ToInt32(numeric1.Value);
            txtQuestion.Text = Convert.ToString(adatok[count-1].question);
            txtAnswer.Text = Convert.ToString(adatok[count-1].answer);
            txtQuestion.Visible = true;
            txtAnswer.Visible = false;
        }

        private void btnPrew_Click(object sender, EventArgs e)
        {
            numeric1.Value--;
            count = Convert.ToInt32(numeric1.Value);
            txtQuestion.Text = Convert.ToString(adatok[count-1].question);
            txtAnswer.Text = Convert.ToString(adatok[count-1].answer);
            txtQuestion.Visible = true;
            txtAnswer.Visible = false;
        }
    }
}
