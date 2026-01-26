using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Gyak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBox.Text=="")
            {
                MessageBox.Show("Ne hagyd üresen a mezőt!", "Figyelem");
            }
            else
            {
                listBox1.Items.Add(Convert.ToString(txtBox.Text));
                listBox2.Items.Add(Convert.ToInt32(txtBox.Text.Count()));
                txtBox.Text = "";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox2.Items.Clear();
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(Convert.ToInt32(Convert.ToString(item).Count()));
            }
        }
    }
}
