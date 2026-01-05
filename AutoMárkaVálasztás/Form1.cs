using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMárkaVálasztás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if (rbAudi.Checked)
            {
                MessageBox.Show("Audi");
                pictureBox1.Image = Image.FromFile("Audi.JPG");
            }
            if (rbBmw.Checked)
            {
                MessageBox.Show("BMW");
                pictureBox1.Image = Image.FromFile("bmw.png");
            }
            if (rbMerceddes.Checked)
            {
                MessageBox.Show("Mercedes");
                pictureBox1.Image = Image.FromFile("mercedes.png");
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rbPiros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPiros.Checked)
            {
                if (rbAudi.Checked)
                {
                    pictureBox1.Image = Image.FromFile("pirosAudi.jpg");
                }
                if (rbBmw.Checked)
                {
                    pictureBox1.Image = Image.FromFile("pirosBMW.png");
                }
                if (rbMerceddes.Checked)
                {
                    pictureBox1.Image = Image.FromFile("pirosMercedes.jpg");
                }
            }
            else if (rbKek.Checked)
            {
                if (rbAudi.Checked)
                {
                    pictureBox1.Image = Image.FromFile("kékAudi.jpg");
                }
                if (rbBmw.Checked)
                {
                    pictureBox1.Image = Image.FromFile("kékBMW.jpg");
                }
                if (rbMerceddes.Checked)
                {
                    pictureBox1.Image = Image.FromFile("kékMercedes.jpg");
                }
            }
            else if (rbSarga.Checked)
            {
                if (rbAudi.Checked)
                {
                    pictureBox1.Image = Image.FromFile("sárgaAudi.jpg");
                }
                if (rbBmw.Checked)
                {
                    pictureBox1.Image = Image.FromFile("sárgaBMW.jpg");
                }
                if (rbMerceddes.Checked)
                {
                    pictureBox1.Image = Image.FromFile("sárgaMercedes.jpg");
                }
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
