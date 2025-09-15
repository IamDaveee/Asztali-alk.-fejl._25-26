using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macska_09._15
{
    class Macska
    {
        public string nev;
        public double suly;
        public bool ehes;

        public Macska(string nev, double suly, bool ehes)
        {
            this.nev = nev;
            this.suly = suly;
            this.ehes = ehes;
        }
        public Macska(string nev, double suly)
        {
            this.nev = nev;
            this.suly = suly;
            ehes= true;
        }
        public Macska()
        {

        }

        public void Eszik(double mennyiseg)
        {
            if (ehes)
            {
                suly += mennyiseg;
                ehes = false;
                bool etetes = true;
                Console.WriteLine($"Az etetés sikeres volt, a macska súlya: {suly}");
            }
            else
            {
                bool etetes = false;
                Console.WriteLine($"Az etetés sikertelen volt, a macska nem éhes");
            }
        }

        public void Futkos()
        {
            suly=suly-0.1;
            ehes = true;
        }

        public void Kiir()
        {
            Console.WriteLine($"{nev} macska {suly} kg\t{}");
        }
    }
}
