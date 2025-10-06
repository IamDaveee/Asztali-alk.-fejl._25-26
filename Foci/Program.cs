using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Foci
{
    class Program
    {
        static List<Foci> adatok = new List<Foci>();
        static string csapatNev;
        static void Feladat2()
        {
            Console.WriteLine("Kérek egy forduló számát: ");
            int forduloSzam = Convert.ToInt32(Console.ReadLine());
            int forduloIndex = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (forduloSzam==adatok[i].fordulo)
                {
                    forduloIndex = i;
                    Console.WriteLine($"{adatok[forduloIndex].hazaiNev}-{adatok[forduloIndex].vendegNev}: {adatok[forduloIndex].hazaiGol}-{adatok[forduloIndex].vendegGol} ({adatok[forduloIndex].elsoFelidoGol}-{adatok[forduloIndex].masodikFelidoGol})");
                }
            }
        }

        static void Feladat3()
        {
            int index = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].hazaiGol>adatok[i].vendegGol && adatok[i].elsoFelidoGol<adatok[i].masodikFelidoGol)
                {
                    index = i;
                    Console.WriteLine($"{adatok[index].fordulo}.forduló, {adatok[index].hazaiNev}");
                }
                else if (adatok[i].hazaiGol<adatok[i].vendegGol && adatok[i].elsoFelidoGol>adatok[i].masodikFelidoGol)
                {
                    index = i;
                    Console.WriteLine($"{adatok[index].fordulo}.forduló, {adatok[index].vendegNev}");
                }
            }
        }

        static void Feladat4()
        {
            Console.WriteLine("Kérem egy csapat nevét: ");
            csapatNev = Console.ReadLine();
        }

        static void Feladat5()
        {
            int countKapott=0;
            int countLott=0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].hazaiNev==csapatNev)
                {
                    countKapott += adatok[i].vendegGol;
                    countLott += adatok[i].hazaiGol;
                }
                else if (adatok[i].vendegNev==csapatNev)
                {
                    countLott += adatok[i].vendegGol;
                    countKapott += adatok[i].hazaiGol;
                }
            }
            Console.WriteLine($"lőtt: {countLott} kapott: {countKapott}");
        }
        static void Main(string[] args)
        {
            File.ReadAllLines("meccs.txt").Skip(1).ToList().ForEach(x => adatok.Add(new Foci(x)));
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
        }
    }
}
