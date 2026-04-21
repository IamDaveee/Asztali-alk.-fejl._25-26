using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigKult_25_maj
{
    class Program
    {
        static List<string> beolvasas = new List<string>();
        static List<string> converted = new List<string>();

        static string convert(string sor)
        {
            string eredmeny = "";
            for (int i = 0; i < sor.Length; i++)
            {
                int valami = 0;
                bool a = int.TryParse(sor[i].ToString(), out valami);
                if (a)
                {
                    for (int j = 0; j < valami; j++)
                    {
                        eredmeny += sor[i+1];
                    }
                }
            }
            
            return eredmeny;
            
        }
        static void Main(string[] args)
        {
            File.ReadAllLines("book.txt", Encoding.Default).ToList().ForEach(x => beolvasas.Add(x));
            foreach (var item in beolvasas)
            {
                Console.WriteLine(item);
            }

            int sorszam = beolvasas.Count;
            Console.WriteLine("Please enter the number of repetitions: ");
            int darab = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < beolvasas.Count; i++)
            {
                for (int j = 0; j < darab; j++)
                {
                    Console.Write($" {beolvasas[i]}\t|");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            File.ReadAllLines("comp_c.txt").ToList().ForEach(x=>converted.Add(convert(x)));

            foreach (var item in converted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
