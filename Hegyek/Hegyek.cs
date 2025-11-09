using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyek
{
    internal class Hegyek
    {
        public string nev, hegyseg;
        public int magasssag;

        public Hegyek(string sor)
        {
            string[] egysor=sor.Split(';');
            nev=egysor[0];
            hegyseg=egysor[1];
            magasssag=Convert.ToInt32(egysor[2]);
        }
    }
}
