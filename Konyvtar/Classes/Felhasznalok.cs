using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar
{
    internal class Felhasznalok
    {
        public int felhId;
        public string nev, tel, email;
        public DateTime szulDatum, belepesDatum;

        public Felhasznalok(int felhId, string nev, string tel, string email, DateTime szulDatum, DateTime belepesDatum)
        {
            this.felhId = felhId;
            this.nev = nev;
            this.tel = tel;
            this.email = email;
            this.szulDatum = szulDatum.Date;
            this.belepesDatum = belepesDatum.Date;
        }

        public Felhasznalok(string sor)
        {
            string[] egysor = sor.Split(';');
            felhId = Convert.ToInt32(egysor[0]);
            nev=egysor[1];
            szulDatum = Convert.ToDateTime(egysor[2]).Date;
            tel=egysor[3];
            email=egysor[4];
            belepesDatum = Convert.ToDateTime(egysor[5]).Date;
        }
    }
}
