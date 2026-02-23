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

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string lotto = "";
        private void btnLoadNum_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.Items.Clear();
                int i = 1;
                StreamReader sr = new StreamReader("lottosz.txt");
                if (File.Exists("lottosz.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        listBox1.Items.Add($"{i}.hét számai: {sor}");
                        i++;
                    }
                    sr.Close();
                    lotto = "otos";
                }
                else
                {
                    MessageBox.Show("Az ötös lottó számait tartalmazó file nem található!");
                }
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Clear();
                int i = 1;
                StreamReader sr = new StreamReader("hatos.txt");
                if (File.Exists("hatos.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        listBox1.Items.Add($"{i}.hét számai: {sor}");
                        i++;
                    }
                    sr.Close();
                    lotto = "hatos";
                }
                else
                {
                    MessageBox.Show("A hatos lottó számait tartalmazó file nem található!");
                }
            }
            label2.Text = $"A listában {listBox1.Items.Count} hét számai vannak";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("eredmeny.txt");
            if (listBox1.Items.Count<=0)
            {
                MessageBox.Show("A lista üres");
            }
            else
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item);
                }
                MessageBox.Show("A mentés megtörtént.");
            }
        }

        private void btnGivenWeek_Click(object sender, EventArgs e)
        {
            string sor = Interaction.InputBox("Kérdés", "Melyik hét számait keresi?", "", 100, 100);
            if (listBox1.Items.Count>=Convert.ToInt32(sor) && Convert.ToInt32(sor)>0)
            {
                listBox1.SelectedIndex=Convert.ToInt32(sor)-1;
                MessageBox.Show($"{listBox1.SelectedItem}");
            }
            else
            {
                MessageBox.Show("A lista nincs betöltve, vagy az adott hét nem szerepel a listában!");
            }
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (lotto=="otos")
            {
                string sor = $"{rnd.Next(1, 91)}" + $" {rnd.Next(1, 91)}" + $" {rnd.Next(1, 91)}" + $" {rnd.Next(1, 91)}" + $"{rnd.Next(1, 91)}";
                listBox1.Items.Add($"{listBox1.Items.Count + 1}.hét számai: {sor}");
            }
            else if (lotto=="hatos")
            {
                string sor = $"{rnd.Next(1, 46)}" + $" {rnd.Next(1, 46)}" + $" {rnd.Next(1, 46)}" + $" {rnd.Next(1, 46)}" + $" {rnd.Next(1, 46)}" + $"{rnd.Next(1,46)}";
                listBox1.Items.Add($"{listBox1.Items.Count + 1}.hét számai: {sor}");
            }
            else
            {
                MessageBox.Show("Nincsen lottó lista kiválasztva");
            }
            label2.Text = Convert.ToString($"A listában {listBox1.Items.Count} hét számai vannak");
        }
    }
}
