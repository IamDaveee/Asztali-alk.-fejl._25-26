using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hianyzas_otthoni
{
    internal class Program
    {
        static List<Hianyzas> adatok = new List<Hianyzas>();
        static void Main(string[] args)
        {
            //1
            File.ReadAllLines("szeptember.csv", Encoding.Default).Skip(1).ToList().ForEach(x => adatok.Add(new Hianyzas(x)));

            //2
            Console.WriteLine($"Összes mulasztott órák száma: {adatok.Sum(x=>x.orak)}");

            //3
            Console.WriteLine("1-30: ");
            int bekertSzam=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Név? ");
            string bekertNev=Console.ReadLine();

            //4
            if (adatok.Any(x=>x.elso==bekertSzam) && adatok.Any(x=>x.nev==bekertNev))
            {
                Console.WriteLine("A tanuló hiányzott az adott napon");
            }
            else
            {
                Console.WriteLine("A tanuló nem hiányzott aznap");
            }

            //5
            if (adatok.Any(x => x.elso == bekertSzam))
            {
                adatok.Where(x=>x.elso==bekertSzam).ToList().ForEach(x=> Console.WriteLine($"{x.nev} - {x.osztaly}"));
            }
            else
            {
                Console.WriteLine("Nem volt hiányzó");
            }

            //6
            StreamWriter sw = new StreamWriter("osszesites.txt");
            adatok.GroupBy(x => x.osztaly).OrderBy(x => x.Key).ToList().ForEach(x=>sw.WriteLine($"{x.Key};{x.Sum(y=>y.orak)}"));
            sw.Close();
        }
    }
}
