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

namespace OrvosiNobeldijasokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<string> hibák = new List<string>();

            if (txtEv.Text=="")
            {
                count++;
                hibák.Add("Az Év mező üres!");
                //txtEv.BackColor = Color.Red;
            }
            if (txtNev.Text=="")
            {
                count++;
                hibák.Add("A Név mező üres!");
                //txtNev.BackColor = Color.Red;
            }
            if (txtSzul.Text=="")
            {
                count++;
                hibák.Add("A Születés/Halál mező üres!");
                //txtNev.BackColor = Color.Red;
            }
            if (txtOrszag.Text=="")
            {
                count++;
                hibák.Add("Az Ország mező üres!");
                //txtOrszag.BackColor = Color.Red;
            }

            if (count!=0)
            {
                foreach (var item in hibák)
                {
                    MessageBox.Show($"{item}");
                    count = 0;
                }
            }

            else if (count==0)
            {
                if (Convert.ToInt32(txtEv.Text)<1989)
                {
                    MessageBox.Show("„Hiba! Az évszám nem megfelelő!", "Mentés");
                }
                else
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter("uj_dijazott.txt", false, Encoding.Default);
                        sw.WriteLine($"Év;Név;SzületésHalálozás;Országkód");
                        sw.WriteLine($"{txtEv.Text};{txtNev.Text};{txtSzul.Text};{txtOrszag.Text}");
                        MessageBox.Show("A mentés sikeres.");
                        sw.Close();
                        txtEv.Text = "";
                        txtNev.Text = "";
                        txtSzul.Text = "";
                        txtOrszag.Text = "";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"{error.Message}");
                    }
                    finally
                    {
                        MessageBox.Show("A mentés befejeződött.");
                    }
                }
            }
        }
    }
}
