using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyomtato
{
    class Program
    {
        static void Main(string[] args)
        {
            Nyomtato e1 = new Nyomtato("HP","LaserJet1020","lézer", 20, 250);

            Console.WriteLine("Nyomtató Gyártója? ");
            string gyarto = Console.ReadLine();
            Console.WriteLine("Nyomtató Modell? ");
            string modell = Console.ReadLine();
            Console.WriteLine("Nyomtató Típus? ");
            string tipus = Console.ReadLine();
            Console.WriteLine("Nyomtató Sebesseg? ");
            int sebesseg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nyomtató Kapacitás? ");
            int kapacitas = Convert.ToInt32(Console.ReadLine());

            Nyomtato e2 = new Nyomtato(gyarto, modell, tipus, sebesseg, kapacitas);

            e1.FrissitKapoacitas(100);
            e2.FrissitKapoacitas(100);

            e1.Adatok();
            e2.Adatok();
        }
    }
}
