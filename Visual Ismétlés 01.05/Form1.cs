using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Ismétlés_01._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSzoveg.Visible = true;
            lblSzoveg.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            if (txtSugar.Text!="")
            {
                int sugar = Convert.ToInt32(txtSugar.Text);
                if (rdbKor.Checked)
                {
                    double kerület = 2 * sugar * Math.PI;
                    lblKerület.Text = "A kör kerülete: " + Math.Round(kerület, 2);
                    double terulet = Math.Pow(sugar, 2) * Math.PI;
                    lblTerület.Text = "A kör területe: " + Math.Round(terulet, 2);
                }
                else
                {
                    double kerület = 4*sugar;
                    lblKerület.Text = "A négyzet kerülete: " + Math.Round(kerület, 2);
                    double terulet = Math.Pow(sugar, 2);
                    lblTerület.Text = "A négyzet területe: " + Math.Round(terulet, 2);
                }
            }
            else
            {
                if (rdbKor.Checked)
                {
                    MessageBox.Show("Adjon meg egy sugarat");
                }
                else
                {
                    MessageBox.Show("Adja meg egy oldal hosszát!");
                }
            }
        }

        private int LNKO(int a, int b)
        {
            while (a!=b)
            {
                if (a<b)
                {
                    b = b - a;
                }
                else
                {
                    a = a - b;
                }
            }
            return a;
        }

        private int LNKO_Rekurziv(int a, int b)
        {
            if (a==0)
            {
                return b;
            }
            if (b==0)
            {
                return a;
            }
            if (a>b)
            {
                return LNKO_Rekurziv(a % b, b);
            }
            else
            {
                return LNKO_Rekurziv(a, b % a);
            }
        }
        private void rdbLNKO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLNKO.Checked)
            {
                int a = Convert.ToInt32(txta.Text);
                int b = Convert.ToInt32(txtb.Text);

                int lnko = LNKO(a, b);
                MessageBox.Show("A két számnak a legnagyobb közös osztólya: " + lnko);
            }
            else
            {
                int a = Convert.ToInt32(txta.Text);
                int b = Convert.ToInt32(txtb.Text);

                int lnko = LNKO(a, b);
                int lkkt = a * b / lnko;
                MessageBox.Show("A két számnak a legkisebb közös többszöröse: " + lkkt);
            }
        }

        private void btnRekurziv_Click(object sender, EventArgs e)
        {
            if (rdbLNKO.Checked)
            {
                int a = Convert.ToInt32(txta.Text);
                int b = Convert.ToInt32(txtb.Text);

                int lnko = LNKO_Rekurziv(a, b);
                MessageBox.Show("A két számnak a legnagyobb közös osztólya: " + lnko);
            }
            else
            {
                int a = Convert.ToInt32(txta.Text);
                int b = Convert.ToInt32(txtb.Text);

                int lnko = LNKO_Rekurziv(a, b);
                int lkkt = a * b / lnko;
                MessageBox.Show("A két számnak a legkisebb közös többszöröse: " + lkkt);
            }
        }
    }
}
