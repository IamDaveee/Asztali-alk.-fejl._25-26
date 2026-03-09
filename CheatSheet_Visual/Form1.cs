using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Fájlbeolvasáshoz
using Microsoft.VisualBasic; //InputBoxhoz

namespace CheatSheet_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Class létrehozása, lehet külön oldalra is: Solution explorer -> Projekt neve C# ikonnal mellette -> Jobb click -> Add -> New Item -> Class
        class Class1{
            public int szam;
            public string nev;

            public Class1(int szam, string nev) //alap class construktor
            {
                this.szam = szam;
                this.nev = nev;
            }

            public Class1(string sor) //Class construktor, ha fájlbeolvasást szeretnénk, a "sor" mindig string, a sor lesz az adott sor, amit a fájlbeolvaó beolvas
            {
                string[] egysor = sor.Split(';'); //ezt a sort darabokra szedjük, ebben az esetben ';' mentén
                szam = Convert.ToInt32(egysor[0]); //megnézzük, hogy a beolvasott fájl soraiban hogyan helyezkednek el az adatok. Ha szam az első elem egy sorban, akkor övé a "0"-ás index, és így tovább
                //Convert, ha a várt adat típus nem "string"
                nev = egysor[1];
                //
                //
                //
            }
        }


        //Static Lista, hogy a teljes program elérje
        static List<int> adatok = new List<int>();
        static List<Class1> adatok2 = new List<Class1>();
        //Lehet Class típusú is, de sima int, string vagy akármi

        private void Form1_Load(object sender, EventArgs e)
        {
            //using System.IO

            //Fájlbeolvasás
            File.ReadAllLines("fájlnév-kiterjesztés").ToList().ForEach(x => adatok2.Add(new Class1(x))); //Fájlnév-kiterjesztés pl. Számok.txt, Ha van egy címsor amit nem kívánunk felhasználni akkor .Skip(1), Listává alakítás majd iterálás ForEach-el, ahol minden egyes elemet hozááadunk a Class1 típusú listához, a Class1 konstruktoának használatával. Ebből lesz a "sor" a konstruktorban, amit elemeire szedünk.

            //MessageBox
            MessageBox.Show("Az üzenet", "A szövegdoboz címe");

            //YesNo Buttons
            MessageBox.Show("Az üzenet", "A szövegdoboz címe", MessageBoxButtons.YesNo);

            //ez alapján döntéshozás if-ben
            if (MessageBox.Show("Kérdés","Cím",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Ha a felhasználó Igen-re nyom
            }
            else
            {
                //Ha a felhasználó a Nem-re nyom
            }

            //InputBox
            //Solution explorer -> Projekt neve C# ikonnal mellette -> Jobb click -> Add -> Reference -> Microsoft.ViualBasic
            //using Microsoft.VisualBasic
            Interaction.InputBox("Szöveg", "Cím", "Alapérték", 100, 100);
            string valtozo=Interaction.InputBox("Szöveg", "Cím", "Alapérték", 100, 100); //Ez lehet egy változó is

            //Futás közbeni programozás
            Button exit = new Button();
            exit.Width = 80;
            exit.Height = 60;
            exit.Text = "Kilépés";
            exit.Location = new Point(600, 100);
            exit.Name = "btnClose";
            this.Controls.Add(exit); //Hozzáadás a programhoz és ezzel megjelenítés
            exit.Click += Exit_Click; //Click esemény kezelése, hogy lehessen Click funkciókat hozzáadni
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            //A funkció ami lefut az újonnan hozzáadott gomb Click eseményére
            this.Close();
        }
    }
}
