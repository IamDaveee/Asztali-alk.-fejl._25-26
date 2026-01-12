using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnKilép_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbVegan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbVegan.Checked)
            {
                rb1_1.Checked = true;
                txt1.Text = "1";
            }
            else
            {
                rb1_1.Checked = false;
                rb1_2.Checked = false;
                txt1.Text = "0";
            }
        }

        private void chkbMagyar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbMagyar.Checked)
            {
                rb2_1.Checked = true;
                txt2.Text = "1";
            }
            else
            {
                rb2_1.Checked = false;
                rb2_2.Checked = false;
                txt2.Text = "0";
            }
        }

        private void chkbNegysajt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbNegysajt.Checked)
            {
                rb3_1.Checked = true;
                txt3.Text = "1";
            }
            else
            {
                rb3_1.Checked = false;
                rb3_2.Checked = false;
                txt3.Text = "0";
            }
        }

        private void chkbSonka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbSonka.Checked)
            {
                rb4_1.Checked = true;
                txt4.Text = "1";
            }
            else
            {
                rb4_1.Checked = false;
                rb4_2.Checked = false;
                txt4.Text = "0";
            }
        }

        private void btnTöröl_Click(object sender, EventArgs e)
        {
            chkbVegan.Checked = false;
            chkbMagyar.Checked = false;
            chkbNegysajt.Checked = false;
            chkbSonka.Checked = false;

            rb1_1.Checked = false;
            rb1_2.Checked = false;
            rb2_1.Checked = false;
            rb2_2.Checked = false;
            rb3_1.Checked = false;
            rb3_2.Checked = false;
            rb4_1.Checked = false;
            rb4_2.Checked = false;

            txt1.Text = "0";
            txt2.Text = "0";
            txt2.Text = "0";
            txt4.Text = "0";

            txtÖsszegSum.Text = "";
            txtDarabSum.Text = "0";
        }
        private int StripFt(string összeg)
        {
            string[] darabolt = összeg.Split(' ');
            return Convert.ToInt32(darabolt[0]);
        }

        private void btnSzámol_Click(object sender, EventArgs e)
        {
            int sumösszeg = 0;
            int sumDarab = 0;

            if (chkbVegan.Checked)
            {
                if (rb1_1.Checked)
                {
                    sumDarab += Convert.ToInt32(txt1.Text);
                    sumösszeg += StripFt(rb1_1.Text) * Convert.ToInt32(txt1.Text);
                }
                else
                {
                    sumDarab += Convert.ToInt32(txt1.Text);
                    sumösszeg += StripFt(rb1_2.Text) * Convert.ToInt32(txt1.Text);
                }
            }

            if (chkbMagyar.Checked)
            {
                if (rb2_1.Checked)
                {
                    sumDarab += Convert.ToInt32(txt2.Text);
                    sumösszeg += StripFt(rb2_1.Text) * Convert.ToInt32(txt2.Text);
                }
                else
                {
                    sumDarab += Convert.ToInt32(txt2.Text);
                    sumösszeg += StripFt(rb2_2.Text) * Convert.ToInt32(txt2.Text);
                }
            }

            if (chkbNegysajt.Checked)
            {
                if (rb3_1.Checked)
                {
                    sumDarab += Convert.ToInt32(txt3.Text);
                    sumösszeg += StripFt(rb3_1.Text) * Convert.ToInt32(txt3.Text);
                }
                else
                {
                    sumDarab += Convert.ToInt32(txt3.Text);
                    sumösszeg += StripFt(rb3_2.Text) * Convert.ToInt32(txt3.Text);
                }
            }

            if (chkbSonka.Checked)
            {
                if (rb4_1.Checked)
                {
                    sumDarab += Convert.ToInt32(txt4.Text);
                    sumösszeg += StripFt(rb4_1.Text) * Convert.ToInt32(txt4.Text);
                }
                else
                {
                    sumDarab += Convert.ToInt32(txt4.Text);
                    sumösszeg += StripFt(rb4_2.Text) * Convert.ToInt32(txt4.Text);
                }
            }

            txtÖsszegSum.Text = Convert.ToString(sumösszeg) + " Ft";
            txtDarabSum.Text = Convert.ToString(sumDarab);
        }
    }
}
