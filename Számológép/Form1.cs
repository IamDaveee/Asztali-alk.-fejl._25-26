using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Számológép
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double number1 = 0;
        static double number2 = 0;
        static string muvelet = "";
        static double vegeredmeny = 0;
        static bool isTwo = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Számológép";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text =="0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button1.Text;
            }
            else
            {
                txtBox_eredm.Text += button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button2.Text;
            }
            else
            {
                txtBox_eredm.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button3.Text;
            }
            else
            {
                txtBox_eredm.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button4.Text;
            }
            else
            {
                txtBox_eredm.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button5.Text;
            }
            else
            {
                txtBox_eredm.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button6.Text;
            }
            else
            {
                txtBox_eredm.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button7.Text;
            }
            else
            {
                txtBox_eredm.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button8.Text;
            }
            else
            {
                txtBox_eredm.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button9.Text;
            }
            else
            {
                txtBox_eredm.Text += button9.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtBox_eredm.Text == "0" || txtBox_eredm.Text == Convert.ToString(vegeredmeny))
            {
                txtBox_eredm.Text = button11.Text;
            }
            else
            {
                txtBox_eredm.Text += button11.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox_eredm.Text = "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            bool have = false;
            if (isTwo)
            {
                string[] numList = txtBox_eredm.Text.Split(' ');
                string num2 = numList[2];
                for (int i = 0; i < num2.Length; i++)
                {
                    if (txtBox_eredm.Text[i] == ',')
                    {
                        have = true;
                    }
                }
                if (txtBox_eredm.Text == "0" || have)
                {

                }
                else
                {
                    txtBox_eredm.Text += ",";
                }
            }
            else
            {
                for (int i = 0; i < txtBox_eredm.Text.Length; i++)
                {
                    if (txtBox_eredm.Text[i] == ',')
                    {
                        have = true;
                    }
                }
                if (txtBox_eredm.Text == "0" || have)
                {

                }
                else
                {
                    txtBox_eredm.Text += ",";
                }
            }
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtBox_eredm.Text += " + ";
            isTwo = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtBox_eredm.Text += " - ";
            isTwo = true;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtBox_eredm.Text += " * ";
            isTwo = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtBox_eredm.Text += " / ";
            isTwo = true;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string[] eredmeny = txtBox_eredm.Text.Split(' ');
            if (eredmeny.Length<2)
            {
                MessageBox.Show("Adjon meg 2 számot", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            number1 = Convert.ToDouble(eredmeny[0]);
            number2 = Convert.ToDouble(eredmeny[2]);
            muvelet = eredmeny[1];
            switch (muvelet)
            {
                case "+":
                    vegeredmeny = number1 + number2;
                    break;
                case "-":
                    vegeredmeny = number1 - number2;
                    break;
                case "*":
                    vegeredmeny = number1 * number2;
                    break;
                case "/":
                    vegeredmeny = number1 / number2;
                    break;
                default:
                    break;
            }
            txtBox_eredm.Text = Convert.ToString(vegeredmeny);
            isTwo = false;
        }
    }
}
