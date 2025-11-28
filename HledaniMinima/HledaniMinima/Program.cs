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
            int poziceMin = 0;
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < minimum)
                {
                    minimum = pole[i];
                    poziceMin = i;
                }
            }
            Console.WriteLine("Minimalni hodnota je: " + minimum);

            int maximum = pole[0];
            int poziceMax = 0;
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] > maximum)
                {
                    maximum = pole[i];
                    poziceMax = i;
                }
            }
            Console.WriteLine("Maximální hodnota je: " + maximum);

            int pom = pole[poziceMax];
            pole[poziceMax] = pole[poziceMin];
            pole[poziceMin] = pom;

            for (int i =0;i< pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }

            Console.WriteLine("Serazeni pole:");
            int min, pozice;
            for(int i = 0; i < pole.Length; i++)
            {
                min = pole[i];
                pozice = i;
                for (int j = i + 1; j < pole.Length; j++)
                {
                    if(pole[j] < min)
                    {
                        min = pole[j];
                        pozice = j;
                    }
                }
                pom = pole[i];
                pole[i] = min;
                pole[pozice] = pom;
            }
            for (int i= 0;i< pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }

        }
    }
}
