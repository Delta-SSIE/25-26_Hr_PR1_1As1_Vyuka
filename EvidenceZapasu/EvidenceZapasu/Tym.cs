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

        public Tym()
        {
            this.nazev = "prazdny";
            seznamHracu = new List<Hrac>();
        }

        public string GetNazev() { 
        return this.nazev;
        }
        public List<Hrac> GetHraci()
        {
            return this.seznamHracu;
        }
        public void SetNazev(string nazev)
        {
            this.nazev = nazev;
        }
        public void SetHrac(Hrac h)
        {
            this.seznamHracu.Add(h);
        }

        public Hrac NajdiHrace(int cislo)
        {
           Hrac nalezen = this.seznamHracu.Find(h => h.getCislo() == cislo);
            return nalezen;
        }
    }
}
