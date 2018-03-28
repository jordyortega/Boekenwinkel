using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenWinken
{
    public class Tijdschrift : Product
    {
        public string ISSN { get; set; }
        public int BestelAantal { get; set; }
        public string Besteldag { get; set; }
       
     
    }
    
}
