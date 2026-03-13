namespace Studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student karel = new Student();
            Student ondra = new Student();

            // karel.jmeno = "Karel";
            karel.setJmeno("Karel");
            ondra.setJmeno("Ondra");
            //Console.WriteLine("Prvni student: " + karel.getJmeno());
            //Console.WriteLine("Druhy student: " + ondra.getJmeno());
            karel.PredstavSe();
            ondra.PredstavSe();

            Student kvido = new Student("Kvido", "Kouzelnik", 5);
            kvido.PredstavSe();
            kvido.setVek(10);
            kvido.PredstavSe();
            kvido.ZapisZnamku(1);
            kvido.ZapisZnamku(3);
            kvido.ZapisZnamku(2);
            kvido.VypisZnamky();
        }
    }
}
