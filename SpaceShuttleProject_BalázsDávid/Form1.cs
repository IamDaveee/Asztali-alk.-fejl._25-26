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
using Microsoft.VisualBasic;

namespace SpaceShuttleProject_BalázsDávid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<SpaceShuttle> adatok = new List<SpaceShuttle>();
        static List<string> urhajok = new List<string>();

        static List<bool> filters = new List<bool>();

        static List<string> header = new List<string>();
        static List<string> content = new List<string>();

        static string FileName = "";
        static string DestFolder = "";
        static string DestFolder2 = "";

        static string selectedSpaceship = "";

        static void CreateAllHeader()
        {
            header.Add("Kód | ");
            header.Add("Dátum | ");
            header.Add("Űrsikló | ");
            header.Add("Napok Száma | ");
            header.Add("Óra | ");
            header.Add("Űrközpont | ");
            header.Add("Legénység Száma | ");
        }
        static void CreateAllContent()
        {
            content.Add("{item.kod} | ");
            content.Add("{item.datum} | ");
            content.Add("{item.ursiklo} | ");
            content.Add("{item.nap} | ");
            content.Add("{item.ora} | ");
            content.Add("{item.urkozpont} | ");
            content.Add("{item.legenyseg} | ");
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            int count = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("You didn't select the file!");
            }
            FileName = openFileDialog1.FileName;
            listBox1.Items.Clear();
            File.ReadAllLines($@"{openFileDialog1.FileName}", Encoding.Default).ToList().ForEach(x => adatok.Add(new SpaceShuttle(x)));
            listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |");
            foreach (var item in adatok)
            {
                listBox1.Items.Add($"{item.kod} | {item.datum} | {item.ursiklo} | {item.nap} | {item.ora} | {item.urkozpont} | {item.legenyseg} |");
                if (!urhajok.Contains(item.ursiklo))
                {
                    urhajok.Add(item.ursiklo);
                }
                if (item.legenyseg < 5)
                {
                    count++;
                }
            }
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Összes");
            comboBox1.SelectedIndex = 0;
            foreach (var item in urhajok)
            {
                comboBox1.Items.Add(item);
            }
            for (int i = 1; i <= 7; i++)
            {
                CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + i, true)[0];
                cb.Checked = true;
            }
            txtAllMission.Text = Convert.ToString(listBox1.Items.Count - 1);
            txtAllMission.Visible = true;
            lblAllCrew.Text = Convert.ToString(adatok.Sum(x => x.legenyseg)) + " fő";
            lblAllCrew.Visible = true;

            lblLeesFive.Visible = true;
            lblLeesFive.Text = Convert.ToString(count) + " db";

            rdbFilter.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            string selected = Convert.ToString(comboBox1.SelectedItem);
            selectedSpaceship = selected;
            int landedStation = 0;
            int kennedy = 0;
            if (selected == "Összes")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |");
                foreach (var item in adatok)
                {
                    listBox1.Items.Add($"{item.kod} | {item.datum} | {item.ursiklo} | {item.nap} | {item.ora} | {item.urkozpont} | {item.legenyseg} |");
                    if (item.legenyseg < 5)
                    {
                        count++;
                    }
                    if (item.urkozpont != "nem landolt")
                    {
                        if (item.urkozpont == "Kennedy")
                        {
                            kennedy++;
                            landedStation++;
                        }
                        else
                        {
                            landedStation++;
                        }
                    }
                }
                lblAllCrew.Text = Convert.ToString(adatok.Sum(x => x.legenyseg)) + " fő";
                var mostOut = adatok.OrderBy(x => x.nap).ThenBy(x => x.ora).LastOrDefault();
                txtMostOut.Text = $"Küldetés kódja: {mostOut.kod}\r\nŰrsikló: {mostOut.ursiklo}\r\nŰrben töltött idő: {mostOut.nap * 24 + mostOut.ora} óra";
                txtLatest.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                txtMostOut.Visible = true;

                lblKennedy.Text = Convert.ToString(Math.Round(Convert.ToDouble(kennedy) / Convert.ToDouble(landedStation) * 100, 0)) + "%";
                lblKennedy.Visible = true;
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |");

                landedStation = 0;
                kennedy = 0;

                foreach (var item in adatok)
                {
                    if (item.ursiklo == selected)
                    {
                        listBox1.Items.Add($"{item.kod} | {item.datum} | {item.ursiklo} | {item.nap} | {item.ora} | {item.urkozpont} | {item.legenyseg} |");
                        if (item.legenyseg < 5)
                        {
                            count++;
                        }
                        if (item.urkozpont != "nem landolt")
                        {
                            if (item.urkozpont == "Kennedy")
                            {
                                kennedy++;
                                landedStation++;
                            }
                            else
                            {
                                landedStation++;
                            }
                        }
                    }
                }
                lblAllCrew.Text = Convert.ToString(adatok.Where(x => x.ursiklo == selected).Sum(x => x.legenyseg)) + " fő";

                var latest = adatok.Where(x => x.ursiklo == selected).OrderBy(x => x.datum).LastOrDefault();
                txtLatest.Text = Convert.ToString($"Dátum: {latest.datum}\r\nTeljes idő: {latest.nap * 24 + latest.ora} óra\r\nLandolt: {latest.urkozpont}\r\nLegénység: {latest.legenyseg} fő");
                label6.Visible = true;
                txtLatest.Visible = true;
                txtMostOut.Visible = false;
                label7.Visible = false;

                lblKennedy.Text = Convert.ToString(Math.Round(Convert.ToDouble(kennedy) / Convert.ToDouble(landedStation) * 100, 0)) + "%";
            }
            txtFilterMission.Text = Convert.ToString(listBox1.Items.Count - 1);
            txtFilterMission.Visible = true;
            lblLeesFive.Text = Convert.ToString(count) + " db";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Kérem válasszon egy fájlt kezdés előtt, a 'Megynyitás' gombbal.");
            }
            else
            {
                filters.Clear();
                header.Clear();
                content.Clear();
                string customHeader = "";
                string customContent = "";
                for (int i = 1; i <= 7; i++)
                {
                    CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + i, true)[0];
                    if (cb.Checked)
                    {
                        filters.Add(true);
                    }
                    else
                    {
                        filters.Add(false);
                    }
                }
                CreateAllHeader();
                CreateAllContent();
                for (int i = 0; i < filters.Count; i++)
                {
                    if (filters[i] == true)
                    {
                        customHeader += header[i];
                    }
                }

                if (Convert.ToString(comboBox1.SelectedItem) == "Összes")
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"{customHeader}");
                    foreach (var item in adatok)
                    {
                        for (int i = 0; i < filters.Count; i++)
                        {
                            if (filters[i])
                            {
                                switch (i)
                                {
                                    case 0: customContent += $"{item.kod} | "; break;
                                    case 1: customContent += $"{item.datum} | "; break;
                                    case 2: customContent += $"{item.ursiklo} | "; break;
                                    case 3: customContent += $"{item.nap} | "; break;
                                    case 4: customContent += $"{item.ora} | "; break;
                                    case 5: customContent += $"{item.urkozpont} | "; break;
                                    case 6: customContent += $"{item.legenyseg} | "; break;
                                }
                            }
                        }

                        listBox1.Items.Add(customContent);
                        customContent = "";
                    }
                }
                else
                {
                    string selected = Convert.ToString(comboBox1.SelectedItem);
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"{customHeader}");
                    foreach (var item in adatok)
                    {
                        if (item.ursiklo == selected)
                        {
                            for (int i = 0; i < filters.Count; i++)
                            {
                                if (filters[i])
                                {
                                    switch (i)
                                    {
                                        case 0: customContent += $"{item.kod} | "; break;
                                        case 1: customContent += $"{item.datum} | "; break;
                                        case 2: customContent += $"{item.ursiklo} | "; break;
                                        case 3: customContent += $"{item.nap} | "; break;
                                        case 4: customContent += $"{item.ora} | "; break;
                                        case 5: customContent += $"{item.urkozpont} | "; break;
                                        case 6: customContent += $"{item.legenyseg} | "; break;
                                    }
                                }
                            }

                            listBox1.Items.Add(customContent);
                            customContent = "";
                        }
                    }
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                for (int i = 1; i <= 7; i++)
                {
                    CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + i, true)[0];
                    cb.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Kérem válasszon egy fájlt kezdés előtt, a 'Megynyitás' gombbal.");
            }

        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            string year = Interaction.InputBox("Melyik évben keresi a számokat?", "Év darabszám", "", 100, 100);
            int count = 0;
            if (year == "")
            {
                MessageBox.Show("Kérem adja meg az évet a mezőbe");
            }
            else
            {
                if (adatok.Any(x => x.datum.StartsWith(year)))
                {
                    foreach (var item in adatok)
                    {
                        string[] tört = item.datum.ToString().Split('.');
                        if (Convert.ToInt32(tört[0]) == Convert.ToInt32(year))
                        {
                            count++;
                        }
                    }
                    MessageBox.Show($"{count} alkalommal indult űrsikló ebben az évben: {Convert.ToInt32(year)}");
                }

                else
                {
                    MessageBox.Show($"{Convert.ToInt32(year)} évben nem indult űrsikló");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                FileName = Interaction.InputBox("Milyen néven mentsem a fájlt?", "Fájl Neve", $"newFile", 100, 100);
                FolderBrowserDialog diag = new FolderBrowserDialog();
                if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DestFolder = diag.SelectedPath;
                }
                else
                { MessageBox.Show("Nem választott mappát!"); }

                if (DestFolder != "")
                {
                    using (StreamWriter sw = new StreamWriter(Path.Combine(DestFolder, FileName + ".csv"), false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine($"Kód;Dátum;Űrsikló;Napok Száma;Óra;Űrközpont;Legénység Száma");
                        foreach (var item in adatok)
                        {
                            sw.WriteLine($"{item.kod};{item.datum};{item.ursiklo};{item.nap};{item.ora};{item.urkozpont};{item.legenyseg}");
                        }
                        sw.Close();
                        MessageBox.Show("Sikeres Mentés!");
                    }
                }

            }
            if (rdbFilter.Checked)
            {
                FileName = Interaction.InputBox("Milyen néven mentsem a fájlt?", "Fájl Neve", $"{selectedSpaceship}", 100, 100);
                FolderBrowserDialog diag2 = new FolderBrowserDialog();
                if (diag2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DestFolder2 = diag2.SelectedPath;
                }
                else
                { MessageBox.Show("Nem választott mappát!"); }

                if (DestFolder2 != "")
                {
                    using (StreamWriter sw = new StreamWriter(Path.Combine(DestFolder2, FileName + ".csv"), false, new UTF8Encoding(true)))
                    {
                        foreach (string item in listBox1.Items)
                        {
                            string[] egysor = item.Trim().Split('|');
                            string oneLine = "";
                            for (int i = 0; i < egysor.Length; i++)
                            {
                                if (i == egysor.Length - 1)
                                {
                                    oneLine += ($"{egysor[i]}");
                                }
                                else
                                {
                                    oneLine += ($"{egysor[i]};");
                                }
                            }
                            sw.WriteLine(oneLine);
                        }
                        sw.Close();
                        MessageBox.Show("Sikeres Mentés!");
                    }
                }
            }
        }
    }
}
