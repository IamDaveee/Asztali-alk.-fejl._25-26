using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_BalázsDávid_03._30
{
    class Varos
    {
        public string varosNev, orszagNev;
        public double nepesseg;

        public Varos(string sor)
        {
            string[] egysor = sor.Split(';');
            varosNev = egysor[0];
            orszagNev = egysor[1];
            nepesseg = Convert.ToDouble(egysor[2]);
        }

        public Varos(string varosNev, string orszagNev, double nepesseg)
        {
            this.varosNev = varosNev;
            this.orszagNev = orszagNev;
            this.nepesseg = nepesseg;
        }
    }
}
