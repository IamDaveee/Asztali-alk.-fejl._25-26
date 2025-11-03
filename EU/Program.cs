using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
    class Program
    {
        static List<Eu> adatok = new List<Eu>();
        static void Main(string[] args)
        {
            File.ReadAllLines("EUcsatlakozas.txt", Encoding.Default).ToList().ForEach(x => adatok.Add(new Eu(x)));

            Console.WriteLine($"{adatok.Count} tagállam");

            Console.WriteLine(adatok.Count(x=>x.datum.Split('.')[0]=="2007"));
            Console.WriteLine(adatok.Where(x=>x.datum.Substring(0,4)=="2007").Count());

            //var magyarorszagDatum = adatok.Where(x => x.nev == "Magyarország").Select(x => x.datum).FirstOrDefault();
            //Console.WriteLine(magyarorszagDatum);

            Console.WriteLine(adatok.First(x=>x.nev=="Magyarország").datum);

            var orszagok = adatok.Where(x => x.datum.Split('.')[1] == "05").Select(x => x.nev);

            foreach (var item in orszagok)
            {
                Console.WriteLine(item);
            }

            var latestCountry = adatok.OrderByDescending(x => DateTime.Parse(x.datum)).First();
            Console.WriteLine(latestCountry.nev);


        }
    }
}
