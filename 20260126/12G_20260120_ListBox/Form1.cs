using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _12G_20260120_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //elemek száma  textBox legyen csak olvasható
            txtB_darab.ReadOnly = true;
        }

        private void btn_HozzaAd_Click(object sender, EventArgs e)
        {
            //1. textBox-ban levő elemet adja a listBox-hoz
            //lB_elemek.Items.Add(txtb_elem.Text);
            //2. ha üres a textBox, ne adja hozzá, 
            //figyelmeztető üzenet küldése
            if (txtb_elem.Text=="")
            {
                MessageBox.Show("Adjon meg egy értéket!");
            }
            else
            {
                //adja hozzá
                lB_elemek.Items.Add(txtb_elem.Text);
                //ürítse ki a textBox-ot
                txtb_elem.Text = "";
                //jelenítse meg az elemek számát a textBox-ban
                txtB_darab.Text = lB_elemek.Items.Count.ToString();
            }

        }

        private void btn_Feltölt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                lB_elemek.Items.Add(rnd.Next(100).ToString());
            }
        }

        private void btn_Feltölt2_Click(object sender, EventArgs e)
        {
            //textBox-ba beírt elemszámmal töltse fel a listBox-ot
            lB_elemek.Items.Clear();
            try
            {
                //védett utasítások
                //meg akarod csinálni
                if (txtb_elem.Text=="")
                {
                    throw new Exception("Adjon meg értéket!");
                }
                Random rnd = new Random();
                for (int i = 0; i < Convert.ToInt32(txtb_elem.Text); i++)
                {
                    lB_elemek.Items.Add(rnd.Next(1000));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
            }
            finally
            {
                if (MessageBox.Show("program vége\nBiztosan ki akar lépni?","üzenet",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Folytatás");
                }
            }
        }

        private void btn_KijelöltTörlése_Click(object sender, EventArgs e)
        {
            //1. kijelölt elem törlése
            //lB_elemek.Items.RemoveAt(lB_elemek.SelectedIndex);
            try
            {
                if (lB_elemek.SelectedIndex==-1)
                {
                    throw new Exception("Nincs kijelölt elem.");
                }
                lB_elemek.Items.RemoveAt(lB_elemek.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btn_ÖsszesTörlése_Click(object sender, EventArgs e)
        {
            lB_elemek.Items.Clear();
        }

        private void btn_ElemVizsgalat_Click(object sender, EventArgs e)
        {
            //InputBox-ban adjuk meg a keresett elemet
            string input = Interaction.InputBox("Mit keressek?", "Kérdés", "0", 100, 100);
            int keresett = Convert.ToInt32(input);
            if (lB_elemek.Items.Contains(keresett))
            {
                MessageBox.Show("Benne van");
                lB_elemek.SelectedItem = input;
            }
            else
            {
                MessageBox.Show("Nincs benne");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lB_elemek.Sorted = true;
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lB_elemek.Items.Insert(3, "beszúrt elem");
        }

        private void lB_elemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Saját név";
        }
        NumericUpDown szamolos = new NumericUpDown();
        Form ablak = new Form();
        private void button3_Click(object sender, EventArgs e)
        {        
                  
            szamolos.Location = new Point(100, 100);
            ablak.Controls.Add(szamolos);
            szamolos.ValueChanged += Szamolos_ValueChanged;
            
            ablak.Show();
        }

        private void Szamolos_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < szamolos.Value; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button gomb = new Button();
                    gomb.Text = $"{i + 1}. gomb";
                    gomb.Size = new Size(50, 50);
                    gomb.Location = new Point(100 + i * 10, 100 + j * 10);
                    
                    ablak.Controls.Add(gomb);
                }
            }
        }
    }
}
