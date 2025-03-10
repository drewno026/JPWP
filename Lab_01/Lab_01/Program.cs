namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flamingo flamingo = new Flamingo("Flamingo", 8, 10000);
            flamingo.Info();
            flamingo.Incubation(2, 7);
            flamingo.InfoFeathers();

        }
    }
}
