using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Berek_09._29
{
    class Program
    {
        static List<Dolgozo> adatok = new List<Dolgozo>();
        
        static void Beolvas()
        {
            StreamReader sr = new StreamReader("berek2020.txt");
            sr.ReadLine();//első sor avagy mezőnevek átugrása
            while (!sr.EndOfStream)
            {
                adatok.Add(new Dolgozo(sr.ReadLine()));
            }
            sr.Close();
        }
        
        static double atlagBer()
        {
            double osszeg = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                osszeg += adatok[i].fizetes;
            }
            return osszeg / adatok.Count;
        }

        static string reszleg = "";
        static void Feladat6()
        {
            Console.WriteLine("Részleg neve: ");
            reszleg = Console.ReadLine();
            int max = 0;
            int maxindex = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].reszleg==reszleg)
                {
                    for (int j = 0; j < adatok.Count; j++)
                    {
                        if (max<adatok[j].fizetes)
                        {
                            max = adatok[j].fizetes;
                            maxindex = j;
                        }
                    }
                }
            }
            Console.WriteLine($"Név: {adatok[maxindex].neve}, Neme: {adatok[maxindex].neme}, Részleg: {adatok[maxindex].reszleg}, Fizetés: {adatok[maxindex].fizetes}");
        }

        static void Main(string[] args)
        {
            Beolvas();
            Console.WriteLine($"3. feladat: {adatok.Count}");
            //File.ReadAllLines("berek2020.txt").Skip(1).ToList().ForEach(x=>adatok.Add(new Dolgozo(x)));
            //Console.WriteLine($"3. feladat: {adatok.Count}");
            Console.WriteLine($"A dolgozók átlagbére: {Math.Round(atlagBer(), 2)} Ft");
            Console.WriteLine($"Átlagbér: {adatok.Average(x=>x.fizetes)/1000:f1} eFt");
            //Feladat6();

            Console.WriteLine("Részleg neve: ");
            reszleg = Console.ReadLine();
            if (adatok.Any(x=>x.reszleg==reszleg))
            {
                Dolgozo munkas = adatok.Where(x => x.reszleg == reszleg).OrderBy(x=>x.fizetes).Last();
                Console.WriteLine($"Név: {munkas.neve}\nNeme: {munkas.neme}\nBelépés: {munkas.belepes}\nFizetés: {munkas.fizetes}");
            }
            else
            {
                Console.WriteLine("A részleg nem létezik.");
            }

            Console.WriteLine("Statisztika");
            var gyujtemeny = adatok.GroupBy(x => x.reszleg);
            foreach (var item in gyujtemeny)
            {
                Console.WriteLine($"{item.Key} - {item.Count()} fő");
            }
        }
    }
}
