using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    internal class Student
    {
        private string jmeno;
        private string prijmeni;
        private int vek;
        private List<int> znamky;

        public Student() //bezparametricky konstruktor
        {
            this.jmeno = "prazdne";
            this.prijmeni = "prazdne";
            this.vek = 0;
            znamky = new List<int>();
        }

        public Student(string jm, string pr, int v) //parametricky konstruktor
        {
            this.jmeno= jm;
            this.prijmeni= pr;
            this.vek = v;
            znamky = new List<int>();
        }

        public void setJmeno (string jmeno)
        {
            this.jmeno = jmeno;
        }
        public void setPrijmeni(string prijmeni)
        {
            this.prijmeni = prijmeni;
        }
        public void setVek(int vek)
        {
            this.vek = vek;
        }
        public string getJmeno()
        {
            return this.jmeno;
        }
        public string getPrijmeni()
        {
            return this.prijmeni;
        }
        public int getVek()
        {
            return this.vek;
        }
        public void PredstavSe()
        {
            Console.WriteLine("Ahoj, já jsem student {0} {1} a je mi {2} let.", this.jmeno, this.prijmeni, this.vek);
        }
        public void ZapisZnamku(int zn)
        {
            znamky.Add(zn);
        }

        public void VypisZnamky()
        {
            foreach(int i in znamky)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
