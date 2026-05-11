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

namespace TotoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox1.Text.Length<14)
            {
                checkBox1.Checked=true;
                label1.Text = $"Nem megfelelő a karakterek száma ({textBox1.Text.Length})";
            }
            else if (textBox1.Text.Length>=14)
            {
                checkBox1.Checked = false;
                label2.Text = $"Nem megfelelő a karakterek száma ({textBox1.Text.Length})";
            }
            string karakter = "";

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char c = textBox1.Text[i];

                if (c != '1' && c != '2' && c != 'X')
                {
                    count++;
                    karakter += c + "; ";
                }
            }

            checkBox2.Checked = count > 0;

            if (count > 0)
            {
                label3.Text = $"Helytelen karakter az eredményben ({karakter})";
            }
            else
            {
                label3.Text = "Helytelen karakter az eredményben ()";
            }

            if (checkBox1.Checked || checkBox2.Checked)
            {
                button1.Enabled = false;
            }
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("eredmeny.txt", true, Encoding.Default);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            MessageBox.Show("Sikeres mentés.");
        }
    }
}
