using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShuttleProject_BalázsDávid
{
    class SpaceShuttle
    {
        public string kod, datum, ursiklo, urkozpont;
        public int nap, ora, legenyseg;

        public SpaceShuttle(string kod, string datum, string ursiklo, string urkozpont, int nap, int ora, int legenyseg)
        {
            this.kod = kod;
            this.datum = datum;
            this.ursiklo = ursiklo;
            this.urkozpont = urkozpont;
            this.nap = nap;
            this.ora = ora;
            this.legenyseg = legenyseg;
        }

        public SpaceShuttle (string sor)
        {
            string [] egysor = sor.Split(';');
            kod = egysor[0];
            datum = egysor[1];
            ursiklo = egysor[2];
            nap = Convert.ToInt32(egysor[3]);
            ora = Convert.ToInt32(egysor[4]);
            urkozpont = egysor[5];
            legenyseg = Convert.ToInt32(egysor[6]);
        }
    }
}
