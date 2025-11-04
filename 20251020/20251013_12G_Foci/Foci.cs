using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251013_12G_Foci
{
    class Foci
    {
        public int forduloSzama, hazaiGolVege, vendegGolVege, hazaiFelido, vendegFelido;
        public string hazaiCsapat, vendegCsapat;

        public Foci(string sor)
        {
            string[] egysor = sor.Split(' ');
            forduloSzama = Convert.ToInt32(egysor[0]);
            hazaiGolVege = Convert.ToInt32(egysor[1]);
            vendegGolVege = Convert.ToInt32(egysor[2]);
            hazaiFelido = Convert.ToInt32(egysor[3]);
            vendegFelido = Convert.ToInt32(egysor[4]);
            hazaiCsapat = egysor[5];
            vendegCsapat = egysor[6];
        }
    }
}
