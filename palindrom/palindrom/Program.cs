namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej slovo:");
            string slovo = Console.ReadLine();
            string otocene="";
            for (int i = slovo.Length-1; i >= 0; i--) { 
            otocene = otocene + slovo[i];
            }
            Console.WriteLine("Původni slovo: " + slovo + "   Otočené slovo: " + otocene);
            if (slovo == otocene)
            {
                Console.WriteLine("Slovo je palindrom.");
            }
            else
                Console.WriteLine("Slovo neni palindrom.");
        }
    }
}
