using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gyak03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolgozok dolgozo1 = new Dolgozok("Ede", "takarító", 250000);

            dolgozo1.Kiir();
            Console.WriteLine($"A dolgozó új fizetése: {dolgozo1.Emel()}");
        }
    }
}
