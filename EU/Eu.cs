using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
    class Eu
    {
        public string nev, datum;

        public Eu(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            datum = egysor[1];
        }
    }
}
