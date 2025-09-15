using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gyak03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolgozok dolgozo1 = new Dolgozok("Ede", "takarító", 250000);

            dolgozo1.Kiir();
            Console.WriteLine($"A dolgozó új fizetése: {dolgozo1.Emel()}");

            Dolgozok dolgozo2 = new Dolgozok();
            Console.WriteLine("Dolgozo neve: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Dolgozo munkaköre: ");
            string mkor = Console.ReadLine();
            Console.WriteLine("Dolgozo fizetese: ");
            int fizetes = Convert.ToInt32(Console.ReadLine());

            dolgozo2.nev = nev;
            dolgozo2.munkakör = mkor;
            dolgozo2.fizetes = fizetes;

            dolgozo2.Kiir();
        }
    }
}
