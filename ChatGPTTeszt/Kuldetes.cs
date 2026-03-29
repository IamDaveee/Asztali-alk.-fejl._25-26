/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ChatGPTTeszt
{
    internal class Kuldetes
    {
        public string Kod { get; set; }
        public DateTime Datum { get; set; }
        public string Ursiklo { get; set; }
        public int Nap { get; set; }
        public int Ora { get; set; }
        public string Landolohely { get; set; }
        public int Legenyseg { get; set; }

        public Kuldetes(string sor)
        {
            string[] m = sor.Split(';');

            Kod = m[0];
            Datum = DateTime.ParseExact(m[1], "yyyy.MM.dd", CultureInfo.InvariantCulture);
            Ursiklo = m[2];
            Nap = int.Parse(m[3]);
            Ora = int.Parse(m[4]);
            Landolohely = m[5];
            Legenyseg = int.Parse(m[6]);
        }

        public int OsszOra
        {
            get { return Nap * 24 + Ora; }
        }

        public override string ToString()
        {
            return $"{Kod} | {Datum:yyyy.MM.dd} | {Ursiklo} | {Nap} nap {Ora} óra | {Landolohely} | {Legenyseg} fő";
        }
    }
}
*/