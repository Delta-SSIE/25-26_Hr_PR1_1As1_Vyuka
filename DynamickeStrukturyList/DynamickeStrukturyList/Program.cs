namespace DynamickeStrukturyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyber = int.MaxValue;
            do
            {
                vyber = VypisMenu();
                switch (vyber)
                {




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
