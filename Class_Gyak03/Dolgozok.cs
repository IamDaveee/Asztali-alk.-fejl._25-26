using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gyak03
{
    class Dolgozok
    {
        public string nev, munkakör;
        public int fizetes;

        public Dolgozok(string nev, string munkakör, int fizetes)
        {
            this.nev = nev;
            this.munkakör = munkakör;
            this.fizetes = fizetes;
        }

        public void Kiir()
        {
            Console.WriteLine($"Dolgozó neve: {nev}, Munkaköre: {munkakör}, Fizetése: {fizetes}");
        }

        public int Emel()
        {
            return fizetes + 100000;
        }
    }
}
