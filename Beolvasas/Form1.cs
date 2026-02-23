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
using Microsoft.VisualBasic;

namespace Beolvasas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<int> szamok = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("szamok.txt");
            if (File.Exists("szamok.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    szamok.Add(Convert.ToInt32(sor));
                    listBox1.Items.Add(Convert.ToInt32(sor));
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("A keresett fájl nem található.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in szamok)
            {
                if (item>0)
                {
                    listBox2.Items.Add(item);
                }
                if (item<0)
                {
                    listBox3.Items.Add(item);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int szam = Convert.ToInt32(textBox1.Text);
            if (szamok.Contains(szam))
            {
                MessageBox.Show("Már van ilyen szám a listában");
            }
            else
            {
                szamok.Add(szam);
                listBox1.Items.Add(szam);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("paros.txt");
            foreach (var item in szamok)
            {
                if (item%2==0)
                {
                    sw.WriteLine(item);
                }
            }
            sw.Close();
            MessageBox.Show("A kiírás megtörtént");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Számok Átlaga: {szamok.Average()}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in szamok)
            {
                if (item>=80)
                {
                    count++;
                }
            }
            MessageBox.Show($"80-nál nagyobb számok darabszáma: {count}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Legkisebb: {szamok.Min()}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Legnagyobb: {szamok.Max()}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sor = Interaction.InputBox("Kérdés","Mit Keresel?","",100,100);
            if (szamok.Contains(Convert.ToInt32(sor)))
            {
                listBox1.SetSelected(Convert.ToInt32(sor), true);
            }
            else
            {
                MessageBox.Show("Az elem nem szerepel a listában");
            }
        }
    }
}
