using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar
{
    internal class konyvek
    {
        public int konyvId, oldalszam;
        public string cim, iro;

        public konyvek(int konyvId, int oldalszam, string cim, string iro)
        {
            this.konyvId = konyvId;
            this.oldalszam = oldalszam;
            this.cim = cim;
            this.iro = iro;
        }

        public konyvek(string sor)
        {
            string[] egysor = sor.Split(';');
            konyvId = Convert.ToInt32(egysor[0]);
            cim = egysor[1];
            iro= egysor[2];
            oldalszam = Convert.ToInt32(egysor[3]);
        }
    }
}
