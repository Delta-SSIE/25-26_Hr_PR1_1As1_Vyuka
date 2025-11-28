namespace PoleSudeLiche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole;
            int pocet;
            Console.WriteLine("Zadej pocet hodnot:");
            while(int.TryParse(Console.ReadLine(), out pocet) == false || pocet <= 0)
            {
                Console.WriteLine("Nespravne zadana hodnota, zadej znovu:");
            }

            pole = new int[pocet];
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine($"Pro prvek na pozici {i} zadej hodnotu mezi 1 a 10:");
                while(int.TryParse(Console.ReadLine(),out pole[i]) == false || pole[i] <1 || pole[i] > 10)
                {
                    Console.WriteLine("Zadal jsi neplatnou hodnotu, zadej znovu:");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < pole.Length; i++) {
                Console.WriteLine(pole[i]);
            }
            string suda = "Suda cisla jsou: ";
            string licha = "Licha cisla jsou: ";
            for (int i = 0; i < pole.Length; i++) {
                if (pole[i]%2 == 0)
                {
                    suda = suda + pole[i] + ", ";
                }
                else
                {
                    licha = licha + pole[i] + ", ";
                }
            }
            Console.WriteLine("\n" + suda);
            Console.WriteLine(licha);
        }
    }
}
