using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otthoni_03._29
{
    internal class Space
    {
        public string kod, datum, ursiklo, allomas;
        public int nap, ora, legenyseg;

        public Space(string sor)
        {
            string[] egysor = sor.Split(';');
            kod = egysor[0];
            datum = egysor[1];
            ursiklo= egysor[2];
            nap=Convert.ToInt32(egysor[3]);
            ora=Convert.ToInt32(egysor[4]);
            allomas = egysor[5];
            legenyseg = Convert.ToInt32(egysor[6]);
        }
    }
}
