using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hegyek
{
    internal class Program
    {
        static List<Hegyek>adatok=new List<Hegyek>();
        static void Main(string[] args)
        {
            File.ReadAllLines("hegyekMo.txt", Encoding.Default).Skip(1).ToList().ForEach(x => adatok.Add(new Hegyek(x)));


            Console.WriteLine(adatok.Count);


            Console.WriteLine(adatok.Average(x=>x.magasssag));


            var magassag = adatok.OrderByDescending(x => x.magasssag).First();
            Console.WriteLine($"{magassag.nev}, {magassag.hegyseg}, {magassag.magasssag}");

            Console.WriteLine("Kérek egy magasságot! ");
            int userMagassag=Convert.ToInt32(Console.ReadLine());
            var magasabb = adatok.Any(x => x.magasssag > userMagassag && x.hegyseg == "Börzsöny");
            Console.WriteLine(magasabb?$"A Börzsönyben VAN magassabb hegy" :$"A Börzsöny NINCS magasabb hegy");


            var magasCsucsok = adatok.Where(x => x.magasssag > 3000/3.280839895).Select(x=>x.nev);
            foreach (var item in magasCsucsok)
            {
                Console.WriteLine(item);
            }


            var stat = adatok.GroupBy(x => x.hegyseg)
                .Select(y => new 
                {
                    Hegységnév = y.Key,
                    Csúcsszám = y.Count()
                })/*
                .OrderByDescending(x => x.Csúcsszám)
                .ThenBy(x=>x.Hegységnév)*/;
            foreach (var item in stat)
            {
                Console.WriteLine($"{item.Hegységnév} - {item.Csúcsszám} db");
            }


            var bukkhegyek = adatok.Where(x => x.hegyseg == "Bükk-vidék")
                .Select(x => new
                { 
                    x.nev, x.magasssag
                });
            StreamWriter sw = new StreamWriter("bukk-videk.txt");
            sw.WriteLine("Hegycsúcs neve;Magasság láb");
            foreach (var item in bukkhegyek)
            {
                sw.WriteLine($"{item.nev};{Math.Round(item.magasssag*3.280839895, 1)}");
            }
            sw.Close();
        }
    }
}
