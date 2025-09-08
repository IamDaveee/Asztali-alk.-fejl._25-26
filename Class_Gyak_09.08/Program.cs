
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gyak_09._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya("Csonker",6);
            Console.WriteLine($"Név: {k1.nev}, Kor: {k1.kor}, Gazda: {k1.gazda}");

            k1.Kiir();
            k1.Etet(60);
            k1.Kiir();
            k1.Jatek();
            k1.Kiir();
        }
    }
}
