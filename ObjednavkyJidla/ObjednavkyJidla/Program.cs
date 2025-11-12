namespace ObjednavkyJidla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####################");
            Console.WriteLine("# Objednavky jidla  #");
            Console.WriteLine("#####################");

            string jmeno, heslo;
            string dnesniJidlo = "UHO s knedlikem";
            int  stavUctu, volba;
            int pocetJidel = 10;

            do
            {
                Console.WriteLine("Vyber akci:");
                Console.WriteLine("1. Prihlasit se");
                Console.WriteLine("2. Ukoncit");
                volba = int.Parse(Console.ReadLine());
                if (volba == 1)
                {
                    Console.WriteLine("Zadej jmeno:");
                    string nacteneJmeno = Console.ReadLine();
                    if(nacteneJmeno == "kucharka" || nacteneJmeno == "student")
                    {
                        Console.WriteLine("Zadej heslo");
                        heslo = Console.ReadLine();
                        
                        if (nacteneJmeno == "kucharka" && heslo == "varim123")
                        {
                            Console.WriteLine("Je prihlasena kucharka.");
                            int volbaKucharka;

                            do
                            {
                                Console.WriteLine("1. Zadej jidlo dne");
                                Console.WriteLine("2. Vydej jidlo");
                                Console.WriteLine("3. Navrat do menu");
                                volbaKucharka = int.Parse(Console.ReadLine());
                                if(volbaKucharka == 1)
                                {
                                    Console.WriteLine("Probiha akce 1");
                                    Console.WriteLine("Zadej dnesni jidlo dne:");
                                    dnesniJidlo = Console.ReadLine();
                                    Console.WriteLine("Jidlo nacteno.");
                                }
                                else if (volbaKucharka == 2)
                                {
                                    Console.WriteLine("Probiha akce 2");
                                    if (pocetJidel > 0)
                                    {
                                        pocetJidel--;
                                        Console.WriteLine("Jidlo vydano.");
                                    } else { 
                                        Console.WriteLine("Nedostatecna kapacita jidel.");
                                    }

                                }
                                else if(volbaKucharka == 3)
                                {
                                    Console.WriteLine("Probiha navrat do menu");
                                }
                            } while (volbaKucharka != 3);



                        }
                        else if (nacteneJmeno == "student" && heslo == "ucimse123")
                        {
                            Console.WriteLine("Je prihlaseny student.");
                        }
                        else
                        {
                            Console.WriteLine("Zadane heslo neni spravne.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Zadal jsi neplatnou volbu");
                    }

                }
                else if (volba > 2 || volba < 1)
                    Console.WriteLine("Neplatna volba");


            } while (volba != 2);
        }
    }
}
