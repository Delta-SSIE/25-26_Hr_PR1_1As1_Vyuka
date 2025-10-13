using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Zadej souradnici x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadej souradnici y: ");
        y = int.Parse(Console.ReadLine());

        /*
         * if ((x > 0) && (y > 0))
            Console.WriteLine("Bod je v 1. kvadrantu.");
        if ((x < 0) && (y > 0))
            Console.WriteLine("Bod je v 2. kvadrantu.");
        if ((x < 0) && (y < 0))
            Console.WriteLine("Bod je v 3. kvadrantu.");
        if ((x > 0) && (y < 0))
            Console.WriteLine("Bod je v 4. kvadrantu.");
        if ((x == 0) || (y == 0))
            Console.WriteLine("Bod je na ose.");

        */
        if ((x > 0) && (y > 0))
            Console.WriteLine("Bod je v 1. kvadrantu.");
        else if ((x < 0) && (y > 0))
            Console.WriteLine("Bod je v 2. kvadrantu.");
        else if ((x < 0) && (y < 0))
            Console.WriteLine("Bod je v 3. kvadrantu.");
        else if ((x > 0) && (y < 0))
            Console.WriteLine("Bod je v 4. kvadrantu.");
        else
            Console.WriteLine("Lezi na ose.");



    }
}