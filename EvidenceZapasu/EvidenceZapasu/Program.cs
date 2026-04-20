namespace EvidenceZapasu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hrac h1 = new Hrac();
           Hrac h2 = new Hrac(1, "Karel", "Opicka", "XL");
            h1.PredstavSe();
            h2.PredstavSe();
           Tym dreamTym = new Tym("DreamTym");
            dreamTym.SetHrac(h2);
            Console.WriteLine("Zadej cislo hrace:");
            int cislo;
            int.TryParse(Console.ReadLine(), out cislo);
            Hrac nalezen = dreamTym.NajdiHrace(cislo);
            if (nalezen != null)
            {
                nalezen.PredstavSe();
            }
            else
                Console.WriteLine("Hrac nenalezen");
        }
    }
}
