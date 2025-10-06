using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    class Foci
    {
        public int fordulo, hazaiGol, vendegGol, elsoFelidoGol, masodikFelidoGol;
        public string hazaiNev, vendegNev;

        public Foci(string sor)
        {
            string[] egysor = sor.Split(' ');
            fordulo = Convert.ToInt32(egysor[0]);
            hazaiGol = Convert.ToInt32(egysor[1]);
            vendegGol = Convert.ToInt32(egysor[2]);
            elsoFelidoGol = Convert.ToInt32(egysor[3]);
            masodikFelidoGol = Convert.ToInt32(egysor[4]);
            hazaiNev = egysor[5];
            vendegNev = egysor[6];
        }
    }
}
