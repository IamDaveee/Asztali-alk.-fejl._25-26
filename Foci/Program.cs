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

            /*

            //Feladat2();
            Console.WriteLine("Kérem egy forduló sorszámát");
            int fordulo = Convert.ToInt32(Console.ReadLine());
            var meccsek = adatok.Where(x => x.fordulo == fordulo).ToList();
            meccsek.ForEach(x => Console.WriteLine($"{x.hazaiNev}-{x.vendegNev} : {x.hazaiGol}-{x.vendegGol} ({x.elsoFelidoGol}-{x.masodikFelidoGol})"));

            //Feladat3();
            adatok.Where(x =>
            (x.elsoFelidoGol < x.masodikFelidoGol && x.hazaiGol > x.vendegGol)
            ||
            (x.masodikFelidoGol < x.elsoFelidoGol && x.vendegGol > x.hazaiGol))
                .ToList()
                .ForEach(x => Console.WriteLine(x.hazaiGol>x.vendegGol?$"{x.fordulo} {x.hazaiNev}":$"{x.fordulo} {x.vendegNev}"));

            //Másik megoldás
            adatok.Where(x =>
                    (x.elsoFelidoGol < x.masodikFelidoGol && x.hazaiGol > x.vendegGol)
                    ||
                    (x.masodikFelidoGol < x.elsoFelidoGol && x.vendegGol > x.hazaiGol))
                .Select(x=>
                { string gyoztes = x.hazaiGol > x.vendegGol ? x.hazaiNev : x.vendegNev;
                    return new { x.fordulo, gyoztes };
                })
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.fordulo} {x.gyoztes}"));

            //Feladat4();
            Console.WriteLine("Kérek egy csapatot: ");
            string csapatnev = Console.ReadLine();


            //Feladat5();
            Console.WriteLine($"Lőtt: {adatok.Where(x => x.hazaiNev == csapatnev).Sum(x => x.hazaiGol) + adatok.Where(x => x.vendegNev == csapatnev).Sum(x => x.vendegGol)} Kapott: {adatok.Where(x => x.hazaiNev == csapatnev).Sum(x => x.vendegGol) + adatok.Where(x => x.vendegNev == csapatnev).Sum(x => x.hazaiGol)}");

            //Feladat6
            var elsoVereseg = adatok.Where(x => x.hazaiNev == csapatnev && x.hazaiGol < x.vendegGol)
                .OrderBy(x => x.fordulo).FirstOrDefault();
            Console.WriteLine(elsoVereseg==null?"a csapat nem kapott ki":$"{elsoVereseg.fordulo}");

            //6. Any()
            if (adatok.Any(x=>x.hazaiNev==csapatnev && x.hazaiGol<x.vendegGol))
            {
                Console.WriteLine("A csapat otthon veretlen maradt");
            }
            else
            {
                var elsoVer = adatok.Where(x => x.hazaiNev == csapatnev && x.hazaiGol < x.vendegGol).OrderBy(x => x.fordulo).First();
                Console.WriteLine($"{elsoVer.fordulo}, ");
            }

            //Feladat7
            adatok.GroupBy(x => $"{Math.Max(x.vendegGol, x.hazaiGol)} {Math.Min(x.hazaiGol, x.vendegGol)}");

            //7.2
            var statisztika = adatok.Select(x =>
                                  {
                                      int nagyobb = Math.Max(x.hazaiGol, x.vendegGol);
                                      int kisebb = Math.Min(x.hazaiGol, x.vendegGol);
                                      return $"{nagyobb} - {kisebb}";
                                  }).GroupBy(eredmeny=>eredmeny);


            */

            //1.
            Console.WriteLine($"{adatok.Where(x=>x.hazaiGol>x.vendegGol).ToList().Count}");

            //2.
            Console.WriteLine($"{adatok.Where(x=>x.hazaiGol + x.vendegGol >=4).ToList().Count}");

            //3.
            Console.WriteLine($"{adatok.Where(x=>x.hazaiNev=="Lelkesek").Sum(x=>x.hazaiGol) + adatok.Where(x=>x.vendegNev=="Lelkesek").Sum(x=>x.vendegGol)}");

            //4.
            Console.WriteLine($"{adatok.Where(x=>x.hazaiNev=="Bogarak" && x.hazaiGol<x.vendegGol).Count() + adatok.Where(x=>x.vendegNev=="Bogarak" && x.hazaiGol>x.vendegGol).Count()}");

            //5.
            Console.WriteLine($"{adatok.Where(x=>x.hazaiNev=="Nyulak").Sum(x=>x.vendegGol) + adatok.Where(x=>x.vendegNev=="Nyulak").Sum(x=>x.hazaiGol)}");

            //6.
            Console.WriteLine($"{adatok.Where(x=>x.hazaiGol==x.vendegGol).Count()}");

            //7.
            Console.WriteLine($"{adatok.Where(x=>x.hazaiGol>=3).Count()}");

            //8.
            //var lottPerFordulo=adatok.
        }
    }
}
