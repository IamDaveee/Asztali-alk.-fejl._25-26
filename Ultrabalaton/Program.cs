using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ultrabalaton
{
    class Program
    {
        static List<Ultrabalaton> adatok = new List<Ultrabalaton>();

        //6
        static double IdoÓra(string ido)
        {
            string [] idoTomb = ido.Split(':');
            double ora = Convert.ToDouble(idoTomb[0]);
            double perc = Convert.ToDouble(idoTomb[1]);
            double masodperc = Convert.ToDouble(idoTomb[2]);

            double IdoÓra = ora + (perc / 60) + (masodperc / 3600);

            return IdoÓra;
        }
        static void Main(string[] args)
        {
            //2
            File.ReadAllLines("ub2017.txt").Skip(1).ToList().ForEach(x => adatok.Add(new Ultrabalaton(x)));
            
            //3
            Console.WriteLine($"egyéni indulók: {adatok.Count} fő");

            //4
            Console.WriteLine($"Célba érkező női sportolók:  {adatok.Where(x=>x.kategoria=="Noi" && x.szazalek==100).Count()} fő");

            //5
            Console.WriteLine("Kérem egy sportolo nevét: ");
            string bekertNev = Console.ReadLine();
            if (adatok.Any(x=>x.nev==bekertNev))
            {
                Console.WriteLine("Indult egyéniben a sportoló? Igen");
                adatok.Where(x => x.nev == bekertNev).ToList().ForEach(x => Console.WriteLine($"{x.szazalek}"));
            }
            else
            {
                Console.WriteLine("Nincs ilyen versenyző");
            }

            //7
            double sum = 0;
            var adatHalmaz = adatok.Where(x => x.szazalek == 100 && x.kategoria == "Ferfi").ToList();
            foreach (var item in adatHalmaz)
            {
                sum += IdoÓra(item.ido);
            }
            Console.WriteLine($"Átlagos idő: {sum/adatHalmaz.Count()}");

            //8
            var noiMin = adatok.Where(x => x.kategoria == "Noi" && x.szazalek == 100).ToList().OrderBy(x => IdoÓra(x.ido));
            Console.WriteLine($"Nők: {noiMin.First().nev}, {noiMin.First().rajtszam}, {IdoÓra(noiMin.First().ido)}");

            var ferfiMin = adatok.Where(x => x.kategoria == "Ferfi" && x.szazalek == 100).ToList().OrderBy(x => IdoÓra(x.ido));
            Console.WriteLine($"Férfiak: {ferfiMin.First().nev}, {ferfiMin.First().rajtszam}, {IdoÓra(ferfiMin.First().ido)}");
        }
    }
}
