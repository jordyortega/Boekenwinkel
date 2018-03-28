using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinken
{
    public class BoekenWinkel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public string Woonplaats { get; set; }
        public string[] Openingstijden { get; set; }
        public List<Bestelling> Bestellingen { get; set; }
        public InitializeStore Store = new InitializeStore();

        public string BoekVerkopen(string ISBN, int Aantal)
        {
            foreach (var item in Store.ProductLijst)
            {
                if (item.ISBN == ISBN)
                {
                    return string.Format(
                        "Titel:{}, ISBN:{}, Aantal Verkochte items: {}, Prijs per stuk:{}, Totaal = {}", item.Titel,
                        item.ISBN, Aantal, item.Prijs, (Aantal * item.Prijs));
                }
            }

            return "Er is geen boek Met dit ISBN nummer aanwezig!";
        }

        public string BoekVerkopen(string titel, string auteur, int Aantal)
        {
            foreach (var item in Store.Boekenlijst)
            {
                if (item.Titel == titel && item.Auteur == auteur)
                {
                    item.Aantal -= Aantal;

                    return string.Format(
                        "Titel:{0}, ISBN:{1}, Aantal Verkochte items: {2}, Prijs per stuk:{3}, Totaal = {4}",
                        item.Titel,
                        item.ISBN, Aantal, item.Prijs, (Aantal * item.Prijs));
                }
            }

            return "Er is geen boek met deze titel van deze auteur!";
        }

        public string TijdschriftVerkopen(string ISSN, int Aantal)
        {
            foreach (var item in Store.ProductLijst)
            {
                if (item.GetType() == typeof(Tijdschrift))
                {
                    if (item. == ISSN)
                    {
                        item.Aantal -= Aantal;
                        return string.Format(
                            "Titel:{0}, ISBN:{1}, Aantal Verkochte items: {2}, Prijs per stuk:{3}, Totaal = {4}",
                            item.Titel,
                            item.ISSN, Aantal, item.Prijs, (Aantal * item.Prijs));
                    }
                }
               
            }

            return "Er is geen boek Met dit ISBN nummer aanwezig!";
        }

        public void ToonAlleBoeken()
        {
            int i = 1;
            foreach (var item in Store.Boekenlijst)
            {
                if (item.Aantal <= 1) continue;
                Console.WriteLine("[" + i + "]" + item.Titel + "  Aantal:" + item.Aantal);
                i++;
            }
        }

        public void ToonAlleSchriften()
        {
            int i = 1;
            if (Store.Schriftenlijst != null)
            {
                foreach (var item in Store.Schriftenlijst)
                {
                    if (item.Aantal > 1)
                    {
                        Console.WriteLine("[" + i + "]" + item.Titel + "  Aantal:" + item.Aantal);
                        i++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Er zijn geen schriften aanwezig wat zijn wij een kut winkel onni da");
            }
        }

        public void BoekToevoegen(Boek boek)
        {
            Store.Boekenlijst.Add(boek);
        }

        public void SchriftToevoegen(Tijdschrift schrift)
        {
            Store.Schriftenlijst.Add(schrift);
        }

        public void BoekVerwijderen(int index)
        {
            Store.Boekenlijst.RemoveAt(index);
        }

        public void SchriftVerwijderen(int index)
        {
            Store.Schriftenlijst.RemoveAt(index);
        }

        public List<string> BestelLijstGenereren()
        {
            var bestelling = new List<string>();
            foreach (var item in Store.Boekenlijst)
            {
                if (item.Voorraad > item.MinimumVoorraad) continue;
                var regel = string.Format("Boek: Titel: {0}, Aantal bestellen: {1}", item.Titel,
                    (item.MaximumVoorraad - item.Voorraad));
                bestelling.Add(regel);
            }

            foreach (var item in Store.Schriftenlijst)
            {
                if (item.Besteldag != DateTime.Now.DayOfWeek.ToString()) continue;
                var regel = string.Format("Schrift: Titel: {0}, Aantal bestellen: {1}", item.Titel,
                    item.BestelAantal);
                bestelling.Add(regel);
            }

            return bestelling;
        }

        public void NietAfgehandeldeBestellingen()
        {
            var bestelling = new List<string>();
            var regel1 = "";
            var regel2 = "";
            var i = 0;

            foreach (var item in Store.BestelLijst)
            {

                if (item.Afgehandeld == false)
                {
                    Console.WriteLine("[" + i + "]");

                    foreach (var item2 in item.BestelBoek)
                    {
                        Console.WriteLine(string.Format("Product: Boek, Titel: {0}, BestelDatum: {1}", item2.Titel,
                            item.Besteldatum));
                    }


                    foreach (var item2 in item.BestelSchrift)
                    {
                        Console.WriteLine(string.Format("Product: Schrift, Titel: {0}, BestelDatum: {1}", item2.Titel,
                            item.Besteldatum));
                    }

                    i++;
                }
            }

//
        }

        public List<string> BestellingInzienOpDatum(DateTime datum)
        {
            var bestelling = new List<string>();
            var regel1 = "";
            var regel2 = "";
            foreach (var item in Store.BestelLijst)
            {
                if (item.Afgehandeld == false)
                {
                    foreach (var item2 in item.BestelBoek)
                    {
                        Console.WriteLine(string.Format("Product: Boek, Titel: {0}, BestelDatum: {1}", item2.Titel,
                            item.Besteldatum));
                    }


                    foreach (var item2 in item.BestelSchrift)
                    {
                        Console.WriteLine(string.Format("Product: Schrift, Titel: {0}, BestelDatum: {1}", item2.Titel,
                            item.Besteldatum));
                    }


                    bestelling.Add(regel1);
                    bestelling.Add(regel2);
                }
            }

            //
            return bestelling;
        }

        public string BestelBoekAanpassen(string ISBN, int minimum, int maximum)
        {
            var regel = "Booek kon niet aangepast worden!";
            foreach (var item in Store.Boekenlijst)
            {
                if (item.ISBN != ISBN) continue;
                item.MinimumVoorraad = minimum;
                item.MaximumVoorraad = maximum;
                regel = "Het minimale aantal en maximale aantal boeken met de titel: " + item.Titel +
                        " is aangepast naar " + minimum + " en " + maximum + "!";
            }

            return regel;
        }

        public string BestelSchriftAanpassen(string ISSN, int aantal)
        {
            var regel = "Schrift kon niet aangepast worden!";
            foreach (var item in Store.Schriftenlijst)
            {
                if (item.ISSN != ISSN) continue;
                item.Aantal = aantal;
                regel = "Het aantal te bestellen schriften van: " + item.Titel +
                        " is aangepast naar " + aantal + "!";
            }

            return regel;
        }
    }
}