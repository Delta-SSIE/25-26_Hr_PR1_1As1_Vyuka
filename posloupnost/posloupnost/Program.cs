namespace posloupnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("zadej cislo n");
                n = int.Parse(Console.ReadLine());
            } while (n <= 2);
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Zadej hodnotu");
                pole[i] = int.Parse(Console.ReadLine());
            }
            bool rostouci = true;
            bool klesajici = true;
            for (int i = 0; i < n-1; i++) {
                if (pole[i] >= pole[i + 1])
                {
                    rostouci = false;
                }
                if (pole[i] <= pole[i + 1])
                {
                    klesajici = false;
                }
                if(rostouci == false && klesajici == false)
                {
                    Console.WriteLine("Posloupnost neni ani rostouci ani klesajici.");
                    break;
                }
            }
            if (rostouci)
                Console.WriteLine("Posloupnost je rostouci.");
            if (klesajici)
                Console.WriteLine("Posloupnost je klesajici.");
        }
    }
}
