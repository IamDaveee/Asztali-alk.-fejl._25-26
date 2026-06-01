using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Konyvtar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int count = 0;

        static string felhPath = "";
        static string konyvPath = "";
        static string foglalasPath = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kérem válassza ki a fájl típusát, majd kattintson az Importálás gombra\r\nAz alkalmazásnak 3-ra lesz szüksége a rendeltetés szerű működéshez");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
            felhPath = @"C:\\Users\\Dávid\\source\\repos\\Konyvtar\\bin\\Debug\\felhasznalok.txt";
            konyvPath = @"C:\Users\Dávid\source\repos\Konyvtar\bin\Debug\\konyvek.txt";
            foglalasPath = @"C:\Users\Dávid\source\repos\Konyvtar\bin\Debug\\foglalasok.txt";
            
            /*
            string filePath = "";
            string selected=comboBox1.Text;
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Kérem előbb válassza ki a fájl típusát, majd kattintson az Importálás gombra");
                return;
            }
            else
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Válasszon ki egy fájlt a beolvasáshoz!";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Kérem egy valós fájl kiválasztását!");
                    return;
                }
                else
                {
                    switch (selected)
                    {
                        case "Felhasználók":
                            felhPath = filePath;
                            MessageBox.Show(felhPath);
                            break;

                        case "Könyvek":
                            konyvPath = filePath;
                            MessageBox.Show(konyvPath);
                            break;

                        case "Foglalások":
                            foglalasPath = filePath;
                            MessageBox.Show(foglalasPath);
                            break;
                    }
                    MessageBox.Show("Sikeres importálás");
                    count++;
                }
            }
            */
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*if (count<3)
            {
                MessageBox.Show("Előbb importálja be a fájlokat.");
                return;
            }
            else
            {
                Main mainForm = new Main(felhPath, konyvPath, foglalasPath);
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
                this.Hide();
            } */

            Main mainForm = new Main(felhPath, konyvPath, foglalasPath);
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
            this.Hide();
        }
    }
}
