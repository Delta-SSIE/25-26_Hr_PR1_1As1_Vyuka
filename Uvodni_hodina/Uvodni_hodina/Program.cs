namespace Uvodni_hodina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   String slovo1;
               String slovo2;
               Console.WriteLine("Zadej 1. slovo");
               slovo1 = Console.ReadLine();
               Console.WriteLine("Zadej 2.slovo");
               slovo2 = Console.ReadLine();
               Console.WriteLine("Slovo 1 bylo: " + slovo1 + " Slovo 2 bylo: " + slovo2);
            */
            int a;
            int b;
            int vysledek;
            Console.WriteLine("Zadej prvni hodnotu:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhou hodnotu:");
            b = int.Parse(Console.ReadLine());
            vysledek = a + b;
            Console.WriteLine("Vysledek souctu je: " + vysledek);

        }
    }
}
