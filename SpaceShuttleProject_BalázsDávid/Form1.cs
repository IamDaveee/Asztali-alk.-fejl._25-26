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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("You didn't select the file!");
            }
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = Convert.ToString(comboBox1.SelectedItem);
            if (selected=="Összes")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |");
                foreach (var item in adatok)
                {
                    listBox1.Items.Add($"{item.kod} | {item.datum} | {item.ursiklo} | {item.nap} | {item.ora} | {item.urkozpont} | {item.legenyseg} |");
                }
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Kód | Dátum | Űrsikló | Napok Száma | Óra | Űrközpont | Legénység Száma |");
                foreach (var item in adatok)
                {
                    if (item.ursiklo==selected)
                    {
                        listBox1.Items.Add($"{item.kod} | {item.datum} | {item.ursiklo} | {item.nap} | {item.ora} | {item.urkozpont} | {item.legenyseg} |");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count==0)
            {
                MessageBox.Show("Kérem válasszon egy fájlt kezdés előtt, a 'Megynyitás' gombbal.");
            }
            else
            {
                filters.Clear();
                header.Clear();
                content.Clear();
                string customHeader="";
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
                    if (filters[i]==true)
                    {
                        customHeader += header[i];
                    }
                }

                if (Convert.ToString(comboBox1.SelectedItem)=="Összes")
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
            if (listBox1.Items.Count!=0)
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
    }
}
