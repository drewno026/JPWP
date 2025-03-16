namespace ZadanieDomowe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZhaoDynasty zhaoCustom = new ZhaoDynasty("Zhao Dynasty", 403, 222, "King Youmiu");
            zhaoCustom.DynastyInfo();

            Console.WriteLine();

            GreatWall QinWall = new GreatWall();
            QinWall.DynastyInfo();

        }
    }
}
