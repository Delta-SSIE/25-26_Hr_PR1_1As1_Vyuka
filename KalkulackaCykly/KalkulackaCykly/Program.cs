namespace KalkulackaCykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KALKULACKA");
            Console.WriteLine("############");

            int volba = 0;

            do
            {
                Console.WriteLine("1. Vypis jmeno");
                Console.WriteLine("2. Vypis cisla do ..");
                Console.WriteLine("3. Pocetni operace");
                Console.WriteLine("4. Konec");

                Console.WriteLine("Zadej hodnotu sve volby:");
                
                while(int.TryParse(Console.ReadLine(),out volba) == false)
                {
                    Console.WriteLine("Zadej hodnotu");
                }
             switch (volba)
                {
                    case 1:
                        Console.WriteLine("Ahoj vitej v aplikaci kalkulacka.");
                        break;
                    case 2:
                        int koncove;
                        Console.WriteLine("Zadej koncovou hodnotu:");
                        while ((int.TryParse(Console.ReadLine(),out koncove) == false) || koncove<=0)
                        {
                            Console.WriteLine("Neplatna hodnota. Zadej hodnotu znovu.");
                        }
                        Console.WriteLine($"Vypis hodnot do {koncove}");
                        for (int i = 0; i <= koncove; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 3:
                        int volbaOperace;

                        Console.WriteLine("1. soucet");
                        Console.WriteLine("2. rozdil");
                        Console.WriteLine("3. nasobeni");
                        Console.WriteLine("4. deleni");

                        while((int.TryParse(Console.ReadLine(), out volbaOperace) == false) || volbaOperace>4 || volbaOperace<1)
                        {
                            Console.WriteLine("Neplatna volba, zadej hodnotu znovu:");
                        }
                        int a, b;
                        Console.WriteLine("Zadej hodnotu a: ");
                        while (int.TryParse(Console.ReadLine(),out a) == false)
                        {
                            Console.WriteLine("Neplatna hodnota");
                        }
                        Console.WriteLine("Zadej hodnotu b: ");
                        while (int.TryParse(Console.ReadLine(), out b) == false)
                        {
                            Console.WriteLine("Neplatna hodnota");
                        }

                        switch (volbaOperace)
                        {
                            case 1:
                                Console.WriteLine($"Soucet cisel {a} a {b} je {a + b}");
                                break;
                            case 2:
                                Console.WriteLine($"Rozdil cisel {a} a {b} je {a - b}");
                                break;
                            case 3:
                                Console.WriteLine($"Soucin cisel {a} a {b} je {a * b}");
                                break;
                            case 4:
                                if (b == 0)
                                    Console.WriteLine("Nelze delit 0");
                                else
                                    Console.WriteLine($"Podil cisel {a} a {b} je {(double) a / b}");
                                break;
                        }




                        break;
                    case 4: break;
                }
            } while (volba != 4);


    }
    }
}
