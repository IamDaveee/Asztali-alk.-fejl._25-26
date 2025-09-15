using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_Gyak03
{
    class Program
    {
        static List<Dolgozok> dolgozok = new List<Dolgozok>();
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

            StreamReader sr = new StreamReader("dolgozo.txt");
            while (!sr.EndOfStream)
            {
                dolgozok.Add(new Dolgozok(sr.ReadLine()));
            }
            sr.Close();

            for (int i = 0; i < dolgozok.Count; i++)
            {
                dolgozok[i].Kiir();
            }
            Console.WriteLine();

            foreach (var item in dolgozok)
            {
                item.Kiir();
            }
            Console.WriteLine();
            Console.WriteLine($"Dolgozók száma: {dolgozok.Count}");

            Console.WriteLine("tanulo neve: ");
            nev = Console.ReadLine();
            Console.WriteLine("Tanuló születési éve: ");
            int ev= Convert.ToInt32(Console.ReadLine());
            Tanulok tanulo1 = new Tanulok(nev, ev);
            Console.WriteLine($"Tanuló kora: {tanulo1.Kiir()}");
        }
    }
}
