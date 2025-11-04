using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20251013_12G_Foci
{
    class Program
    {
        static void Main(string[] args)
        {
            //0. lista létrehozása
            List<Foci> adatok = new List<Foci>();
            //1. Beolvasás
            File.ReadAllLines("meccs.txt").Skip(1).ToList().ForEach(x => adatok.Add(new Foci(x)));
            //Ellenőrzés
            Console.WriteLine($"A fájl sorainak száma: {adatok.Count}");
            Console.WriteLine($"Első sor hazai csapata: {adatok[0].hazaiCsapat}");

            //2. forduló mérkőzéseinek száma
            Console.Write("Kérem a forduló számát: ");
            int fordulo = Convert.ToInt32(Console.ReadLine());
            var meccsek = adatok.Where(x => x.forduloSzama == fordulo).ToList();
            meccsek.ForEach(x => Console.WriteLine($"{x.hazaiCsapat}-{x.vendegCsapat}: {x.hazaiGolVege}-{x.vendegGolVege} ({x.hazaiFelido}-{x.vendegFelido})"));

            //3.
            adatok.Where(x =>
                         (x.hazaiFelido < x.vendegFelido && x.hazaiGolVege > x.vendegGolVege)
                         ||
                         (x.vendegFelido < x.hazaiFelido && x.vendegGolVege > x.hazaiGolVege)
                         ).ToList().ForEach(x =>
                                            Console.WriteLine(x.hazaiGolVege > x.vendegGolVege
                                            ? $"{x.forduloSzama} {x.hazaiCsapat}"
                                            : $"{x.forduloSzama} {x.vendegCsapat}"));
            //3. még egyszer
            adatok.Where(x =>
                    (x.hazaiFelido < x.vendegFelido && x.hazaiGolVege > x.vendegGolVege)
                    ||
                    (x.vendegFelido < x.hazaiFelido && x.vendegGolVege > x.hazaiGolVege))
                     .Select(x =>
                     {
                         string gyoztes = x.hazaiGolVege > x.vendegGolVege
                                          ? x.hazaiCsapat
                                          : x.vendegCsapat;
                         return new { x.forduloSzama, gyoztes };
                     }).ToList()
                       .ForEach(x => Console.WriteLine($"{x.forduloSzama} {x.gyoztes}"));
            //4.5. csapatnév, kapott, lőtt gólok
            Console.Write("Kérem egy csapat nevét: ");
            string csapatNev = Console.ReadLine();
            Console.WriteLine($"lőtt: {adatok.Where(x=>x.hazaiCsapat==csapatNev).Sum(x=>x.hazaiGolVege) + adatok.Where(x=>x.vendegCsapat==csapatNev).Sum(x=>x.vendegGolVege)}");
            Console.WriteLine($"kapott: {adatok.Where(x=>x.hazaiCsapat==csapatNev).Sum(x=>x.vendegGolVege)+ adatok.Where(x=>x.vendegCsapat==csapatNev).Sum(x=>x.hazaiGolVege)}");

            //6. melyik csapat kapott ki először
            var elsoVereseg = adatok.Where(x => x.hazaiCsapat == csapatNev
                                           && x.hazaiGolVege < x.vendegGolVege)
                                         .OrderBy(x => x.forduloSzama)
                                         .FirstOrDefault();
            Console.WriteLine(elsoVereseg==null
                              ? "A csapat otthon veretlen maradt."
                              : $"{elsoVereseg.forduloSzama} fordulóban kapott ki {elsoVereseg.vendegCsapat} csapattól");
            //6. Any()
            if (!adatok.Any(x=>x.hazaiCsapat==csapatNev && x.hazaiGolVege<x.vendegGolVege))
            {
                Console.WriteLine("A csapat otthon veretlen maradt.");
            }
            else
            {
                var elsoVer = adatok.Where(x => x.hazaiCsapat == csapatNev
                              && x.hazaiGolVege < x.vendegGolVege)
                            .OrderBy(x => x.forduloSzama).First();
                Console.WriteLine($"{elsoVer.forduloSzama} {elsoVer.vendegCsapat}");
            }

            //7. statisztika
            adatok.GroupBy(x => $"{Math.Max(x.vendegGolVege, x.hazaiGolVege)}-{Math.Min(x.hazaiGolVege, x.vendegGolVege)}").ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()} db"));
            //7. statisztika
            var statisztika = adatok.Select(x =>
                              {
                                  int nagyobb = Math.Max(x.hazaiGolVege, x.vendegGolVege);
                                  int kisebb = Math.Min(x.hazaiGolVege, x.vendegGolVege);
                                  return $"{nagyobb} - {kisebb}";
                              }).GroupBy(eredmeny => eredmeny).Select(g => new { Eredmeny = g.Key, Darab = g.Count() })
                             .OrderByDescending(x => x.Darab)
                             .ThenBy(x => x.Eredmeny).ToList();
            statisztika.ForEach(x => Console.WriteLine($"{x.Eredmeny} {x.Darab}"));
            //fájlba írás

            adatok.GroupBy(x => x.forduloSzama).ToList().ForEach(x => Console.WriteLine($"{x.Key} {x.Sum(y=>y.hazaiGolVege+y.vendegGolVege)}") );
            var vmi = adatok.GroupBy(x => x.forduloSzama).ToList();
            
            Console.ReadKey();
        }
    }
}
