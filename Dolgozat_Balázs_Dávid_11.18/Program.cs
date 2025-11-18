using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dolgozat_Balázs_Dávid_11._18
{
    class Program
    {
        static List<Szavazatok> adatok = new List<Szavazatok>();
        static void Main(string[] args)
        {
            //4
            File.ReadAllLines("szavazatok.txt").ToList().ForEach(x => adatok.Add(new Szavazatok(x)));

            //5
            Console.WriteLine($"A helyhatósági választáson {adatok.Count} képviselőjelölt indult.");

            Console.WriteLine();

            //6
            Console.WriteLine("Kérek egy vezeték és utónevet: ");
            string bekertNev = Console.ReadLine();
            if (adatok.Any(x=>x.nev==bekertNev))
            {
                adatok.Where(x => x.nev == bekertNev).ToList().ForEach(x => Console.WriteLine($"{x.nev} {x.szavazatok} db szavazatott kapott"));
            }
            else
            {
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");
            }

            Console.WriteLine();

            //7
            double szavazok = adatok.Sum(x => x.szavazatok);
            double össz = 12345;
            Console.WriteLine($"A választáson {adatok.Sum(x=>x.szavazatok)} állampolgár, a jogosultak {Math.Round(szavazok/össz*100, 2)}%-a vett részt");

            Console.WriteLine();

            //8
            var stat = adatok.GroupBy(x => x.part).ToList().Select(y => new {Párt=y.Key, Szavazat=y.Sum(z=>z.szavazatok)});
            foreach (var item in stat)
            {
                Console.WriteLine($"{item.Párt} - {item.Szavazat}");
            }

            Console.WriteLine();

            //9
            double összSzavazat = adatok.Sum(x => x.szavazatok);
            foreach (var item in stat)
            {
                Console.WriteLine($"{item.Párt} - {Math.Round(item.Szavazat/összSzavazat*100, 2)}%");
            }

            Console.WriteLine();

            //10
            var legtobb = adatok.OrderByDescending(x => x.szavazatok).First();
            Console.WriteLine($"{legtobb.nev} - {legtobb.part}");

            Console.WriteLine();

            //11
            StreamWriter sw = new StreamWriter("statisztika.txt");
            adatok.GroupBy(x => x.sorszam).OrderBy(x => x.Key).ToList().ForEach(x=>sw.WriteLine($"{x.Key}.kerület - szavazatok száma {x.Sum(y=>y.szavazatok)}"));
            sw.Close();
        }
    }
}
