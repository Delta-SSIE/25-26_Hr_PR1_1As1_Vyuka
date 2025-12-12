namespace Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Promo();
            Console.WriteLine("Zadej sve jmeno:");
            string jmeno = Console.ReadLine();
            Pozdrav(jmeno);

            Console.WriteLine("Zadej hodnotu a:");
            int a;
            while (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("Chybna hodnota, Zadej hodnotu:");
            }

            Console.WriteLine("Zadej hodnotu b:");
            int b;
            while (int.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.WriteLine("Chybna hodnota, Zadej hodnotu:");
            }
            int cislo = Soucet(a, b);
            Console.WriteLine("Vysledek souctu je " + cislo);

            Console.WriteLine("Generuji nahodne cislo: " + Nahodne());
            
        }
        public static void Pozdrav (string uzivatel) //bez navratoveho typu, s parametrem
        {
            Console.WriteLine("Ahoj, vitej v Kalkulacce.");
            Console.WriteLine("Jak se mas: " + uzivatel);
        }

        public static void Promo()//bez navratoveho typu, bez parametru
        {
            Console.WriteLine("=======================");
            Console.WriteLine("||   Kalkulacka 2025 ||");
            Console.WriteLine("=======================");
        }

        public static int Soucet (int bz, int fn) { //s navratovym typem, s parametry
            int vysledek = 0;
            vysledek = bz + fn;
            return vysledek;
        }

        public static int Nahodne() //s navratovym typem, bez parametru
        {
            Random r = new Random();//vytvoreni generatoru
            int hodnota = r.Next(1, 11);
            return hodnota;
        }
    }
}
