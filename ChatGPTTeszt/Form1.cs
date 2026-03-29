using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ChatGPTTeszt
{


    public partial class Form1 : Form
    {
        List<Kuldetes> kuldetesek = new List<Kuldetes>();
        string megnyitottFajl = "";

        public Form1()
        {
            InitializeComponent();

            cmbUrsiklok.DropDownStyle = ComboBoxStyle.DropDownList;
            rdbOsszes.Checked = true;
        }

        class Kuldetes
        {
            public string Kod { get; set; }
            public DateTime Datum { get; set; }
            public string Ursiklo { get; set; }
            public int Nap { get; set; }
            public int Ora { get; set; }
            public string Landolohely { get; set; }
            public int Legenyseg { get; set; }

            public Kuldetes(string sor)
            {
                string[] m = sor.Split(';');

                Kod = m[0];
                Datum = DateTime.ParseExact(m[1], "yyyy.MM.dd", CultureInfo.InvariantCulture);
                Ursiklo = m[2];
                Nap = int.Parse(m[3]);
                Ora = int.Parse(m[4]);
                Landolohely = m[5];
                Legenyseg = int.Parse(m[6]);
            }

            public int OsszOra
            {
                get
                {
                    return Nap * 24 + Ora;
                }
            }

            public override string ToString()
            {
                return Kod + " | " +
                       Datum.ToString("yyyy.MM.dd") + " | " +
                       Ursiklo + " | " +
                       Nap + " nap " + Ora + " óra | " +
                       Landolohely + " | " +
                       Legenyseg + " fő";
            }
        }

        private void btnMegnyitas_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "kuldetesek.csv megnyitása";
            ofd.Filter = "CSV fájl (*.csv)|*.csv|Minden fájl (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    megnyitottFajl = ofd.FileName;
                    Beolvasas(megnyitottFajl);
                    ComboBoxFeltoltese();
                    AdatokMegjelenitese();
                    Statisztikak();

                    MessageBox.Show("Sikeres beolvasás!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a fájl beolvasása közben:\n" + ex.Message);
                }
            }
        }

        private void Beolvasas(string fajlNev)
        {
            kuldetesek.Clear();

            string[] sorok = File.ReadAllLines(fajlNev, Encoding.UTF8);

            for (int i = 0; i < sorok.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(sorok[i]))
                {
                    kuldetesek.Add(new Kuldetes(sorok[i]));
                }
            }
        }

        private void AdatokMegjelenitese()
        {
            lstKuldetesek.Items.Clear();

            for (int i = 0; i < kuldetesek.Count; i++)
            {
                Kuldetes k = kuldetesek[i];

                if (rdbCsakColumbia.Checked)
                {
                    if (k.Ursiklo != "Columbia")
                    {
                        continue;
                    }
                }

                if (cmbUrsiklok.SelectedIndex > 0)
                {
                    string valasztott = cmbUrsiklok.SelectedItem.ToString();

                    if (k.Ursiklo != valasztott)
                    {
                        continue;
                    }
                }

                string sor = "";

                if (chkKod.Checked)
                {
                    sor += k.Kod;
                }

                if (chkDatum.Checked)
                {
                    if (sor != "") sor += " | ";
                    sor += k.Datum.ToString("yyyy.MM.dd");
                }

                if (chkUrsiklo.Checked)
                {
                    if (sor != "") sor += " | ";
                    sor += k.Ursiklo;
                }

                if (chkIdo.Checked)
                {
                    if (sor != "") sor += " | ";
                    sor += k.Nap + " nap " + k.Ora + " óra";
                }

                if (chkLandolas.Checked)
                {
                    if (sor != "") sor += " | ";
                    sor += k.Landolohely;
                }

                if (chkLegenyseg.Checked)
                {
                    if (sor != "") sor += " | ";
                    sor += k.Legenyseg + " fő";
                }

                if (sor == "")
                {
                    lstKuldetesek.Items.Add(k.ToString());
                }
                else
                {
                    lstKuldetesek.Items.Add(sor);
                }
            }
        }

        private void ComboBoxFeltoltese()
        {
            cmbUrsiklok.Items.Clear();
            cmbUrsiklok.Items.Add("Összes");

            List<string> ursiklok = new List<string>();

            for (int i = 0; i < kuldetesek.Count; i++)
            {
                string aktualisNev = kuldetesek[i].Ursiklo;
                bool marBenneVan = false;

                for (int j = 0; j < ursiklok.Count; j++)
                {
                    if (ursiklok[j] == aktualisNev)
                    {
                        marBenneVan = true;
                        break;
                    }
                }

                if (!marBenneVan)
                {
                    ursiklok.Add(aktualisNev);
                }
            }

            ursiklok.Sort();

            for (int i = 0; i < ursiklok.Count; i++)
            {
                cmbUrsiklok.Items.Add(ursiklok[i]);
            }

            cmbUrsiklok.SelectedIndex = 0;
        }

        private void Statisztikak()
        {
            if (kuldetesek.Count == 0)
            {
                return;
            }

            // a) Küldetések száma
            lblKuldetesDb.Text = "Küldetések száma: " + kuldetesek.Count;

            // b) Összes utas
            int osszUtas = 0;
            for (int i = 0; i < kuldetesek.Count; i++)
            {
                osszUtas += kuldetesek[i].Legenyseg;
            }
            lblOsszUtasszam.Text = "Összes szállított utas: " + osszUtas + " fő";

            // c) 5 főnél kisebb legénységű küldetések
            int kevesebbMint5 = 0;
            for (int i = 0; i < kuldetesek.Count; i++)
            {
                if (kuldetesek[i].Legenyseg < 5)
                {
                    kevesebbMint5++;
                }
            }
            lblKevesebbMint5.Text = "5 főnél kisebb legénységű küldetések: " + kevesebbMint5 + " db";

            // d) Columbia utolsó útja
            DateTime columbiaDatum = new DateTime(2003, 2, 1);
            Kuldetes columbia = null;

            for (int i = 0; i < kuldetesek.Count; i++)
            {
                if (kuldetesek[i].Ursiklo == "Columbia" && kuldetesek[i].Datum == columbiaDatum)
                {
                    columbia = kuldetesek[i];
                    break;
                }
            }

            if (columbia != null)
            {
                lblColumbia.Text = "A Columbia utolsó útján " + columbia.Legenyseg + " asztronauta volt.";
            }
            else
            {
                lblColumbia.Text = "A Columbia utolsó útja nem található.";
            }

            // e) Leghosszabb küldetés
            Kuldetes leghosszabb = kuldetesek[0];

            for (int i = 1; i < kuldetesek.Count; i++)
            {
                if (kuldetesek[i].OsszOra > leghosszabb.OsszOra)
                {
                    leghosszabb = kuldetesek[i];
                }
            }

            lblLeghosszabb.Text = "Leghosszabb küldetés: " +
                                  leghosszabb.Ursiklo + ", " +
                                  leghosszabb.Kod + ", " +
                                  leghosszabb.OsszOra + " óra";

            // g) Kennedy landolások aránya
            int kennedyDb = 0;

            for (int i = 0; i < kuldetesek.Count; i++)
            {
                if (kuldetesek[i].Landolohely == "Kennedy")
                {
                    kennedyDb++;
                }
            }

            double szazalek = (double)kennedyDb / kuldetesek.Count * 100.0;
            lblKennedy.Text = "Kennedy landolások aránya: " + szazalek.ToString("F2") + "%";
        }

        private void btnEvKereses_Click(object sender, EventArgs e)
        {
            if (kuldetesek.Count == 0)
            {
                MessageBox.Show("Először töltsd be a CSV fájlt!");
                return;
            }

            int ev;
            if (!int.TryParse(txtEv.Text, out ev))
            {
                MessageBox.Show("Érvényes évszámot adj meg!");
                return;
            }

            int db = 0;

            for (int i = 0; i < kuldetesek.Count; i++)
            {
                if (kuldetesek[i].Datum.Year == ev)
                {
                    db++;
                }
            }

            if (db == 0)
            {
                txtEvEredmeny.Text = "Ebben az évben nem indult küldetés";
            }
            else
            {
                txtEvEredmeny.Text = "Ebben az évben " + db + " küldetés indult.";
            }
        }

        private void btnTxtMentes_Click(object sender, EventArgs e)
        {
            if (kuldetesek.Count == 0)
            {
                MessageBox.Show("Először töltsd be a CSV fájlt!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFajlnev.Text))
            {
                MessageBox.Show("Adj meg fájlnevet!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Txt mentése";
            sfd.Filter = "Szövegfájl (*.txt)|*.txt";

            if (txtFajlnev.Text.EndsWith(".txt"))
            {
                sfd.FileName = txtFajlnev.Text;
            }
            else
            {
                sfd.FileName = txtFajlnev.Text + ".txt";
            }

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        List<string> feldolgozottUrsiklok = new List<string>();

                        for (int i = 0; i < kuldetesek.Count; i++)
                        {
                            string aktualisUrsiklo = kuldetesek[i].Ursiklo;
                            bool marFeldolgozva = false;

                            for (int j = 0; j < feldolgozottUrsiklok.Count; j++)
                            {
                                if (feldolgozottUrsiklok[j] == aktualisUrsiklo)
                                {
                                    marFeldolgozva = true;
                                    break;
                                }
                            }

                            if (!marFeldolgozva)
                            {
                                int osszNap = 0;

                                for (int j = 0; j < kuldetesek.Count; j++)
                                {
                                    if (kuldetesek[j].Ursiklo == aktualisUrsiklo)
                                    {
                                        osszNap += kuldetesek[j].Nap;
                                    }
                                }

                                sw.WriteLine(aktualisUrsiklo + ": " + osszNap + " nap");
                                feldolgozottUrsiklok.Add(aktualisUrsiklo);
                            }
                        }
                    }

                    MessageBox.Show("Sikeres mentés!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba mentés közben:\n" + ex.Message);
                }
            }
        }

        private void rdbOsszes_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void rdbCsakColumbia_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void cmbUrsiklok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void chkKod_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void chkDatum_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void chkUrsiklo_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void chkIdo_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void chkLandolas_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void chkLegenyseg_CheckedChanged(object sender, EventArgs e)
        {
            Frissit();
        }

        private void Frissit()
        {
            if (kuldetesek.Count > 0)
            {
                AdatokMegjelenitese();
            }
        }
    }
}