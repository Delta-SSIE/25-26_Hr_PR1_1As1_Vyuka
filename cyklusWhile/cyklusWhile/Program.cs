namespace cyklusWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;
            do
            {
                Console.WriteLine("Cislo je: " + cislo);
                cislo++; //cislo = cislo + 1;
            }
            while (cislo <= 5);

            cislo = 0;
            while (cislo < 6)
            {
                Console.WriteLine("Cislo je " + cislo);
                cislo++;
            } ;

            cislo = 0;
            while (true)
            {
                Console.WriteLine("Hodnota je: " + cislo);
                cislo++;
                if (cislo == 6)
                {
                    break;
                }
            }
        }
    }
}
