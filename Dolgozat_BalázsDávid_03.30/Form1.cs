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

namespace Dolgozat_BalázsDávid_03._30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Varos> adatok = new List<Varos>();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            File.ReadAllLines("varosok.csv", Encoding.Default).Skip(1).ToList().ForEach(x=>adatok.Add(new Varos(x)));

            foreach (var item in adatok)
            {
                lb_adatok.Items.Add($"{item.varosNev}");
            }

            btnOpen.BackColor = Color.Green;
            MessageBox.Show("Sikeres beolvasás");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A városok összlakossága");
            comboBox1.Items.Add("A legnépesebb város adatai");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="A városok összlakossága")
            {
                MessageBox.Show($"{adatok.Sum(x=>x.nepesseg)} millió fő", "A városok összlakossága");
            }
            if (comboBox1.SelectedItem== "A legnépesebb város adatai")
            {
                var legnepesebb = adatok.OrderBy(x => x.nepesseg).Last();
                MessageBox.Show($"{legnepesebb.varosNev} ({legnepesebb.orszagNev})\r\n{legnepesebb.nepesseg} millió fő", "A legnépesebb város adatai");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(lb_adatok.SelectedIndex);

            for (int i = 0; i < adatok.Count; i++)
            {
                if (i==selectedIndex)
                {
                    txtOrszag.Text = adatok[i].orszagNev;
                    txtNepesseg.Text = Convert.ToString(adatok[i].nepesseg);
                    txtVaros.Text = adatok[i].varosNev;
                }
            }
        }

        private void btnNewLoad_Click(object sender, EventArgs e)
        {
            txtOrszag.Text = "";
            txtVaros.Text = "";
            txtNepesseg.Text = "";
            btnLoad.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int errors = 0;
            if (txtOrszag.Text=="")
            {
                errors++;
                txtOrszag.BackColor = Color.Red;
            }
            if (txtVaros.Text=="")
            {
                errors++;
                txtVaros.BackColor = Color.Red;
            }
            if (txtNepesseg.Text == "")
            {
                errors++;
                txtNepesseg.BackColor = Color.Red;
            }

            if (errors>0)
            {
                MessageBox.Show($"{errors} mező üres!");
            }
            else
            {
                adatok.Add(new Varos(txtVaros.Text, txtOrszag.Text, Convert.ToDouble(txtNepesseg.Text)));
                lb_adatok.Items.Add(txtVaros.Text);

                txtOrszag.Text = "";
                txtVaros.Text = "";
                txtNepesseg.Text = "";

                btnLoad.Visible = false;
            }
        }

        private void txtOrszag_TextChanged(object sender, EventArgs e)
        {
            txtOrszag.BackColor = SystemColors.Window;
        }

        private void txtVaros_TextChanged(object sender, EventArgs e)
        {
            txtVaros.BackColor = SystemColors.Window;
        }

        private void txtNepesseg_TextChanged(object sender, EventArgs e)
        {
            txtNepesseg.BackColor = SystemColors.Window;
        }

        private void rbFelett_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFelett.Checked)
            {
                lb_adatok.Items.Clear();
                adatok.Where(x=>x.nepesseg>10).ToList().ForEach(x=>lb_adatok.Items.Add(x.varosNev));
                label5.Text = $"{lb_adatok.Items.Count} db";
                label5.Visible = true;
            }
            else if(rbAlatt.Checked)
            {
                lb_adatok.Items.Clear();
                adatok.Where(x => x.nepesseg < 10).ToList().ForEach(x => lb_adatok.Items.Add(x.varosNev));
                label5.Text = $"{lb_adatok.Items.Count} db";
                label5.Visible = true;
            }
        }

        private void rbAlatt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFelett.Checked)
            {
                lb_adatok.Items.Clear();
                adatok.Where(x => x.nepesseg > 10).ToList().ForEach(x => lb_adatok.Items.Add(x.varosNev));
                label5.Text = $"{lb_adatok.Items.Count} db";
                label5.Visible = true;
            }
            else if (rbAlatt.Checked)
            {
                lb_adatok.Items.Clear();
                adatok.Where(x => x.nepesseg < 10).ToList().ForEach(x => lb_adatok.Items.Add(x.varosNev));
                label5.Text = $"{lb_adatok.Items.Count} db";
                label5.Visible = true;
            }
        }

        private void chkStat_CheckedChanged(object sender, EventArgs e)
        {
            if (lb_adatok.Items.Count != 0)
            {
                if (chkStat.Checked) {
                    StreamWriter sw = new StreamWriter("statisztika.txt", false, Encoding.Default);
                    sw.WriteLine("Ország;Városok száma;Össznépesség (millió fő)");
                    adatok.GroupBy(x => x.orszagNev)
                        .Select(y => new
                        {
                            orszagNev = y.Key,
                            varosSzam = y.Count(),
                            összNép = y.Sum(x => x.nepesseg)
                        }).ToList().ForEach(x => sw.WriteLine($"{x.orszagNev};{x.varosSzam};{x.összNép} millió fő"));

                    sw.Close();
                    MessageBox.Show("Sikeres adatmentés", "Mentés");
                }
                chkStat.Checked = false;
            }
            else
            {
                MessageBox.Show("Előbb olvassa be az adatokat");
            }
        }
    }
}
