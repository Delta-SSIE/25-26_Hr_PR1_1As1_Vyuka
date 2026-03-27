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
        }
    }
}
