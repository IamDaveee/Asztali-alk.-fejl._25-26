using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//for file import
using Microsoft.VisualBasic;//for InputBoxes

namespace SpaceShuttleProject_BalázsDávid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<SpaceShuttle> adatok = new List<SpaceShuttle>(); //main List from our class
        static List<string> urhajok = new List<string>(); //List for all the spaceships

        static List<bool> filters = new List<bool>(); //List to check which filters are ticked in

        static List<string> header = new List<string>(); //List to add the header after the filters are finalized
        //static List<string> content = new List<string>(); //List to add the content after the filters are finalized //useless

        static string FileName = ""; //Filename to stroce globaly
        static string DestFolder = ""; //Destination folder to save the file in, globaly
        static string DestFolder2 = ""; //Destination folder2 because of the if statement

        static string selectedSpaceship = ""; //globalize the selected spaceship because of multiple usage

        static void CreateAllHeader() //collecting all the headers, and later adding the ones the user selected
        {
            header.Add("Kód | ");
            header.Add("Dátum | ");
            header.Add("Űrsikló | ");
            header.Add("Napok Száma | ");
            header.Add("Óra | ");
            header.Add("Űrközpont | ");
            header.Add("Legénység Száma | ");
        }
        /*static void CreateAllContent() //collecting all the content, and later only adding the ones the user selected
        {
            content.Add("{item.kod} | ");
            content.Add("{item.datum} | ");
            content.Add("{item.ursiklo} | ");
            content.Add("{item.nap} | ");
            content.Add("{item.ora} | ");
            content.Add("{item.urkozpont} | ");
            content.Add("{item.legenyseg} | ");
        }*/ //useless
        private void btnOpen_Click(object sender, EventArgs e)
        {
            int count = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //allowing the user to import file from folder
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog(); //opening the dialog
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("You didn't select the file!");
            }
            FileName = openFileDialog1.FileName;
            listBox1.Items.Clear(); //clearing the listbox, so multiple opening is possible after each other
            File.ReadAllLines($@"{openFileDialog1.FileName}", Encoding.Default).ToList().ForEach(x => adatok.Add(new SpaceShuttle(x))); //reading the file, running through the class, addign each item to our main List
            listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |");//adding the header to the ListBox (later did it agin, this part could be deleted, if default selection triggers "comboBox1_SelectedIndexChanged")
            foreach (var item in adatok)
            {
                listBox1.Items.Add($"{item.kod} | {item.datum} | {item.ursiklo} | {item.nap} | {item.ora} | {item.urkozpont} | {item.legenyseg} |"); //adding everything to the listbox
                if (!urhajok.Contains(item.ursiklo))
                {
                    urhajok.Add(item.ursiklo); //adding every spaceship to our global spaceship list
                }
                if (item.legenyseg < 5)
                {
                    count++;
                }
            }
            comboBox1.Items.Clear(); //clearing the combobox that contains the spaceships(for multiple importation after each other)
            comboBox1.Items.Add("Összes"); //Adding the option to view all
            comboBox1.SelectedIndex = 0; //selecting the view all option by default
            foreach (var item in urhajok)
            {
                comboBox1.Items.Add(item); //adding every spaceship to the combobox once, so we can select one later and make a filter for it
            }
            for (int i = 1; i <= 7; i++)
            {
                CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + i, true)[0]; //going trough each of our filter checkboxes
                cb.Checked = true; //checking in every checkbox by defaukt
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
            selectedSpaceship = selected; //saving the selected spaceship so we can call it out later for multiple tasks
            int landedStation = 0;
            int kennedy = 0;
            if (selected == "Összes") //if we selected all, we have different data and output
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |"); //Adding everything back, incease we selected one, and then selected All again, this could replace the previous fillment if the method is called by ddefault
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
            else //if we selected a specific spaceship, instead of All
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |");

                landedStation = 0;
                kennedy = 0;

                foreach (var item in adatok)
                {
                    if (item.ursiklo == selected) //only adding the selected spaceships data
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

        private void btnUpdate_Click(object sender, EventArgs e) //when the user selected all the filters they need, adn pressed update
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Kérem válasszon egy fájlt kezdés előtt, a 'Megynyitás' gombbal."); //message if no files were selected
            }
            else
            {
                filters.Clear(); //clearing the filters global List, so we can add in the filters the user selected
                header.Clear(); //clearing the header to get ready for the update
                //content.Clear(); //same with the headers //useless
                string customHeader = ""; //local variable, that will get data from out global list, based on the user selected filters
                string customContent = ""; //local, same as the one on top
                for (int i = 1; i <= 7; i++)
                {
                    CheckBox cb = (CheckBox)this.Controls.Find("checkBox" + i, true)[0]; //going trough our checkboxes one by one
                    if (cb.Checked) //if Checked
                    {
                        filters.Add(true); //adding true to our global filters list
                    }
                    else
                    {
                        filters.Add(false); //adding false if the current filter checkbox is not checked
                    }
                }
                CreateAllHeader(); //adding all the options to our global lists
                //CreateAllContent(); //useless
                for (int i = 0; i < filters.Count; i++) //going trough the amount of filters
                {
                    if (filters[i] == true)
                    {
                        customHeader += header[i]; //adding in the same filter, this is why the filters list is boolean, because the position of filter checkboxes will not change, so first will always stay first and so on
                    }
                }

                if (Convert.ToString(comboBox1.SelectedItem) == "Összes") //checking if we see all the data or just one specific scapeship
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"{customHeader}"); //adding in our custom, prebuilt header
                    foreach (var item in adatok)
                    {
                        for (int i = 0; i < filters.Count; i++)
                        {
                            if (filters[i]) //going trough the filter list 1...2...3, if the current is true:
                            {
                                switch (i) //we check which item should we get, we only see the true ones, from 0-6
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

                        listBox1.Items.Add(customContent); //adding the custom content, line by line
                        customContent = ""; //epmty before next line
                    }
                }
                else
                {
                    string selected = Convert.ToString(comboBox1.SelectedItem); //checking witch spaceship is selected
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"{customHeader}"); //custom header did not change from the All option
                    foreach (var item in adatok)
                    {
                        if (item.ursiklo == selected) //if the current line contains data from the selected spaceship
                        {
                            for (int i = 0; i < filters.Count; i++) //same logic as before
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

                            listBox1.Items.Add(customContent); //add line by line
                            customContent = ""; //clear for next line
                        }
                    }
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e) //simply checking in all the filter checkboxes
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
            string year = Interaction.InputBox("Melyik évben keresi a számokat?", "Év darabszám", "", 100, 100); //input --> year
            int count = 0;
            if (year == "")
            {
                MessageBox.Show("Kérem adja meg az évet a mezőbe"); //if empty
            }
            else
            {
                if (adatok.Any(x => x.datum.StartsWith(year))) //get only the year
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
            if (rdbAll.Checked) //if the user wants to save the whole database with all the data
            {
                FileName = Interaction.InputBox("Milyen néven mentsem a fájlt?", "Fájl Neve", $"newFile", 100, 100); //getting the filename from the user, wich will be used for the save
                FolderBrowserDialog diag = new FolderBrowserDialog(); //offering the user a choic in witch they can decide where to save the file
                if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DestFolder = diag.SelectedPath; //saving the destination of the selected folder
                }
                else
                { MessageBox.Show("Nem választott mappát!"); }

                if (DestFolder != "")
                {
                    using (StreamWriter sw = new StreamWriter(Path.Combine(DestFolder, FileName + ".csv"), false, new UTF8Encoding(true))) //opening a new file where the user selected, and using the given filename
                    {
                        sw.WriteLine($"Kód;Dátum;Űrsikló;Napok Száma;Óra;Űrközpont;Legénység Száma"); //header
                        foreach (var item in adatok)
                        {
                            sw.WriteLine($"{item.kod};{item.datum};{item.ursiklo};{item.nap};{item.ora};{item.urkozpont};{item.legenyseg}"); //writeing one line of the database, while going trough the database
                        }
                        sw.Close();
                        MessageBox.Show("Sikeres Mentés!");
                    }
                }

            }
            if (rdbFilter.Checked) //if the user wants to save just the filtered database, that is currently shown in the ListBox
            {
                FileName = Interaction.InputBox("Milyen néven mentsem a fájlt?", "Fájl Neve", $"{selectedSpaceship}", 100, 100); //same as before
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
                            string[] egysor = item.Trim().Split('|'); //splitting the current line
                            string oneLine = "";
                            for (int i = 0; i < egysor.Length; i++)
                            {
                                if (i == egysor.Length - 1) //if the last item
                                {
                                    oneLine += ($"{egysor[i]}");
                                }
                                else
                                {
                                    oneLine += ($"{egysor[i]};"); //if not the last item of the cuurrent line
                                }
                            }
                            sw.WriteLine(oneLine); //write the line into the file, and go line by line
                        }
                        sw.Close();
                        MessageBox.Show("Sikeres Mentés!");
                    }
                }
            }
        }
    }
}
