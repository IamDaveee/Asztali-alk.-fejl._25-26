using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gyak03
{
    class Tanulok
    {
        public string nev;
        public int szulEv;

        public Tanulok(string nev, int szulEv)
        {
            this.nev = nev;
            this.szulEv = szulEv;
        }

        public int Kiir()
        {
            return DateTime.Now.Year - szulEv;
        }
    }
}
