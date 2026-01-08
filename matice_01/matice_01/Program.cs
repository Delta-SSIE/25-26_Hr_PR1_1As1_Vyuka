namespace matice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matice;
            Console.WriteLine("Zadej pocet radku:");
            int radky = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej pocet sloupcu:");
            int sloupce = int.Parse(Console.ReadLine());
            matice = new int[radky, sloupce];
            int cislo = 0;
            for(int i = 0; i < radky; i++)
            {
                for(int j = 0; j < sloupce; j++)
                {
                    matice[i, j] = cislo;
                    cislo++;
                }
            }

            for(int i = 0;i < radky; i++)
            {
                for (int j = 0;j < sloupce; j++)
                {
                    Console.Write(matice[i, j] + " "); //vypis radku
                }
                Console.WriteLine();
            }

            Console.WriteLine("Zadej radek v vypsani (zacatek v 0): ");
            int r;
            while(int.TryParse(Console.ReadLine(),out r) == false || r<0 || r>radky)
            {
                Console.WriteLine("Chybne zadana hodnota, opakuj volbu:");
            }
            for(int i = 0;i<sloupce; i++)
            {
                Console.Write(matice[r, i] + " ");
            }

            for (int i = 0; i < radky; i++)
            {
                Console.WriteLine(matice[i,i]);

            }

        }
    }
}
