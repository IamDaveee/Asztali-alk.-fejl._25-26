using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Gyak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CountChanges()
        {
            lblCount.Text = Convert.ToString(listBox1.Items.Count);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Balázs Dávid";
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(100, 1000));
            }
            lblCount.Text = "";
            CountChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text=="")
            {
                MessageBox.Show("Üres mező", "Figyelem");
            }
            else
            {
                listBox1.Items.Add(Convert.ToString(txtBox1.Text));
            }
            txtBox1.Text = "";
            CountChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            CountChanges();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CountChanges();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                listBox1.Items.Add(rnd.Next(100, 1000));
            }
            CountChanges();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            int countDarab = 0;
            int countRemoved = 0;
            int listLength = listBox1.Items.Count;

            for (int i = 0; i < listLength; i++)
            {
                for (int j = 0; j < listLength; j++)
                {
                    if (Convert.ToString(listBox1.Items[j]) == Convert.ToString(listBox1.Items[i]))
                    {
                        countDarab++;
                        if (countDarab >= 2)
                        {
                            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.Items[j]));
                            countRemoved++;
                            countDarab--;
                            j--;
                            listLength--;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                countDarab = 0;
            }
            CountChanges();
            MessageBox.Show($"Kivett elemek száma: {countRemoved}");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            List<int> Szamok = new List<int>();
            foreach (var item in listBox1.Items)
            {
                Szamok.Add(Convert.ToInt32(item));
            }
            MessageBox.Show($"Összeg: {Szamok.Sum()}\nÁtlag: {Szamok.Average():0.00}");
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            List<int> Szamok = new List<int>();
            foreach (var item in listBox1.Items)
            {
                Szamok.Add(Convert.ToInt32(item));
            }
            listBox1.SetSelected(Convert.ToInt32(Szamok.IndexOf(Szamok.Min())), true);
        }
    }
}
