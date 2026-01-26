using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                listBox1.Items.Add(rnd.Next(1, 50));
            }

            foreach (var item in listBox1.Items)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    listBox2.Items.Add(item);
                }
                else
                {
                    listBox3.Items.Add(item);
                }
            }
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            int countParos = 0;
            int countParatlan = 0;
            foreach (var item in listBox2.Items)
            {
                countParos += Convert.ToInt32(item);
            }
            foreach (var item in listBox3.Items)
            {
                countParatlan += Convert.ToInt32(item);
            }
            MessageBox.Show($"A páros számok összege: {countParos}\nA páratlan számok összege: {countParatlan}", "Eredmény");
        }
    }
}
