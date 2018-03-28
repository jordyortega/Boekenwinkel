using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinken
{
    public class Bestelling
    {
        public DateTime Besteldatum { get; set; }
        public List<Product> BestelProduct { get; set; }
        public bool Afgehandeld { get; set; }
    }

}
