using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga_Gyak_02._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_1.Text = "";
        }

        private void txtB_Be_TextChanged(object sender, EventArgs e)
        {
            lbl_1.Text = txtB_Be.Text.ToString();
            lbl_1.ForeColor = Color.Red;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                lb_1.Items.Add(rnd.Next(10,100));
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lb_1.Sorted = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lbl_1.Text=="")
            {
                MessageBox.Show("A mező üres", "Figyelmeztetés");
            }
            else
            {
                if (lb_2.Items.Contains(lbl_1.Text))
                {
                    MessageBox.Show("Az elem már szerepel a listában");
                }
                else
                {
                    lb_2.Items.Add(lbl_1.Text.ToString());
                    label2.Text = lb_2.Items.Count.ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                int selectedIndex=lb_1.SelectedIndex;
                lb_1.Items.RemoveAt(selectedIndex);
            }
            else if (rb2.Checked)
            {
                lb_1.Items.RemoveAt(0);
            }
            MessageBox.Show($"A lista elemszáma: {lb_1.Items.Count}");
        }

        private void btnSorozat_Click(object sender, EventArgs e)
        {
            if (chkBox1.Checked)
            {
                for (int i = 1; i <= 10; i++)
                {
                    lb_1.Items.Add(i);
                }
            }
            if (chkBox2.Checked)
            {
                for (int i = 11; i <= 20; i++)
                {
                    lb_1.Items.Add(i);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
