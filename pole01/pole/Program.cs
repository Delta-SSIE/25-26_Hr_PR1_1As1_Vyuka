namespace pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velikost;
            Console.WriteLine("Zadej velikost pole: ");
            while ((int.TryParse(Console.ReadLine(), out velikost) == false) || velikost <= 0)
            {
                Console.WriteLine("Neplatna hodnota, zadej hodnotu znova.");
            }
            int[] pole = new int[velikost];
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine($"Zadej hodnotu na pozici: {i}");
                while (int.TryParse(Console.ReadLine(), out pole[i]) == false)
                {
                    Console.WriteLine("Neplatna hodnota");
                };
            }

            Console.WriteLine("Hodnoty v poli: ");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }

           /* for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = pole[i] * (-1);
            }

            Console.WriteLine("Hodnoty v poli po carovani: ");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }
           */
            int soucet = 0;
            for (int i = 0; i < pole.Length; i++) { 
            soucet = soucet + pole[i];
            }
            Console.WriteLine("Soucet hodnot v poli je " + soucet);
        }
    }
}
