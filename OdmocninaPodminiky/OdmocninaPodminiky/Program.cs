namespace OdmocninaPodminiky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vysledek;
            Console.WriteLine("Zadej mi hodnotu k odmocnění");
            int hodnota = int.Parse(Console.ReadLine());
            if (hodnota > 0)
            {
                vysledek = Math.Sqrt(hodnota);
                Console.WriteLine("Odmocnina je: " + vysledek);
            }
            else
            {
                Console.WriteLine("Nelze odmocnit.");
            }
        }
    }
}
