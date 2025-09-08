using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gyak_09._08
{
    class Kutya
    {
        public string nev, gazda;
        public int kor;
        private int ehseg=0;

        public Kutya(string nev, int kor)
        {
            this.nev = nev;
            this.gazda = "Alex";
            this.kor = kor;
        }

        public void Etet(int mennyi)
        {
            ehseg += mennyi;
        }

        public void Jatek()
        {
            if (ehseg<=50)
            {
                Console.WriteLine("A kutya éhes, nem tudsz vele játszani");
            }
            else
            {
                Console.WriteLine("Játék");
                ehseg -= 5;
            }
        }
        public void Kiir()
        {
            Console.WriteLine($"{nev}, {kor}, {gazda}");
            Console.WriteLine(ehseg<=50?"Éhes":"Nem éhes");
        }
    }
}
