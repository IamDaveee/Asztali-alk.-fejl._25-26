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
        static int count = 1;
        bool answerShown = false;

        private void btnImport_Click(object sender, EventArgs e)
        {
            File.ReadAllLines("flashcards.csv", Encoding.Default).Skip(1).ToList().ForEach(x => adatok.Add(new Cards(x)));

            MessageBox.Show("Sikeres importálás.");

            txtQuestion.Text = Convert.ToString(adatok[count - 1].question);
            txtAnswer.Text = Convert.ToString(adatok[count - 1].answer);
            txtQuestion.Visible = true;
            txtAnswer.Visible = false;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            // Block flip if user is editing anything
            if ((answerShown && !txtAnswer.ReadOnly) ||
                (!answerShown && !txtQuestion.ReadOnly))
            {
                MessageBox.Show("Először mentse el a változtatásokat!");
                return;
            }

            answerShown = !answerShown;

            txtQuestion.Visible = !answerShown;
            txtAnswer.Visible = answerShown;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtAnswer.ReadOnly == false || txtQuestion.ReadOnly == false)
            {
                MessageBox.Show("Először mentse el a változtatásokat!");
            }
            else
            {
                if (adatok.Count < count + 1)
                {
                    return;
                }
                else
                {
                    numeric1.Value++;
                    count = Convert.ToInt32(numeric1.Value);
                    txtQuestion.Text = Convert.ToString(adatok[count - 1].question);
                    txtAnswer.Text = Convert.ToString(adatok[count - 1].answer);
                    txtQuestion.Visible = true;
                    txtAnswer.Visible = false;
                }
            }
        }

        private void btnPrew_Click(object sender, EventArgs e)
        {
            if (txtAnswer.ReadOnly == false || txtQuestion.ReadOnly == false)
            {
                MessageBox.Show("Először mentse el a változtatásokat!");
            }
            else
            {
                if (count - 1 < 1)
                {
                    return;
                }
                else
                {
                    numeric1.Value--;
                    count = Convert.ToInt32(numeric1.Value);
                    txtQuestion.Text = Convert.ToString(adatok[count - 1].question);
                    txtAnswer.Text = Convert.ToString(adatok[count - 1].answer);
                    txtQuestion.Visible = true;
                    txtAnswer.Visible = false;
                }
            }
        }

        private void numeric1_ValueChanged(object sender, EventArgs e)
        {
            if (txtAnswer.ReadOnly == false || txtQuestion.ReadOnly == false)
            {
                MessageBox.Show("Először mentse el a változtatásokat!");
                numeric1.Value = count;
            }
            else
            {
                count = Convert.ToInt32(numeric1.Value);
                txtQuestion.Text = Convert.ToString(adatok[count - 1].question);
                txtAnswer.Text = Convert.ToString(adatok[count - 1].answer);
                txtQuestion.Visible = true;
                txtAnswer.Visible = false;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Button cardSave = new Button();
            cardSave.Width = 75;
            cardSave.Height = 23;
            cardSave.Text = "Save";
            cardSave.Location = new Point(406, 127);
            cardSave.Name = "btnCardSave";
            cardSave.Visible = true;
            this.Controls.Add(cardSave); //Hozzáadás a programhoz és ezzel megjelenítés
            cardSave.Click += cardSave_Click; //Click esemény kezelése, hogy lehessen Click funkciókat hozzáadni

            if (answerShown)
            {
                btnEdit.Visible = false;
                txtAnswer.ReadOnly = false;
                txtAnswer.Enabled = true;
            }
            else if (!answerShown)
            {
                btnEdit.Visible = false;
                txtQuestion.ReadOnly = false;
                txtQuestion.Enabled = true;
            }
        }

        private void cardSave_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //A funkció ami lefut az újonnan hozzáadott gomb Click eseményére
            if (answerShown)
            {
                adatok[count - 1].answer = txtAnswer.Text.ToString();
                txtAnswer.ReadOnly = true;
                txtAnswer.Enabled = false;
            }
            else if (!answerShown)
            {
                adatok[count - 1].question = txtQuestion.Text.ToString();
                txtQuestion.ReadOnly = true;
                txtQuestion.Enabled = false;
            }

            btnEdit.Visible = true;
            btn.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            adatok.Remove(adatok[count - 1]);
            txtQuestion.Text = adatok[count - 1].question;
            txtAnswer.Text = adatok[count - 1].answer;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button cardAdd = new Button();
            cardAdd.Width = 75;
            cardAdd.Height = 23;
            cardAdd.Text = "Next";
            cardAdd.Location = new Point(406, 185);
            cardAdd.Name = "btnAddCard";
            cardAdd.Visible = true;
            this.Controls.Add(cardAdd); //Hozzáadás a programhoz és ezzel megjelenítés
            cardAdd.Click += cardAdd_Click; //Click esemény kezelése, hogy lehessen Click funkciókat hozzáadni

            adatok.Add(new Cards("", ""));
            count = adatok.Count;
            numeric1.Value = count;
            txtQuestion.Text = adatok[count-1].question;
            txtAnswer.Text = adatok[count-1].answer;

            txtQuestion.ReadOnly = false;
            txtQuestion.Enabled = true;
        }
        private void cardAdd_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            bool DoneState = false;
            if (DoneState == false)
            {
                adatok[count-1].question = txtQuestion.Text.ToString();
                btn.Text = "Done";
                txtQuestion.ReadOnly = true;
                txtQuestion.Enabled = false;
                DoneState = true;

                txtAnswer.ReadOnly = false;
                txtAnswer.Enabled = true;

                txtQuestion.Visible = false;
                txtAnswer.Visible = true;

                answerShown = true;
            }
            if (DoneState)
            {
                adatok[count-1].answer = txtAnswer.Text.ToString();
                btn.Visible = false;
                txtAnswer.ReadOnly = true;
                txtAnswer.Enabled = false;

                answerShown = false;
                txtQuestion.Visible = true;
                txtAnswer.Visible = false;
            }
        }
    }
}
