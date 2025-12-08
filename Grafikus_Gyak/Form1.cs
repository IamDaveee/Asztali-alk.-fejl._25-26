using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafikus_Gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Balázs Dávid";
            this.BackColor = Color.LightGray;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNev_Click(object sender, EventArgs e)
        {
            if (TxtVezetek.Text =="" && TxtKereszt.Text=="")
            {
                MessageBox.Show("Adja meg a teljes nevet: ", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (TxtVezetek.Text=="")
                {
                    MessageBox.Show("Adja meg a Vezetéknevet: ", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (TxtKereszt.Text=="")
                    {
                        MessageBox.Show("Adja meg a Keresztnevet: ", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lblNev.Text = TxtVezetek.Text + " " + TxtKereszt.Text;
                        lblNev.BackColor = Color.Black;
                        lblNev.ForeColor = Color.White;
                        lblNev.Visible = true;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblPow.Visible = false;
            lblGyok.Visible = false;
            lblAbs.Visible = false;
            if (txtNumber.Text=="")
            {
                MessageBox.Show("Adjon meg egy számot: ", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblNumber.Visible = false;
            }
            else
            {
                if (txtNumber.Text=="0")
                {
                    lblNumber.Text = "Nulla";
                }
                else if (txtNumber.Text[0]=='-')
                {
                    lblNumber.Text = "Negatív";
                }
                else
                {
                    lblNumber.Text = "Pozitív";
                }
                lblNumber.Visible = true;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text=="")
            {
                MessageBox.Show("Adjon meg egy számot: ", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPow.Visible = false;
                lblGyok.Visible = false;
                lblAbs.Visible = false;
            }
            else
            {
                double number = Convert.ToDouble(txtNumber.Text);

                lblPow.Text = Convert.ToString(Math.Pow(number, 2));
                lblAbs.Text = Convert.ToString(Math.Abs(number));
                if (lblNumber.Text=="Negatív")
                {
                    MessageBox.Show("A gyök alatt nincs mínusz: ", "Figyelmeztetés", MessageBoxButtons.OK);
                    lblGyok.Text = "xxxx";
                }
                else
                {
                    lblGyok.Text = Convert.ToString(Math.Sqrt(number));
                }
                lblPow.Visible = true;
                lblGyok.Visible = true;
                lblAbs.Visible = true;
            }
        }
    }
}
