using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat_BalázsDávid_02._16
{
    public partial class Form1 : Form
    {
        static List<int> szamok = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int szam = rnd.Next(-200, 500);
                lbElemek.Items.Add(szam);
                szamok.Add(szam);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtBox.Text=="")
            {
                MessageBox.Show("A mező üres!");
            }
            else
            {
                if (lbElemek.Items.Contains(Convert.ToInt32(txtBox.Text)))
                {
                    lbElemek.SelectedItem = Convert.ToInt32(txtBox.Text);
                }
                else
                {
                    MessageBox.Show($"A keresett elem ({Convert.ToInt32(txtBox.Text)}) nem található");
                }
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                MessageBox.Show($"A legkisebb negatív szám: {szamok.Min()}");
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                MessageBox.Show($"A legnagyobb pozitív szám: {szamok.Max()}");
            }
        }

        private void chkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox1.Checked)
            {
                combox.Items.Add("Lista elemeinek összege");
            }
            else
            {
                combox.Items.Remove("Lista elemeinek összege");
            }
        }

        private void chkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox2.Checked)
            {
                combox.Items.Add("Pozitív számok darabszáma");
            }
            else
            {
                combox.Items.Remove("Pozitív számok darabszáma");
            }
        }

        private void chkbox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox3.Checked)
            {
                combox.Items.Add("Szétválogatás");
            }
            else
            {
                combox.Items.Remove("Szétválogatás");
            }
        }

        private void combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox.SelectedItem=="Lista elemeinek összege")
            {
                MessageBox.Show($"A lista elemeinek összege: {szamok.Sum()}");
            }
            if (combox.SelectedItem == "Pozitív számok darabszáma")
            {
                int darab = 0;
                foreach (var item in szamok)
                {
                    if (item>0)
                    {
                        darab++;
                    }
                }
                MessageBox.Show($"A lista pozitív elemeinek száma: {darab}");
            }
            if (combox.SelectedItem == "Szétválogatás")
            {
                foreach (var item in szamok)
                {
                    if (item%3==0)
                    {
                        lbHarom.Items.Add(item);
                    }
                    if (item%5==0)
                    {
                        lbOt.Items.Add(item);
                    }
                }
                lbHarom.Visible = true;
                lbOt.Visible = true;
                label2.Text = Convert.ToString(lbHarom.Items.Count) + " db";
                label3.Text = Convert.ToString(lbOt.Items.Count) + " db";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Button exit = new Button();
            exit.Width = 80;
            exit.Height = 60;
            exit.Text = "Kilépés";
            exit.Location = new Point(600, 100);
            exit.Name = "btnClose";
            this.Controls.Add(exit);
            exit.Click += Exit_Click;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
