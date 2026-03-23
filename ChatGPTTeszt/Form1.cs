using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                    AdatokMegjelenitese();
                    ComboBoxFeltoltese();
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

            foreach (string sor in File.ReadAllLines(fajlNev, Encoding.UTF8))
            {
                if (!string.IsNullOrWhiteSpace(sor))
                {
                    kuldetesek.Add(new Kuldetes(sor));
                }
            }
        }

        private void AdatokMegjelenitese()
        {
            lstKuldetesek.Items.Clear();

            IEnumerable<Kuldetes> lista = kuldetesek;

            if (rdbCsakColumbia.Checked)
            {
                lista = lista.Where(x => x.Ursiklo == "Columbia");
            }

            if (cmbUrsiklok.SelectedIndex > 0)
            {
                string valasztott = cmbUrsiklok.SelectedItem.ToString();
                lista = lista.Where(x => x.Ursiklo == valasztott);
            }

            foreach (var k in lista)
            {
                List<string> elemek = new List<string>();

                if (chkKod.Checked) elemek.Add(k.Kod);
                if (chkDatum.Checked) elemek.Add(k.Datum.ToString("yyyy.MM.dd"));
                if (chkUrsiklo.Checked) elemek.Add(k.Ursiklo);
                if (chkIdo.Checked) elemek.Add($"{k.Nap} nap {k.Ora} óra");
                if (chkLandolas.Checked) elemek.Add(k.Landolohely);
                if (chkLegenyseg.Checked) elemek.Add($"{k.Legenyseg} fő");

                if (elemek.Count == 0)
                    lstKuldetesek.Items.Add(k.ToString());
                else
                    lstKuldetesek.Items.Add(string.Join(" | ", elemek));
            }
        }

        private void ComboBoxFeltoltese()
        {
            cmbUrsiklok.Items.Clear();
            cmbUrsiklok.Items.Add("Összes");

            foreach (string nev in kuldetesek
                     .Select(x => x.Ursiklo)
                     .Distinct()
                     .OrderBy(x => x))
            {
                cmbUrsiklok.Items.Add(nev);
            }

            cmbUrsiklok.SelectedIndex = 0;
        }

        private void Statisztikak()
        {
            if (kuldetesek.Count == 0) return;

            // a) Hányszor küldtek űrhajót?
            lblKuldetesDb.Text = $"Küldetések száma: {kuldetesek.Count}";

            // b) Összes utas
            int osszUtas = kuldetesek.Sum(x => x.Legenyseg);
            lblOsszUtasszam.Text = $"Összes szállított utas: {osszUtas} fő";

            // c) Kevesebb mint 5 fő
            int kevesebbMint5 = kuldetesek.Count(x => x.Legenyseg < 5);
            lblKevesebbMint5.Text = $"5 főnél kisebb legénységű küldetések: {kevesebbMint5} db";

            // d) Columbia utolsó útja
            DateTime columbiaDatum = new DateTime(2003, 2, 1);
            var columbia = kuldetesek.FirstOrDefault(x => x.Ursiklo == "Columbia" && x.Datum == columbiaDatum);

            if (columbia != null)
                lblColumbia.Text = $"A Columbia utolsó útján {columbia.Legenyseg} asztronauta volt.";
            else
                lblColumbia.Text = "A Columbia utolsó útja nem található.";

            // e) Leghosszabb küldetés
            var leghosszabb = kuldetesek.OrderByDescending(x => x.OsszOra).First();
            lblLeghosszabb.Text = $"Leghosszabb küldetés: {leghosszabb.Ursiklo}, {leghosszabb.Kod}, {leghosszabb.OsszOra} óra";

            // g) Kennedy landolások %
            int kennedyDb = kuldetesek.Count(x => x.Landolohely == "Kennedy");
            double szazalek = (double)kennedyDb / kuldetesek.Count * 100.0;
            lblKennedy.Text = $"Kennedy landolások aránya: {szazalek:F2}%";
        }

        private void btnEvKereses_Click(object sender, EventArgs e)
        {
            if (kuldetesek.Count == 0)
            {
                MessageBox.Show("Először töltsd be a CSV fájlt!");
                return;
            }

            if (!int.TryParse(txtEv.Text, out int ev))
            {
                MessageBox.Show("Érvényes évszámot adj meg!");
                return;
            }

            int db = kuldetesek.Count(x => x.Datum.Year == ev);

            if (db == 0)
                txtEvEredmeny.Text = "Ebben az évben nem indult küldetés";
            else
                txtEvEredmeny.Text = $"Ebben az évben {db} küldetés indult.";
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
            sfd.FileName = txtFajlnev.Text.EndsWith(".txt") ? txtFajlnev.Text : txtFajlnev.Text + ".txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var csoportok = kuldetesek
                        .GroupBy(x => x.Ursiklo)
                        .Select(g => new
                        {
                            Ursiklo = g.Key,
                            OsszNap = g.Sum(x => x.Nap)
                        })
                        .OrderBy(x => x.Ursiklo);

                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        foreach (var item in csoportok)
                        {
                            sw.WriteLine($"{item.Ursiklo}: {item.OsszNap} nap");
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
            if (kuldetesek.Count > 0)
                AdatokMegjelenitese();
        }

        private void rdbCsakColumbia_CheckedChanged(object sender, EventArgs e)
        {
            if (kuldetesek.Count > 0)
                AdatokMegjelenitese();
        }

        private void cmbUrsiklok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kuldetesek.Count > 0)
                AdatokMegjelenitese();
        }

        private void chkKod_CheckedChanged(object sender, EventArgs e) => Frissit();
        private void chkDatum_CheckedChanged(object sender, EventArgs e) => Frissit();
        private void chkUrsiklo_CheckedChanged(object sender, EventArgs e) => Frissit();
        private void chkIdo_CheckedChanged(object sender, EventArgs e) => Frissit();
        private void chkLandolas_CheckedChanged(object sender, EventArgs e) => Frissit();
        private void chkLegenyseg_CheckedChanged(object sender, EventArgs e) => Frissit();

        private void Frissit()
        {
            if (kuldetesek.Count > 0)
                AdatokMegjelenitese();
        }
    }
}