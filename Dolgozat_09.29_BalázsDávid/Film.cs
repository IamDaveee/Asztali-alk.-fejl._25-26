using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_09._29_BalázsDávid
{
    class Film
    {
        public string cim, rendezo, mufaj;
        public int hossz;

        public Film(string cim, string rendezo, string mufaj, int hossz)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            this.mufaj = mufaj;
            this.hossz = hossz;
        }

        public Film()
        {
            cim = "ismeretlen";
            rendezo = "ismeretlen";
            hossz = 0;
            mufaj = "ismeretlen";
        }

        public Film(string cim, string rendezo)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            mufaj = "dráma";
            hossz = 0;
        }

        public void FilmLeiras()
        {
            Console.WriteLine($"Cím: {cim}\nRendező: {rendezo}\nHossz: {hossz} perc\nMűfaj: {mufaj}");
        }

        public string kategoria;
        public string HosszKategoria()
        {
            if (hossz<=0 && hossz<=60)
            {
                kategoria = "rövidfilm";
            }
            else if (hossz>=61 && hossz<=120)
            {
                kategoria = "normál játékfilm";
            }
            else if (hossz>=121)
            {
                kategoria = "hosszú játékfilm";
            }

            return kategoria;
        }

        public string pont;
        public string MufajPont()
        {
            if (mufaj=="akció")
            {
                pont = "20 pont";
            }
            else if (mufaj == "vígjáték")
            {
                pont = "15 pont";
            }
            else if (mufaj == "dráma")
            {
                pont = "25 pont";
            }

            else
            {
                pont = "10 pont";
            }

            return pont;
        }

        public void Frissit()
        {
            Console.WriteLine("Film címe? ");
            string cim = Console.ReadLine();
            Console.WriteLine("Film rendezője? ");
            string rendezo = Console.ReadLine();
            Console.WriteLine("Film hossz? ");
            int hossz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Film műfaja? ");
            string mufaj = Console.ReadLine();

            this.cim = cim;
            this.rendezo = rendezo;
            this.hossz = hossz;
            this.mufaj = mufaj;
        }
    }
}
