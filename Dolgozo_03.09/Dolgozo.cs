using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozo_03._09
{
    class Dolgozo
    {
        public string nev, munkakor;
        public int fizetes;

        public Dolgozo(string sor)
        {
            string[] egysor = sor.Split(' ');
            nev = egysor[0];
            munkakor = egysor[1];
            fizetes = Convert.ToInt32(egysor[2]);
        }
    }
}
