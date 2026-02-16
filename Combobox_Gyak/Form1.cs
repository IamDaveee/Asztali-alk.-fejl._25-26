using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Combobox_Gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (comboBox1.SelectedIndex==0)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < 20; i++)
                {
                    listBox1.Items.Add(Convert.ToInt32(i+1));
                }
            }
            if (comboBox1.SelectedIndex==1)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < 20; i++)
                {
                    listBox1.Items.Add(rnd.Next(100, 1000));
                }
            }
            if (comboBox1.SelectedIndex==2)
            {
                string szo = "";
                for (int i = 0; i < 10; i++)
                {
                    szo = Interaction.InputBox($"{i+1}. szó", $"10 db szó", "", 100, 100);
                    if (listBox1.Items.Contains(szo))
                    {
                        if (MessageBox.Show("Ilyen elem már létezik. Hozzáadja?", "Figyelmeztetés", MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            listBox1.Items.Add(Convert.ToString(szo));
                        }
                    }
                    else
                    {
                        listBox1.Items.Add(Convert.ToString(szo));
                    }
                }
            }
            if (comboBox1.SelectedIndex==3)
            {
                for (char i = 'a'; i <= 'z'; i++)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lb_eredm1.Items.Clear();
                lb_eredm1.Visible = true;
                lb_eredm2.Visible = false;
                label3.Text = "Páros számok";
                label3.Visible = true;
                label4.Visible = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i])%2==0)
                    {
                        lb_eredm1.Items.Add(listBox1.Items[i]);
                    }
                }
            }
            else
            {
                lb_eredm2.Items.Clear();
                lb_eredm2.Visible = true;
                lb_eredm1.Visible = false;
                label4.Text = "Páratlan számok";
                label4.Visible = true;
                label3.Visible = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                    {
                        lb_eredm2.Items.Add(listBox1.Items[i]);
                    }
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label3.Text = "Nagybetűs:";
                label3.Visible = true;
                lb_eredm1.Items.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    lb_eredm1.Items.Add(listBox1.Items[i].ToString().ToUpper());
                }
                lb_eredm1.Visible = true;
            }
            if (checkBox2.Checked)
            {
                label4.Text = "Hossza:";
                label4.Visible = true;
                lb_eredm2.Items.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    lb_eredm2.Items.Add(Convert.ToInt32(listBox1.Items[i].ToString().Count()));
                }
                lb_eredm2.Visible = true;
            }
            if (!checkBox1.Checked)
            {
                label3.Visible = false;
                lb_eredm1.Visible = false;
            }
            if (!checkBox2.Checked)
            {
                label4.Visible = false;
                lb_eredm2.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
