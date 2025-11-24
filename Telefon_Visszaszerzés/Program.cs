using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SzabaduloszobaKonzol
{
    enum Helyszin
    {
        Tanterem,
        Folyoso,
        TanariSzoba,
        Vege
    }

    class Jatekos
    {
        public Helyszin AktuálisHelyszin { get; set; } = Helyszin.Tanterem;
        public List<string> Targyak { get; } = new List<string>();
        public bool AsztalFeladatMegoldva { get; set; }
        public bool SzonyegFeladatMegoldva { get; set; }
        public bool TanariAjtoNyitva { get; set; }
        public bool TelefonMegvan { get; set; }

        public bool VanTargy(string nev) => Targyak.Contains(nev);
        public void HozzaadTargy(string nev)
        {
            if (!Targyak.Contains(nev))
                Targyak.Add(nev);
        }
    }

    class Jatek
    {
        private readonly Jatekos _jatekos = new Jatekos();
        private readonly Stopwatch _ido = new Stopwatch();
        private readonly TimeSpan _limit = TimeSpan.FromMinutes(15); // 15 perces időlimit
        private bool _kilep = false;

        public void Futtatas()
        {
            Console.Title = "Szabadulószoba – Konzol verzió";
            Bevezetes();

            _ido.Start();

            while (!_kilep)
            {
                if (_ido.Elapsed > _limit && !_jatekos.TelefonMegvan)
                {
                    Console.Clear();
                    Console.WriteLine("Lejárt a 15 perc! ⏰");
                    Console.WriteLine("Nem sikerült visszaszerezned a telefont a tanártól...");
                    Console.WriteLine("Nyomj le egy gombot a kilépéshez.");
                    Console.ReadKey();
                    return;
                }

                Console.Clear();
                JatekAllapotKiiras();
                HelyszinMenü();
            }
        }

        private void Bevezetes()
        {
            Console.WriteLine("PROJEKT: Digitális szabadulószoba – Konzol verzió");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Történet:");
            Console.WriteLine("  A tanár elvette az órán a mobiltelefonodat, mert órán nyomkodtad.");
            Console.WriteLine("  A telefon most a tanári szobában van elzárva, és 15 perced van, hogy visszaszerezd.");
            Console.WriteLine();
            Console.WriteLine("Cél:");
            Console.WriteLine("  Oldd meg a logikai és ügyességi feladatokat, juss el a tanári szobába,");
            Console.WriteLine("  és szerezd vissza a telefonodat!");
            Console.WriteLine();
            Console.WriteLine("Irányítás:");
            Console.WriteLine("  - Számmal választhatsz a menüből.");
            Console.WriteLine("  - A játék során tárgyakat gyűjthetsz, kódokat fejthetsz meg.");
            Console.WriteLine();
            Console.WriteLine("Nyomj le egy gombot a kezdéshez...");
            Console.ReadKey();
        }

        private void JatekAllapotKiiras()
        {
            Console.WriteLine("Szabadulószoba – Telefon visszaszerzése");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Idő: {_ido.Elapsed.Minutes:D2}:{_ido.Elapsed.Seconds:D2} / {_limit.Minutes} perc");
            Console.WriteLine($"Helyszín: {HelyszinNeve(_jatekos.AktuálisHelyszin)}");
            Console.WriteLine();

            Console.WriteLine("Tárgyak az inventory-ban:");
            if (_jatekos.Targyak.Count == 0)
            {
                Console.WriteLine("  (nincs még tárgyad)");
            }
            else
            {
                foreach (var t in _jatekos.Targyak)
                    Console.WriteLine("  - " + t);
            }

            Console.WriteLine();
        }

        private string HelyszinNeve(Helyszin h)
        {
            switch (h)
            {
                case Helyszin.Tanterem:
                    return "Tanterem";
                case Helyszin.Folyoso:
                    return "Folyosó";
                case Helyszin.TanariSzoba:
                    return "Tanári szoba";
                default:
                    return "Ismeretlen";
            }
        }


        private void HelyszinMenü()
        {
            switch (_jatekos.AktuálisHelyszin)
            {
                case Helyszin.Tanterem:
                    TanteremMenü();
                    break;
                case Helyszin.Folyoso:
                    FolyosoMenü();
                    break;
                case Helyszin.TanariSzoba:
                    TanariMenü();
                    break;
            }
        }

        private int BekerValasztas(int min, int max)
        {
            Console.WriteLine();
            Console.Write("Válassz egy opciót: ");
            while (true)
            {
                string input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out int val) && val >= min && val <= max)
                    return val;

                Console.Write($"Érvénytelen választás. Adj meg egy számot {min} és {max} között: ");
            }
        }

        private void TanteremMenü()
        {
            Console.WriteLine("Tanterem");
            Console.WriteLine("--------");
            Console.WriteLine("Egy informatikateremben vagy. A tanár már kiment a tanáriba,");
            Console.WriteLine("de az asztalán maradt néhány jegyzet és egy fiók.");
            Console.WriteLine();
            Console.WriteLine("Lehetséges akciók:");
            Console.WriteLine("  1) Megnézem a tanár asztalát (kódfejtés)");
            Console.WriteLine("  2) Körülnézek a padok között (tárgykeresés)");
            Console.WriteLine("  3) Kimegyek a folyosóra");
            Console.WriteLine("  0) Kilépés a játékból");

            int val = BekerValasztas(0, 3);
            switch (val)
            {
                case 1:
                    AsztalFeladat();
                    break;
                case 2:
                    PadokKozottKereses();
                    break;
                case 3:
                    _jatekos.AktuálisHelyszin = Helyszin.Folyoso;
                    break;
                case 0:
                    _kilep = true;
                    break;
            }
        }

        private void AsztalFeladat()
        {
            if (_jatekos.AsztalFeladatMegoldva)
            {
                Console.WriteLine();
                Console.WriteLine("Már megoldottad ezt a feladatot, és megtaláltad a kulcsot.");
                Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("A tanár asztalán egy papír van, rajta a következő feladattal:");
            Console.WriteLine();
            Console.WriteLine("  \"A szekrénykód háromjegyű szám.");
            Console.WriteLine("   - Az első számjegy: a mai órán írt dolgozat maximális pontszámának tizedese (30 pont).");
            Console.WriteLine("   - A második számjegy: hány betűből áll a 'INFO' szó?");
            Console.WriteLine("   - A harmadik számjegy: hány darab monitor van az első padsorban (3).\"");
            Console.WriteLine();
            Console.WriteLine("Tehát a kód: (30/10), 'INFO' betűi, monitorok száma.");
            Console.WriteLine();

            Console.Write("Írd be a háromjegyű kódot: ");
            string kod = Console.ReadLine()?.Trim() ?? "";

            if (kod == "343") // 30/10=3, INFO=4 betű -> itt lehet variálni, pl. 3 4 3, de legyen 434 egy tetszőleges logika szerint
            {
                Console.WriteLine();
                Console.WriteLine("Katt... A fiók kinyílt! Találsz benne egy kis kulcsot.");
                _jatekos.AsztalFeladatMegoldva = true;
                _jatekos.HozzaadTargy("Kis kulcs");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("A zár nem nyílt ki. Úgy tűnik, rossz kódot írtál be.");
            }

            Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        private void PadokKozottKereses()
        {
            Console.WriteLine();
            if (!_jatekos.SzonyegFeladatMegoldva)
            {
                Console.WriteLine("A padok között járkálva észreveszel egy felhajtott szőnyeget.");
                Console.WriteLine("Alatta egy cetli van, rajta a felirat:");
                Console.WriteLine();
                Console.WriteLine("  \"Ha be akarsz jutni a tanáriba, emlékezz:");
                Console.WriteLine("   - Az informatikaterem száma a 305-ös.");
                Console.WriteLine("   - A 'TANAR' szó betűi hányan vannak?");
                Console.WriteLine("   - A mai dátum napja legyen a harmadik számjegy (pl. 14).\"");
                Console.WriteLine();
                Console.WriteLine("A cetli szerint a tanári ajtó kódja a következő formátumú: 3 _ _. ");
                Console.WriteLine();
                Console.WriteLine("Ez még nem a teljes kód, de fontos nyom.");
                _jatekos.SzonyegFeladatMegoldva = true;
                _jatekos.HozzaadTargy("Cetli a tanári kódhoz");
            }
            else
            {
                Console.WriteLine("Már átnézted a padokat, a fontos nyomot zsebre vágtad.");
            }

            Console.WriteLine();
            Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        private void FolyosoMenü()
        {
            Console.WriteLine("Folyosó");
            Console.WriteLine("-------");
            Console.WriteLine("Kilépsz a teremből a folyosóra. Balra a tanterem, jobbra a tanári szoba.");
            Console.WriteLine("A tanári ajtó zárva van, és egy kódbemenet is van rajta.");
            Console.WriteLine();
            Console.WriteLine("Lehetséges akciók:");
            Console.WriteLine("  1) Visszamegyek a tanterembe");
            Console.WriteLine("  2) Megvizsgálom a tanári ajtaját");
            Console.WriteLine("  3) Megpróbálok bejutni a tanáriba (kulcs + kód)");
            Console.WriteLine("  0) Kilépés a játékból");

            int val = BekerValasztas(0, 3);
            switch (val)
            {
                case 1:
                    _jatekos.AktuálisHelyszin = Helyszin.Tanterem;
                    break;
                case 2:
                    TanariAjtoVizsgalata();
                    break;
                case 3:
                    TanariAjtoKinyitasa();
                    break;
                case 0:
                    _kilep = true;
                    break;
            }
        }

        private void TanariAjtoVizsgalata()
        {
            Console.WriteLine();
            Console.WriteLine("A tanári ajtaja masszív faajtó, rajta egy kis kódbillentyűzet.");
            Console.WriteLine("Úgy tűnik, kell egy kulcs is a fizikai zárhoz, nem elég csak a kód.");
            Console.WriteLine();
            if (_jatekos.VanTargy("Kis kulcs"))
            {
                Console.WriteLine("Nálad van egy kis kulcs, valószínűleg ehhez az ajtóhoz tartozik.");
            }
            else
            {
                Console.WriteLine("Nincs nálad kulcs, előbb azt kellene megszerezned.");
            }

            if (_jatekos.VanTargy("Cetli a tanári kódhoz"))
            {
                Console.WriteLine("A zsebedben ott a cetli a kódról – csak jól kell megfejteni.");
            }

            Console.WriteLine();
            Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        private void TanariAjtoKinyitasa()
        {
            Console.WriteLine();

            if (!_jatekos.VanTargy("Kis kulcs"))
            {
                Console.WriteLine("Hiába ismernéd a kódot, kulcs nélkül nem tudod elfordítani a zárat.");
                Console.WriteLine("Előbb szerezz egy kulcsot a tanteremben!");
                Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Van nálad egy kulcs. Most már csak a kódot kell beírni.");
            Console.WriteLine("Gondold végig a nyomokat:");
            Console.WriteLine("  - Informatikaterem: 305");
            Console.WriteLine("  - 'TANAR' szó betűi: 5");
            Console.WriteLine("  - A mai dátum napja: válassz egy tetszőleges (pl. 14) a feladathoz.");
            Console.WriteLine();
            Console.Write("Írd be a háromjegyű kódot a tanári ajtajához: ");
            string kod = Console.ReadLine()?.Trim() ?? "";

            // pl. 3 5 1 -> 351, 3 0 5 -> 305 vagy 3 5 4, a lényeg, hogy legyen egy fix várható kód
            if (kod == "305")
            {
                Console.WriteLine();
                Console.WriteLine("Katt... A kód elfogadva. A kulcs is elfordul a zárban.");
                Console.WriteLine("Az ajtó kinyílt, beléphetsz a tanáriba.");
                _jatekos.TanariAjtoNyitva = true;
                _jatekos.AktuálisHelyszin = Helyszin.TanariSzoba;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("A kód hibás. Az ajtó zárva marad.");
            }

            Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        private void TanariMenü()
        {
            Console.WriteLine("Tanári szoba");
            Console.WriteLine("------------");
            Console.WriteLine("Belépsz a tanáriba. Egy hosszú asztal, sok papír és szekrények mindenütt.");
            Console.WriteLine("A sarokban látsz egy szekrényt, rajta a neveddel.");
            Console.WriteLine();
            Console.WriteLine("Lehetséges akciók:");
            Console.WriteLine("  1) Megnézem a nevemmel ellátott szekrényt");
            Console.WriteLine("  2) Körbenézek más nyomok után");
            Console.WriteLine("  0) Kilépés (feladod a keresést)");

            int val = BekerValasztas(0, 2);
            switch (val)
            {
                case 1:
                    SzekrenyFeladat();
                    break;
                case 2:
                    TanariKorulNezek();
                    break;
                case 0:
                    _kilep = true;
                    break;
            }
        }

        private void SzekrenyFeladat()
        {
            if (_jatekos.TelefonMegvan)
            {
                Console.WriteLine();
                Console.WriteLine("Már kinyitottad a szekrényt és megszerezted a telefonodat.");
                Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("A szekrényen egy egyszerű rejtvény van, amit meg kell oldanod:");
            Console.WriteLine();
            Console.WriteLine("  \"A telefonodat elvettem, de visszakaphatod, ha válaszolsz:");
            Console.WriteLine("   Mi az, amit az órán használnod KELLENE, de a telefonodon");
            Console.WriteLine("   pörgeted inkább az Instagramot?\"");
            Console.WriteLine();
            Console.WriteLine("Tipp: valami, ami segít az interaktív tanulásban, de nem digitális.");
            Console.WriteLine();

            Console.Write("Írd be a választ (egy szó): ");
            string valasz = (Console.ReadLine() ?? "").Trim().ToLower();

            if (valasz == "fuzet" || valasz == "füzet")
            {
                Console.WriteLine();
                Console.WriteLine("A zár kattan, a szekrény kinyílik.");
                Console.WriteLine("Bent megtalálod a TELEFONODAT! 📱");
                _jatekos.TelefonMegvan = true;
                _jatekos.HozzaadTargy("Telefon");

                JatekNyertel();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("A szekrény zárva marad. Úgy tűnik, nem erre a válaszra gondolt a tanár.");
                Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
                Console.ReadKey();
            }
        }

        private void TanariKorulNezek()
        {
            Console.WriteLine();
            Console.WriteLine("Körbenézel a tanáriban, jegyzetek, naplók és különböző szekrények mindenütt.");
            Console.WriteLine("Semmi különöset nem találsz, úgy tűnik, a te telefonod csak a névvel ellátott szekrényben lehet.");
            Console.WriteLine();
            Console.WriteLine("Nyomj egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        private void JatekNyertel()
        {
            Console.WriteLine();
            Console.WriteLine("GRATULÁLUNK! 🎉");
            Console.WriteLine("----------------");
            Console.WriteLine("Sikerült visszaszerezned a telefonodat a tanártól!");
            Console.WriteLine($"Időben: {_ido.Elapsed.Minutes:D2}:{_ido.Elapsed.Seconds:D2} perc alatt.");
            Console.WriteLine();
            Console.WriteLine("A játék során logikai feladatokat oldottál meg, kódokat fejtettél meg,");
            Console.WriteLine("és kreatívan használtad a nyomokat – pont úgy, ahogy a projektleírásban szerepel. :)");
            Console.WriteLine();
            Console.WriteLine("Nyomj egy gombot a kilépéshez...");
            Console.ReadKey();
            _kilep = true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var jatek = new Jatek();
            jatek.Futtatas();
        }
    }
}
