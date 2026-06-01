using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar
{
    internal class foglalasok
    {
        public int felhId, konyvId;
        public DateTime fogKezd, fogVeg; //foglalás kezdete, foglalás vége

        public foglalasok(int felhId, int konyvId, DateTime fogKezd, DateTime fogVeg)
        {
            this.felhId = felhId;
            this.konyvId = konyvId;
            this.fogKezd = fogKezd.Date;
            this.fogVeg = fogVeg.Date;
        }

        public foglalasok(string sor)
        {
            string[] egysor = sor.Split(';');
            felhId = Convert.ToInt32(egysor[0]);
            konyvId = Convert.ToInt32(egysor[1]);
            fogKezd = Convert.ToDateTime(egysor[2]).Date;
            fogVeg = Convert.ToDateTime(egysor[3]).Date;
        }
    }
}
