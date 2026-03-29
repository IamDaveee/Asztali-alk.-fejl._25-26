using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Otthoni_03._29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Space> adatok=new List<Space>();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            File.ReadAllLines("kuldetesek.csv", Encoding.Default).ToList().ForEach(x=>adatok.Add(new Space(x)));

            foreach (var item in adatok)
            {
                listBox1.Items.Add($"{item.kod} {item.datum} {item.ursiklo} {item.nap} {item.ora} {item.allomas} {item.legenyseg}");
            }


            textBox1.Text = Convert.ToString(listBox1.Items.Count);

            List<string> ursiklok = new List<string>();
            foreach (var item in adatok)
            {
                if (!ursiklok.Contains(item.ursiklo))
                {
                    ursiklok.Add(item.ursiklo);
                }
            }
            textBox3.Text = Convert.ToString(ursiklok.Count);


            int count = 0;
            foreach (var item in adatok)
            {
                count += item.legenyseg;
            }
            textBox2.Text = count.ToString();

            textBox2.Text = adatok.Sum(x=>x.legenyseg).ToString();

            var legtovábbTávol = adatok.OrderByDescending(x => x.nap).ThenBy(x=>x.ora).First();
            MessageBox.Show($"Leghosszabb küldetés: {legtovábbTávol.kod}, {legtovábbTávol.datum}, {legtovábbTávol.nap*24+ legtovábbTávol.ora}");
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            string keres = textBox4.Text;
            int count = 0;

            foreach (var item in adatok)
            {
                if (item.ursiklo==keres)
                {
                    count += item.legenyseg;
                }
            }

            if (count==0)
            {
                MessageBox.Show("Nem található");
            }

            MessageBox.Show($"{adatok.Where(x=>x.ursiklo==keres).Sum(x=>x.legenyseg)}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("eredmeny.exe");

            foreach (string item in listBox1.Items)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
    }
}
