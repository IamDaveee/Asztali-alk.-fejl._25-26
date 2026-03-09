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

namespace Dolgozo_03._09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Dolgozo> adatok = new List<Dolgozo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            File.ReadAllLines("dolgozo.txt").Skip(1).ToList().ForEach(x=>adatok.Add(new Dolgozo(x)));

            foreach (var item in adatok)
            {
                comboBox1.Items.Add(item.nev);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtInputNev.Text=="")
            {
                MessageBox.Show("Üres beviteli mező!");
            }
            else
            {
                if (comboBox1.Items.Contains(txtInputNev.Text))
                {
                    if (MessageBox.Show("Ilyen elem már létezik. Hozzáadja?", "Figyelmeztetés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        comboBox1.Items.Add(Convert.ToString(txtInputNev.Text));
                        string ujMunkakor = Interaction.InputBox("Munkakör?", "dolgozok", "", 100, 100);
                        string ujFizetes = Interaction.InputBox("Fizetés?", "dolgozok", "", 100, 100);

                        adatok.Add(new Dolgozo($"{txtInputNev.Text} {ujMunkakor} {ujFizetes}"));

                        txtInputNev.Text = "";
                    }
                }
                else
                {
                    comboBox1.Items.Add(Convert.ToString(txtInputNev.Text));
                    string ujMunkakor = Interaction.InputBox("Munkakör?", "dolgozok", "", 100, 100);
                    string ujFizetes = Interaction.InputBox("Fizetés?", "dolgozok", "", 100, 100);

                    adatok.Add(new Dolgozo($"{txtInputNev.Text} {ujMunkakor} {ujFizetes}"));

                    txtInputNev.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = Convert.ToString(comboBox1.SelectedItem);
            foreach (var item in adatok)
            {
                if (item.nev == selectedName)
                {
                    txtNev.Text = item.nev;
                    txtFizetes.Text = Convert.ToString(item.fizetes);
                    txtMunka.Text = item.munkakor;
                }
            }

            txtPlusMinus.Text = Convert.ToString(comboBox1.SelectedIndex+1);
        }

        private void txtPlusMinus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int szam = Convert.ToInt32(txtPlusMinus.Text);
            if (szam+1>adatok.Count)
            {
                MessageBox.Show("Elérte a lista végét");
            }
            else
            {
                comboBox1.SelectedIndex = szam;

                string selectedName = Convert.ToString(comboBox1.SelectedItem);
                foreach (var item in adatok)
                {
                    if (item.nev == selectedName)
                    {
                        txtNev.Text = item.nev;
                        txtFizetes.Text = Convert.ToString(item.fizetes);
                        txtMunka.Text = item.munkakor;
                    }
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int szam = Convert.ToInt32(txtPlusMinus.Text);
            if (szam-2<0)
            {
                MessageBox.Show("elérte a lista elejét");
            }
            else
            {
                comboBox1.SelectedIndex = szam - 2;

                string selectedName = Convert.ToString(comboBox1.SelectedItem);
                foreach (var item in adatok)
                {
                    if (item.nev == selectedName)
                    {
                        txtNev.Text = item.nev;
                        txtFizetes.Text = Convert.ToString(item.fizetes);
                        txtMunka.Text = item.munkakor;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Új fájlba kívánja menteni az adatokat?", "Kérdés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string fajlNev = Interaction.InputBox("Mi legyen az új fájl neve?", "Fájlnév", "", 100, 100);
                StreamWriter sw = new StreamWriter($"{fajlNev}.txt");
                sw.WriteLine("Név Munkakör Fizetés");
                foreach (var item in adatok)
                {
                    sw.WriteLine($"{item.nev} {item.munkakor} {item.fizetes}");
                }
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("dolgozo.txt");
                sw.WriteLine("Név Munkakör Fizetés");
                foreach (var item in adatok)
                {
                    sw.WriteLine($"{item.nev} {item.munkakor} {item.fizetes}");
                }
                sw.Close();
            }

            MessageBox.Show("Adatok sikeresen elmentve.");
        }
    }
}
