namespace cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  for (int i = 1; i < 40; i=i+2)
              {
                  Console.WriteLine(i);
              }*/
          /*  int a = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(a);
                a = a + 2;
            }
          */
           
            /*Random generator = new Random();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(generator.Next(0, 11));
            }*/

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine("Druha mocnina cisla " + i + " je " + i*i);
            }
        }
    }
}
