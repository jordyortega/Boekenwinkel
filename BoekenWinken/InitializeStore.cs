using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinken
{
    public class InitializeStore
    {
        public List<Product> ProductLijst;
        public List<Bestelling> BestelLijst;

        public InitializeStore()
        {
            ProductLijst = new List<Product>();
            BestelLijst = new List<Bestelling>();
            var boek1 = new Boek
            {
                Titel = "boek1",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISBN = "9748675948765",
                Druk = "eerste druk",
                Voorraad = 3,
                MinimumVoorraad = 3,
                MaximumVoorraad = 10
            };


            var boek2 = new Boek
            {
                Titel = "boek2",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISBN = "9748675948765",
                Druk = "eerste druk",
                Voorraad = 3,
                MinimumVoorraad = 3,
                MaximumVoorraad = 10
            };

            var boek3 = new Boek
            {
                Titel = "boek3",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISBN = "9748675948765",
                Druk = "eerste druk",
                Voorraad = 3,
                MinimumVoorraad = 3,
                MaximumVoorraad = 10
            };

            var boek4 = new Boek
            {
                Titel = "boek4",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISBN = "9748675948765",
                Druk = "eerste druk",
                Voorraad = 3,
                MinimumVoorraad = 3,
                MaximumVoorraad = 10
            };

            var boek5 = new Boek
            {
                Titel = "boek5",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISBN = "9748675948765",
                Druk = "eerste druk",
                Voorraad = 3,
                MinimumVoorraad = 3,
                MaximumVoorraad = 10
            };
            ProductLijst.Add(boek1);
            ProductLijst.Add(boek2);
            ProductLijst.Add(boek3);
            ProductLijst.Add(boek4);
            ProductLijst.Add(boek5);

            var schrift1 = new Tijdschrift
            {
                Titel = "schrift1",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISSN = "9748675948765",
                BestelAantal = 50,
                Besteldag = "maandag"
            };

            var schrift2 = new Tijdschrift
            {
                Titel = "schrift2",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISSN = "9748675948765",
                BestelAantal = 50,
                Besteldag = "maandag"
            };

            var schrift3 = new Tijdschrift
            {
                Titel = "schrift3",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISSN = "9748675948765",
                BestelAantal = 50,
                Besteldag = "maandag"
            };

            var schrift4 = new Tijdschrift
            {
                Titel = "schrift4",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISSN = "9748675948765",
                BestelAantal = 50,
                Besteldag = "maandag"
            };

            var schrift5 = new Tijdschrift
            {
                Titel = "schrift5",
                Aantal = 6,
                Auteur = "J.K. Rowling",
                Taal = "Nederlands",
                Prijs = (decimal) 14.50,
                Afmeting = "50 bij 80 bij 5",
                Gewicht = "400g",
                ISSN = "9748675948765",
                BestelAantal = 50,
                Besteldag = "maandag"
            };

            ProductLijst.Add(schrift1);
            ProductLijst.Add(schrift2);
            ProductLijst.Add(schrift3);
            ProductLijst.Add(schrift4);
            ProductLijst.Add(schrift5);


            var bestelling1 = new Bestelling
            {

                //copyright by Dyon Doornkamp
                Besteldatum = Convert.ToDateTime(new DateTime().Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.AddDays(5).AddYears(2017).AddMonths(9).Date.Date.AddDays(1).ToShortDateString()),
                // rekt                
                Afgehandeld = false,
                BestelProduct = ProductLijst
            };


            var bestelling2 = new Bestelling
            {
                //copyright by Dyon Doornkamp
                Besteldatum = Convert.ToDateTime(new DateTime().Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.AddDays(5).AddYears(2017).AddMonths(9).Date.Date.AddDays(1).ToShortDateString()),
                // rekt                
                Afgehandeld = false,
                BestelProduct = ProductLijst

            };
            

            var bestelling3 = new Bestelling
            {
                //copyright by Dyon Doornkamp
                Besteldatum = Convert.ToDateTime(new DateTime().Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.AddDays(5).AddYears(2017).AddMonths(9).Date.Date.AddDays(1).ToShortDateString()),
                // rekt                
                Afgehandeld = true,
                BestelProduct = ProductLijst

            };
            

            var bestelling4 = new Bestelling
            {
                //copyright by Dyon Doornkamp
                Besteldatum = Convert.ToDateTime(new DateTime().Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.AddDays(5).AddYears(2017).AddMonths(9).Date.Date.AddDays(1).ToShortDateString()),
                // rekt                
                Afgehandeld = false,
                BestelProduct = ProductLijst

            };
           

            var bestelling5 = new Bestelling
            {
                //copyright by Dyon Doornkamp
                Besteldatum = Convert.ToDateTime(new DateTime().Date.Date.Date.Date.Date.Date.Date.Date.Date.Date.AddDays(5).AddYears(2017).AddMonths(9).Date.Date.AddDays(1).ToShortDateString()),
                // rekt
                Afgehandeld = true,
                BestelProduct = ProductLijst

            };
          

            BestelLijst.Add(bestelling1);
            BestelLijst.Add(bestelling2);
            BestelLijst.Add(bestelling3);
            BestelLijst.Add(bestelling4);
            BestelLijst.Add(bestelling5);
        }
    }
}