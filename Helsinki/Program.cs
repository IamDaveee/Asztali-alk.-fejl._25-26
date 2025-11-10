using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helsinki
{
    class Program
    {
        static List<Helsinki> adatok = new List<Helsinki>();
        static void Main(string[] args)
        {
            File.ReadAllLines("helsinki.txt", Encoding.Default).ToList().ForEach(x=>adatok.Add(new Helsinki(x)));


            Console.WriteLine(adatok.Count);


            var stat = adatok.Where(x=>!string.IsNullOrEmpty(x.erem)).GroupBy(x => x.erem).Select(y => new
            {
                Erem = y.Key,
                Darab = y.Count(),
            });
            foreach (var item in stat)
            {
                Console.WriteLine($"{item.Erem}: {item.Darab}");
            }
            Console.WriteLine($"Összesen: {stat.Sum(x=>x.Darab)}");


            var totalPoints = adatok.Sum(x=>
                    x.helyezes==1?7:
                    x.helyezes==2?5:
                    x.helyezes==3?4:
                    x.helyezes==4?3:
                    x.helyezes==5?2:
                    x.helyezes==6?1:0
                );
            Console.WriteLine($"Olimpiai pontok száma: {totalPoints}");


            var uszas = adatok.Where(x => x.sportag == "uszas" && !string.IsNullOrEmpty(x.erem)).Select(x=>x.erem);
            var torna = adatok.Where(x => x.sportag == "torna" && !string.IsNullOrEmpty(x.erem)).Select(x=>x.erem);
            if (uszas.Count()>torna.Count())
            {
                Console.WriteLine("Úszás sportágban szereztek több érmet");
            }
            else if (torna.Count()>uszas.Count())
            {
                Console.WriteLine("Torna sportágban szereztek több érmet");
            }
            else
            {
                Console.WriteLine("Egysenlő");
            }


            var pontszerzo = adatok.OrderByDescending(x => x.sportolok).First();
            Console.WriteLine($"Helyezés: {pontszerzo.helyezes}\nSportág: {pontszerzo.sportag}\nVersenyszám: {pontszerzo.versenyszam}\nSportolók száma: {pontszerzo.sportolok}");
        }
    }
}
