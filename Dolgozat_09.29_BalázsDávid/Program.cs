using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_09._29_BalázsDávid
{
    class Program
    {
        static void Main(string[] args)
        {
            Film film1 = new Film("A remény rabjai", "Frank Darabont", "dráma",142);
            Film film2 = new Film();
            Film film3 = new Film("Valami Amerika", "Herendi Gábor");

            film1.FilmLeiras();
            Console.WriteLine($"1.Film Hosszkategóriája: {film1.HosszKategoria()}");
            Console.WriteLine($"1.Film Műfajpontja: {film1.MufajPont()}");
            Console.WriteLine();

            film2.FilmLeiras();
            Console.WriteLine($"2.Film Hosszkategóriája: {film2.HosszKategoria()}");
            Console.WriteLine($"2.Film Műfajpontja: {film2.MufajPont()}");
            Console.WriteLine();

            film3.FilmLeiras();
            Console.WriteLine($"3.Film Hosszkategóriája: {film3.HosszKategoria()}");
            Console.WriteLine($"3.Film Műfajpontja: {film3.MufajPont()}");
            Console.WriteLine();

            film2.Frissit();
            film2.FilmLeiras();
            Console.WriteLine($"2.Film Hosszkategóriája: {film2.HosszKategoria()}");
            Console.WriteLine($"2.Film Műfajpontja: {film2.MufajPont()}");
            Console.WriteLine();
        }
    }
}
