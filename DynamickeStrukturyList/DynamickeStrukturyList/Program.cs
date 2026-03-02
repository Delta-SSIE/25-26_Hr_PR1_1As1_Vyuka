namespace DynamickeStrukturyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyber = int.MaxValue;
            List<string> studenti = new List<string>();
            List<int> znamky = new List<int>();
            int pozice;
            do
            {
                vyber = VypisMenu();
              
                switch (vyber)
                {
                    case 1:
                        Console.WriteLine("Zadej jmeno studenta:");
                        studenti.Add(Console.ReadLine());
                        Console.WriteLine("Zadej mi znamku:");
                        int znamka;
                        while ((int.TryParse(Console.ReadLine(), out znamka) == false) || (znamka < 0) || (znamka > 5))
                        {
                            Console.WriteLine("Chybne zadana hodnota.");
                        }
                        znamky.Add(znamka);
                        break;
                    case 2:
                        Console.WriteLine("Zadej jmeno:");
                        string hledane = Console.ReadLine();
              
                        if (studenti.Find(x => x == hledane) != null) {
                           pozice = studenti.IndexOf(hledane);
                            int zn = znamky[pozice];
                            Console.WriteLine("Student nalezen na pozici {0} a má známku {1}.",pozice, zn);
                        }
                        else
                            Console.WriteLine("Student nenalezen.");
                        break;
                    case 3:
                        Console.WriteLine("Zadej jmeno pro odstraneni:");
                        string odeber = Console.ReadLine();
                        pozice = studenti.IndexOf(odeber);
                        if (studenti.Remove(odeber))
                        {
                            znamky.RemoveAt(pozice);
                            Console.WriteLine("Student {0} byl odstranen.", odeber);
                        }
                        else
                            Console.WriteLine("Student {0} nebyl nalezen.", odeber);

                            break;
                    case 4:
                        Console.WriteLine("SEZNAM STUDENTU:");
                        int p = 0;
                        foreach (string s in studenti) { 
                        Console.WriteLine("{0} se znamkou {1}", s, znamky[p]);
                            p++;
                        }
                        break;

                }



            } while (vyber != 5);
           /* List<int> znamky = new List<int>();
            int znamka = int.MaxValue;
            do
            {
                Console.WriteLine("Zadej mi znamku:");
                while((int.TryParse(Console.ReadLine(), out znamka) == false) || (znamka<0) || (znamka>5))
                {
                    Console.WriteLine("Chybne zadana hodnota.");
                }

                if(znamka!=0)
                znamky.Add(znamka);

            } while (znamka != 0);
            VypisZnamky(znamky);*/
        }
        public static void VypisZnamky(List<int> z)
        {
            /* for(int i = 0; i < z.Count; i++)
             {
                 Console.WriteLine("Hodnota znamky je: " + z[i]);
             }*/
            foreach (int hodnota in z) {
                Console.WriteLine("Znamka je: {0}", hodnota);
            }
        }

        public static int VypisMenu() {
            int volba = int.MaxValue;
            do
            {
                Console.WriteLine("StudentApp");
                Console.WriteLine("1. Pridej studenta");
                Console.WriteLine("2. Vyhledej studenta");
                Console.WriteLine("3. Odeber studenta");
                Console.WriteLine("4. Vypis studenty");
                Console.WriteLine("5. KONEC");
                while ((int.TryParse(Console.ReadLine(), out volba) == false))
                {
                    Console.WriteLine("Zadej znovu hodnotu");
                }

            } while ((volba < 1) || (volba > 5));
            return volba;
        }
    }
}
