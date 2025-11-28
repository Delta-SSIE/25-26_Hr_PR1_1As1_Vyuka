using System.Security.Authentication.ExtendedProtection;

namespace HledaniMinima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej pocet hodnot");
            int pocet = int.Parse(Console.ReadLine());
            int[] pole = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Zadej hodnotu:");
                pole[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            int minimum = pole[0];
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < minimum)
                {
                    minimum = pole[i];
                }
            }
            Console.WriteLine("Minimalni hodnota je: " + minimum);
        }
    }
}
