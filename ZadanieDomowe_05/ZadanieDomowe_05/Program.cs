namespace ZadanieDomowe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IceCreamFactory factory = new IceCreamFactory();
            IceCreamSeller seller = new IceCreamSeller(factory);

            foreach (IceCreamFactory.ProductionMode day in Enum.GetValues(typeof(IceCreamFactory.ProductionMode)))
            {
                Console.WriteLine($"=== {day} ===");
                factory.SetProductionMode(day);

                for (int i = 0; i < 3; i++)
                {
                    seller.OfferDailySpecial();
                }

                Console.WriteLine();

            }
        }
    }
}
