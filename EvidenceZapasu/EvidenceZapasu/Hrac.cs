using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceZapasu
{
    internal class Hrac
    {
        private int cislo;
        private string jmeno;
        private string prijmeni;
        private string velikostDresu;
        
        public Hrac()
        {
            this.cislo = 0;
            this.jmeno = "nezname";
            this.prijmeni = "nezname";
            this.velikostDresu = "0";
        }

        public Hrac(int c, string jm, string pr, string vel)
        {
            this.cislo = c;
            this.jmeno = jm;
            this.prijmeni = pr;
            this.velikostDresu = vel;
        }
        public int getCislo()
        {
            return this.cislo;
        }
        public string getJmeno()
        {
            return this.jmeno;
        }
        public string getPrijmeni()
        {
            return this.prijmeni;
        }
        public string getVelikost()
        {
            return this.velikostDresu;
        }

        public void setCislo(int cislo)
        {
            this.cislo = cislo;
        }
        public void setJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public void setPrijmeni(string prijmeni)
        {
            this.prijmeni = prijmeni;
        }
        public void setVelikost(string velikost)
        {
            this.velikostDresu = velikost;
        }

        public void PredstavSe()
        {
            Console.WriteLine("Hrac cislo {0} jmeno: {1} prijmeni:{2} velikost dresu: {3}", this.cislo, this.jmeno, this.prijmeni, this.velikostDresu);
        }
    }
}
