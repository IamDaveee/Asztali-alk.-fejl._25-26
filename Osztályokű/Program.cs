using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztályokű
{
    class Program
    {
        //1. Ember osztály
        class Ember
        {
            //adattagok - hozzáférési szinttel + adattipus + adattag neve
            public string nev;
            public int kor;
            public string szhely,város;

            //konstruktor
            //1.
            public Ember(string nev, int kora, string szh, string város)
            {
                this.nev = nev; //ha ugyan az
                kor = kora; //ha más a neve meg a paraméter neve
                szhely = szh;
                this.város = város;
            }
            //2.
            public Ember()
            {

            }
            //3.
            public Ember(string nev)
            {
                this.nev = nev;
                kor = 18;
                szhely = "Bp";
                város = "Szfv";
            }

            //Metódus
            public void Kiir()
            {
                Console.WriteLine($"\tNév: {nev}\n\tKor: {kor}\n\tSzhely: {szhely}\n\tLakhely: {város}");
                Console.WriteLine();
            }

            //Függvény
            public string Kiiras()
            {
                return $"{nev}, {kor} éves, {szhely}-en született, {város}-ban lakik";
            }

        }//osztaly vége
        static void Main(string[] args)
        {
            //2. Ember osztály 1 példánya
            Ember e1 = new Ember(); //alapért. konstruktor
            //adattagok elérése = változó név.adattag
            e1.nev = "Karcsi";
            e1.kor = 5;
            e1.szhely = "Bp";
            e1.város = "Szfv";
            Console.WriteLine($"e1 példány adatai: {e1.nev}, {e1.kor}, {e1.szhely}, {e1.város}");

            Ember e2 = new Ember();
            e2.nev = "Kati";
            e2.kor = 7;
            e2.szhely = "Bp";
            e2.város = "Szfv";
            Console.WriteLine($"e2 példány adatai: {e2.nev}, {e2.kor}, {e2.szhely}, {e2.város}");

            Ember e3 = new Ember("Feri", 10, "Mo", "Vác");
            Console.WriteLine($"e3 példány adatai: {e3.nev},{e3.kor},{e3.szhely},{e3.város}");

            Console.WriteLine("4. név? ");
            string ember = Console.ReadLine();
            Ember e4 = new Ember(ember);
            Console.WriteLine($"e4 példány adatai: {e4.nev},{e4.kor},{e4.szhely},{e4.város}");
            Console.WriteLine();

            //metódus mewghívása
            e1.Kiir();
            e2.Kiir();
            e3.Kiir();
            e4.Kiir();

            //Függvény meghívása
            Console.WriteLine($"{e1.Kiiras()}\n{e2.Kiiras()}\n{e3.Kiiras()}\n{e4.Kiiras()}");

            UjEmber ujember = new UjEmber("Béla", 90);
            ujember.PeldanyAdatok();

            Érték ertek = new Érték();
            ertek.Értékadás(15);
            ertek.Kiir();
        }
    }
}
