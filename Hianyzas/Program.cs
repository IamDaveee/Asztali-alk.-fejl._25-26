using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hianyzas
{
    class Program
    {
        static List<Hianyzas> adatok = new List<Hianyzas>();
        static void Main(string[] args)
        {
            File.ReadAllLines("szeptember.csv", Encoding.Default).Skip(1).ToList().ForEach(x=>adatok.Add(new Hianyzas(x)));

            Console.WriteLine($"A diákok hiányzása: {adatok.Sum(x=>x.orak)}");

            Console.WriteLine("Kérek egy napot 1-30 között: ");
            int valasztottNap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy nevet: ");
            string valasztottNev = Console.ReadLine();
            if (adatok.Any(x=>x.elso==valasztottNap && x.nev==valasztottNev))
            {
                Console.WriteLine("Az adott tanuló hiányzott az adott napon");
            }
            else
            {
                Console.WriteLine("A tanuló nem hiányzott az adott napon");
            }


            if (adatok.Any(x => x.elso == valasztottNap))
            {
                foreach (var y in adatok.Where(x => x.elso == valasztottNap))
                {
                    Console.WriteLine($"{y.nev} - {y.osztaly}");
                }
            }
            else
            {
                Console.WriteLine("Nem volt az adott napon hiányzás");
            }


            StreamWriter sw = new StreamWriter("hianyzas.csv");
            adatok.GroupBy(x => x.osztaly).OrderBy(x=>x.Key).ToList().ForEach(x => sw.WriteLine($"{x.Key};{x.Sum(y=>y.orak)}"));
            sw.Close();
        }
    }
}
