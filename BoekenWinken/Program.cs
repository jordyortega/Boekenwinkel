using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinken
{
    class Program
    {
     
        public static BoekenWinkel boekenwinkel = new BoekenWinkel();
        public static InitializeStore store = new InitializeStore();
        static void Main(string[] args)
        {
            int Switcher;
            do
            {
                Console.WriteLine("[1]Boek Bestellen");
                Console.WriteLine("[2]Schrift Bestellen");
                Console.WriteLine("[3]Boeken op voorraad tonen");
                Console.WriteLine("[4]Schriften op voorraad tonen");
                Console.WriteLine("[5]Boek verwijderen");
                Console.WriteLine("[6]Schrift verwijderen");
                Console.WriteLine("[7]Bestellijst genereren");
                Console.WriteLine("[8]Nog niet verwerkte bestellingen tonen");
                Console.WriteLine("[9]Bestelling inzien uit het verleden");
                Console.WriteLine("[10]Aantal bestellingen van een boek aanpassen");
                Console.WriteLine("[11]Aantal bestellingen van een schrift aanpassen");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Nummer van de functie? ");
                Console.WriteLine("-------------------------------------");
                Switcher = Int32.Parse(Console.ReadLine());
                switch (Switcher)
                {
                    case 1:
                        Functie1();
                        break;
                    case 2:
                        Functie2();
                        break;
                    case 3:
                        Functie3();
                        break;
                    case 4:
                        Functie4();
                        break;
                    case 5:
                        Functie5();
                        break;
                    case 6:
                        Functie6();
                        break;
                    case 7:
                        Functie7();
                        break;
                    case 8:
                        Functie8();
                        break;
                    case 9:
                        Functie9();
                        break;
                    case 10:
                        Functie10();
                        break;
                    case 11:
                        Functie11();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (Switcher != 0);
        }

        private static void Functie1()
        {
            int Switcher;
            do
            {
                Console.WriteLine("Boek Bestellen");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("[0]Bestel via ISBN");
                Console.WriteLine("[1]Bestel via Titel en auteur");
                Console.WriteLine("-------------------------------------");
                Switcher = Int32.Parse(Console.ReadLine());

                switch (Switcher)
                {
                    case 1:
                        Functieisbn();
                        break;
                    case 2:
                        Functietitel();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (Switcher != 0);
        

    }

    private static void Functieisbn()
        {
            Console.WriteLine("Boek Bestellen via ISBN");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("type het ISBN nummer van het boek dat u wilt bestellen.");
            var isbn = Console.ReadLine();
            Console.WriteLine("Hoevaak wilt u dit boek bestellen?");
            var aantal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(boekenwinkel.BoekVerkopen(isbn, aantal));
            boekenwinkel.ToonAlleBoeken();
            restart();
        }

        private static void Functietitel()
        {
            Console.WriteLine("Boek Bestellen via titel en auteur");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("type de titel van het boek dat u wilt bestellen");
            var titel = Console.ReadLine();
            Console.WriteLine("type de auteur van het boek dat u wilt bestellen");
            var auteur = Console.ReadLine();
            Console.WriteLine("Hoevaak wilt u dit boek bestellen?");
            var aantal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(boekenwinkel.BoekVerkopen(titel, auteur, aantal));
            boekenwinkel.ToonAlleBoeken();
            restart();
        }

        private static void Functie2()
        {
            Console.WriteLine("Schrift Bestellen via ISSN");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("type het ISSN nummer van het schrift dat u wilt bestellen.");
            var issn = Console.ReadLine();
            Console.WriteLine("Hoevaak wilt u dit schrift bestellen?");
            var aantal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(boekenwinkel.BoekVerkopen(issn, aantal));
            boekenwinkel.ToonAlleBoeken();
            restart();
        }

        public static void Functie3()
        {
            Console.WriteLine("Boeken op voorraad tonen");
            Console.WriteLine("-------------------------------------");
            boekenwinkel.ToonAlleBoeken();
            restart();
        }

        private static void Functie4()
        {
            Console.WriteLine("Schriften op voorraad tonen");
            Console.WriteLine("-------------------------------------");
            boekenwinkel.ToonAlleSchriften();
            restart();
        }

        private static void Functie5()
        {
            Console.WriteLine("Boek verwijderen");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Type het nummer van het boek dat u wilt verwijderen.");
            int index = Convert.ToInt16(Console.ReadLine());
            boekenwinkel.BoekVerwijderen(index);
            restart();
        }

        private static void Functie6()
        {
            Console.WriteLine("Schrift verwijderen");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Type het nummer van het schrift dat u wilt verwijderen.");
            int index = Convert.ToInt16(Console.ReadLine());
            boekenwinkel.SchriftVerwijderen(index);
            Console.ReadKey();
            restart();
        }

        private static void Functie7()
        {
            Console.WriteLine("Bestellijst genereren");
            Console.WriteLine("-------------------------------------");
            List<string> bestelregels = boekenwinkel.BestelLijstGenereren();
            var i = 0;
            foreach (var item in bestelregels)
            {
                Console.WriteLine("[" + i + "]" + item);
                i++;
            }

            restart();
        }

        private static void Functie8()
        {
            Console.WriteLine("Nog niet verwerkte bestellingen tonen");
            Console.WriteLine("-------------------------------------");
            boekenwinkel.NietAfgehandeldeBestellingen();
            restart();
        }

        private static void Functie9()
        {
            Console.WriteLine("Bestelling inzien uit het verleden");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Vul een datum in waarop u bestellingen wilt bekijken!");
            var datum = Convert.ToDateTime(Console.ReadLine());
            List<string> bestelregels = boekenwinkel.BestellingInzienOpDatum(datum);
            var i = 0;
            foreach (var item in bestelregels)
            {
                Console.WriteLine("[" + i + "]" + item);
                i++;
            }

            Console.ReadKey();
            restart();
        }

        private static void Functie10()
        {
            Console.WriteLine("Aantal bestellingen van een boek aanpassen");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Vul het ISBN nummer in");
            var isbn = Console.ReadLine();
            Console.WriteLine("Vul het minimum aantal op voorraad in");
            var min = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Vul het maximum aantal op voorraad in");
            var max = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(boekenwinkel.BestelBoekAanpassen(isbn, min, max));
            Console.ReadKey();
            restart();
        }

        private static void Functie11()
        {
            Console.WriteLine("Aantal bestellingen van een schrift aanpassen");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Vul het ISSN nummer in");
            var issn = Console.ReadLine();
            Console.WriteLine("Vul het aantal te bestellen schriften in");
            var aantal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(boekenwinkel.BestelSchriftAanpassen(issn, aantal));
            Console.ReadKey();
            restart();
        }

        private static void restart()
        {
            var fileName = Assembly.GetExecutingAssembly().Location;
            System.Diagnostics.Process.Start(fileName);
            Environment.Exit(0);
        }
    }
}