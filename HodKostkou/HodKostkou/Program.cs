namespace HodKostkou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(); //generator nahodnych cisel
            int hod = generator.Next(1, 7);//chceme cislo od 1 do 6
            Console.WriteLine("Zadej tip k hodu kostkou:");
            int tip = int.Parse(Console.ReadLine());
            if ((tip > 0) && (tip < 7))
            {
                if (tip > hod)
                {
                    Console.WriteLine("Tipoval jsi vetsi cislo.");
                }
                else if (tip < hod)
                {
                    Console.WriteLine("Tipoval jsi mensi cislo.");
                }
                else
                    Console.WriteLine("Hura, tipnul jsi to.");
            }
            else
            { Console.WriteLine("Neplatna hodnota tipu.");
            }
        }
    }
}
