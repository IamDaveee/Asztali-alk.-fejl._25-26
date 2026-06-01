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

namespace Konyvtar
{
    public partial class FelhasznalokForm : Form
    {
        public FelhasznalokForm(string felh, string book, string reserve)
        {
            InitializeComponent();
            felhPath = felh;
            konyvPath = book;
            foglalasPath = reserve;
        }
        static string felhPath = "";
        static string konyvPath = "";
        static string foglalasPath = "";

        static List<Felhasznalok> felhasznalok = new List<Felhasznalok>();
        static List<konyvek> konyvek = new List<konyvek>();
        static List<foglalasok> foglalasok = new List<foglalasok>();

        static void ReadFiles()
        {
            felhasznalok.Clear();
            konyvek.Clear();
            foglalasok.Clear();
            File.ReadAllLines(felhPath).Skip(1).ToList().ForEach(x => felhasznalok.Add(new Felhasznalok(x)));
            File.ReadAllLines(konyvPath).Skip(1).ToList().ForEach(x => konyvek.Add(new konyvek(x)));
            File.ReadAllLines(foglalasPath).Skip(1).ToList().ForEach(x => foglalasok.Add(new foglalasok(x)));
        }

        static void writeFiles()
        {
            StreamWriter sw=new StreamWriter(felhPath);
            sw.WriteLine("felhId;nev;szulDatum;tel;email;belepesDatum");
            foreach (var item in felhasznalok)
            {
                sw.WriteLine($"{item.felhId};{item.nev};{item.szulDatum.Date};{item.tel};{item.email};{item.belepesDatum.Date}");
            }
            sw.Close();

            /*

            StreamWriter sw2 = new StreamWriter(konyvPath);
            sw.WriteLine("konyvId;cim;iro;oldalszam");
            foreach (var item in konyvek)
            {
                sw.WriteLine($"{item.konyvId};{item.cim};{item.iro};{item.oldalszam}");
            }
            sw.Close();

            */
            /*

            StreamWriter sw3 = new StreamWriter(foglalasPath);
            sw.WriteLine("felhId;konyvId;foglalasKezdete;foglalasVege");
            foreach (var item in foglalasok)
            {
                sw.WriteLine($"{item.felhId};{item.konyvId};{item.fogKezd.Date};{item.fogVeg.Date}");
            }
            sw.Close();

            */
        }

        private void FelhasznalokForm_Load(object sender, EventArgs e)
        {
            ReadFiles();
            //MessageBox.Show($"{felhasznalok.Count}\r\n{konyvek.Count}\r\n{foglalasok.Count}");
            foreach (var item in felhasznalok)
            {
                comboBox1.Items.Add($"{item.nev} - {item.email}");
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            felhasznalok.Where(x => x.nev.ToUpper().Contains(comboBox1.Text.ToUpper())).ToList().ForEach(x=>comboBox1.Items.Add($"{x.nev} - {x.email}"));
            comboBox1.SelectionStart = comboBox1.Text.Length;
            comboBox1.SelectionLength = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sor=comboBox1.Text.Split('-');
            comboBox1.Text = sor[0].Trim();
            var selectedMember = felhasznalok.Where(x => x.nev == sor[0].Trim() && x.email == sor[1].Trim());
            foreach (var item in selectedMember)
            {
                txtId.Text = item.felhId.ToString();
                txtNev.Text = item.nev;
                txtEmail.Text = item.email;
                txtTel.Text = item.tel;
                txtSzul.Text=item.szulDatum.ToString("yyyy-MM-dd");
                txtBelepes.Text=item.belepesDatum.ToString("yyyy-MM-dd");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnSave.Visible = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = false;
                }
            }
            txtId.ReadOnly = true;
            txtBelepes.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnEdit.Visible = true;

            for (int i = 0; i < felhasznalok.Count; i++)
            {
                if (felhasznalok[i].felhId==Convert.ToInt32(txtId.Text))
                {
                    felhasznalok[i].nev = txtNev.Text;
                    felhasznalok[i].tel = txtTel.Text;
                    felhasznalok[i].email = txtEmail.Text;
                    felhasznalok[i].szulDatum = Convert.ToDateTime(txtSzul.Text).Date;
                }
            }
            writeFiles();
            ReadFiles();
        }
    }
}
