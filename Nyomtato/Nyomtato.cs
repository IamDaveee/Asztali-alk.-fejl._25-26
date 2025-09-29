using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomtato
{
    class Nyomtato
    {
        public string gyarto, modell, tipus;
        public int sebesseg, kapacitas;
        public Nyomtato(string gyarto, string modell, string tipus, int sebesseg, int kapacitas)
        {
            this.gyarto = gyarto;
            this.modell = modell;
            this.tipus = tipus;
            this.sebesseg = sebesseg;
            this.kapacitas = kapacitas;
        }

        public Nyomtato()
        {

        }

        public void Adatok()
        {

            Console.WriteLine($"Gyártó: {gyarto}\nModell: {modell}\nTípus: {tipus}\nSebesseg: {sebesseg} oldal/perc\nKapacitás: {kapacitas} lap");
        }

        public void FrissitKapoacitas(int mennyivel)
        {
            int volt = kapacitas;
            kapacitas += mennyivel;
            Console.WriteLine($"Kapacitás sikeresen megnövelve: {volt} --> {kapacitas}");
        }
    }
}
