using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekenWinken
{
    public class Product
    {
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Taal { get; set; }
        public string Afmeting { get; set; }
        public string Gewicht { get; set; }
        public decimal Prijs { get; set; }
        public int Aantal { get; set; }

    }
}