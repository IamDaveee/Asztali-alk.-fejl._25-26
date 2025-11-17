using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    class Ultrabalaton
    {
        public string nev, kategoria, ido;
        public int rajtszam, szazalek;

        public Ultrabalaton(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            rajtszam =Convert.ToInt32(egysor[1]);
            kategoria = egysor[2];
            ido = egysor[3];
            szazalek =Convert.ToInt32(egysor[4]);
        }
    }
}
