namespace Matice_Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matice;
            Console.WriteLine("Zadej pocet radku:");
            int radky;
            while (int.TryParse(Console.ReadLine(), out radky) == false || radky <= 0)
            {
                Console.WriteLine("Opakuj volbu");
            }
            Console.WriteLine("Zadej pocet sloupcu:");
            int sloupce;
            while (int.TryParse(Console.ReadLine(), out sloupce) == false || sloupce <= 0)
            {
                Console.WriteLine("Opakuj volbu");
            }
            //ocekavame spravne nactene rozmery
            matice = new int[radky, sloupce];
            matice = NaplnMatici(radky,sloupce); //vyplnena matice se doplni do matice prazdne
            VypisMatici(matice);
        }

        static int[,] NaplnMatici(int pocetr, int pocets)
        {
            int[,] naplnenaMatice = new int[pocetr, pocets];
            Random generator = new Random();
            for (int i = 0; i < pocetr; i++)
            {
                for (int j = 0; j < pocets; j++)
                {
                    naplnenaMatice[i, j] = generator.Next(1, 10);
                }
            }
            return naplnenaMatice;
        }

        static void VypisMatici(int[,] matice)
        {
            for(int i = 0; i < matice.GetLength(0); i++) //radky
            {
                for(int j = 0;j < matice.GetLength(1); j++) //sloupce
                {
                    Console.Write(matice[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
