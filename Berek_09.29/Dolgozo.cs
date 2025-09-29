using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek_09._29
{
    class Dolgozo
    {
        public string neve, neme, reszleg;
        public int belepes, fizetes;

        //konstruktor, fájl egy sora
        public Dolgozo(string sor)
        {
            string[] egysor = sor.Split(';');
            neve = egysor[0];
            neme = egysor[1];
            reszleg = egysor[2];
            belepes = Convert.ToInt32(egysor[3]);
            fizetes = Convert.ToInt32(egysor[4]);
        }
    }
}
