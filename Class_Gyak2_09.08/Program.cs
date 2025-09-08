using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gyak2_09._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az 1. számot: ");
            double szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem az 2. számot: ");
            double szam2 = Convert.ToInt32(Console.ReadLine());

            Szamol e1 = new Szamol(szam1, szam2);

            Console.WriteLine("Kérek egy művfeleti jelet: ");
            char jel = Convert.ToChar(Console.ReadLine());

            switch (jel)
            {
                case '+': Console.WriteLine(szam1 + szam2);
                    break;
                case '-': Console.WriteLine(szam1-szam2);
                    break;
                case '*': Console.WriteLine(szam1*szam2);
                    break;
                case '/': Console.WriteLine($"{szam1/szam2:0.00}");
                    break;
            }
        }
    }
}
