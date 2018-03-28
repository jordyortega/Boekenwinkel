using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinken
{
    public class Boek : Product
    {
        public string Druk { get; set; }
        public string ISBN { get; set; }
        public int MinimumVoorraad { get; set; }
        public int Voorraad { get; set; }
        public int MaximumVoorraad { get; set; }

      
    }
}