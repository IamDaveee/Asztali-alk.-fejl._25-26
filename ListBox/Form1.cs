using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt2.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txt1.Text=="")
            {
                MessageBox.Show("A szövegdoboz üres", "Hiba", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.Add(txt1.Text);
                txt1.Text = "";
                txt2.Text = Convert.ToString(listBox1.Items.Count);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                listBox1.Items.Add(rnd.Next(100).ToString());
            }
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                //védett utasítások
                //program feladata
                if (txt1.Text=="")
                {
                    throw new Exception("Adjon meg egy értéket");
                }
                Random rnd = new Random();
                for (int i = 0; i < Convert.ToInt32(txt1.Text); i++)
                {
                    listBox1.Items.Add(rnd.Next(1000).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (MessageBox.Show("Ez a program vége, biztosan ki akar lépni?","Figyelem", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Folytatás");
                }
            }
        }

        private void btnSelectDelete_Click(object sender, EventArgs e)
        {
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            try
            {
                if (listBox1.SelectedIndex==-1)
                {
                    throw new Exception("Nincs kijelölt elem");
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Mit keresek?","Kérdés","0", 100, 100);
            if (listBox1.Items.Contains(input))
            {
                MessageBox.Show("Benne van");
                listBox1.SelectedItem = input;
            }
            else
            {
                MessageBox.Show("Nincs benne");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            listBox1.Sorted=true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(3, "beszúrt elem");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Balázs Dávid";
        }
    }
}
