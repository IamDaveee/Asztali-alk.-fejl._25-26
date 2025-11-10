using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki
{
    class Helsinki
    {
        public int helyezes, sportolok;
        public string sportag, versenyszam, erem;

        public Helsinki(string sor)
        {
            string[] egysor = sor.Split(' ');
            helyezes = Convert.ToInt32(egysor[0]);
            sportolok = Convert.ToInt32(egysor[1]);
            sportag = egysor[2];
            versenyszam = egysor[3];
            switch (helyezes)
            {
                case 1:
                    {
                        erem = "Arany";
                    }
                    break;
                case 2:
                    {
                        erem = "Ezüst";
                    }
                    break;
                case 3:
                    {
                        erem = "Bronz";
                    }
                    break;
                default:
                    {
                        
                    }
                    break;
            }
        }
    }
}
