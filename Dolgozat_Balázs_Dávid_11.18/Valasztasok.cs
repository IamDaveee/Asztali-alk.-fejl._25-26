using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_Balázs_Dávid_11._18
{
    class Szavazatok
    {
        public int sorszam, szavazatok;
        public string nev, part;

        public Szavazatok(string sor)
        {
            string[] egysor = sor.Split(' ');
            sorszam = Convert.ToInt32(egysor[0]);
            szavazatok = Convert.ToInt32(egysor[1]);
            nev = egysor[2] + " " + egysor[3];
            if (egysor[4]=="-")
            {
                part = "Független Jelölt";
            }
            else
            {
                part = egysor[4];
            }
            
        }
    }
}
