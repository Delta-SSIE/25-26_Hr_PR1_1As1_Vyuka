using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceZapasu
{
    internal class Tym
    {
        private string nazev;
        private List<Hrac> seznamHracu;

        public Tym (string nazev)
        {
         this.nazev = nazev;  
         seznamHracu = new List<Hrac> ();
        }
    }
}
