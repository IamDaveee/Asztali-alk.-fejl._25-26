using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztályokű
{
    class Érték
    {
        int x; //ha nincs elérés, akkor alapból private

        public void Értékadás(int mennyi)
        {
            x = mennyi;
        }

        public void Kiir()
        {
            Console.WriteLine($"x értéke: {x}");
        }
    }
}
