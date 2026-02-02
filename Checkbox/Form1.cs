using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnÁllapot_Click(object sender, EventArgs e)
        {
            chkbEgyik.Checked = !chkbEgyik.Checked;
            chkbMasik.Checked = !chkbMasik.Checked;
        }

        private void btnÉs_Click(object sender, EventArgs e)
        {
            bool es = chkbEgyik.Checked && chkbMasik.Checked;
            txtBox.Text = es ? "Igaz" : "Hamis";
        }

        private void btnVagy_Click(object sender, EventArgs e)
        {
            bool vagy = chkbEgyik.Checked || chkbMasik.Checked;
            MessageBox.Show(vagy ? "Igaz" : "Hamis");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbEgyik_CheckedChanged(object sender, EventArgs e)
        {
            Label cimke = new Label();
            cimke.Text = "Balázs Dávid";
            cimke.AutoSize = true;
            cimke.Location = new Point(300, 300);
            this.Controls.Add(cimke);
        }

        private void chkbMasik_CheckedChanged(object sender, EventArgs e)
        {
            Button kilepes = new Button();
            kilepes.Text = "Kilépés";
            kilepes.Location = new Point(200, 125);
            kilepes.Height = 75;
            kilepes.Width = 100;
            this.Controls.Add(kilepes);

            kilepes.Click += Kilepes_Click;
        }

        private void Kilepes_Click(object sender, EventArgs e)
        {
            DialogResult válasz=MessageBox.Show("Biztos Ki akarsz lépni?","Kilépés",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (válasz==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
