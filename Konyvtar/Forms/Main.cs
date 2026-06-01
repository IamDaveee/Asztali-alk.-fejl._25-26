using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konyvtar
{
    public partial class Main : Form
    {
        public Main(string felh, string book, string reserve)
        {
            InitializeComponent();
            felhPath = felh;
            konyvPath = book;
            foglalasPath = reserve;
        }

        static string felhPath = "";
        static string konyvPath = "";
        static string foglalasPath = "";

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FelhasznalokForm felhasznalok = new FelhasznalokForm(felhPath, konyvPath, foglalasPath);
            felhasznalok.FormClosed += (s, args) => this.Close();
            felhasznalok.Show();
            this.Hide();
        }
    }
}
