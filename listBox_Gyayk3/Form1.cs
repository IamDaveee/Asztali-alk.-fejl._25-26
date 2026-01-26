using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox_Gyayk3
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Kerület: (a+b)*2 (Isti kedvéért)
            //Terület: a*b (Isti kedvéért)
            listBox1.Items.Add($"a= {Convert.ToInt32(textBox1.Text)}, b= {Convert.ToInt32(textBox2.Text)}, Ker= {(Convert.ToInt32(textBox1.Text)+ Convert.ToInt32(textBox2.Text)) *2}, Ter= {Convert.ToInt32(textBox1.Text)* Convert.ToInt32(textBox2.Text)}");
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
