namespace ZadanieDomowe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Resident> myCrossbowman = new List<Resident>();
            myCrossbowman.Add(new Crossbowman());
            myCrossbowman.Add(new Crossbowman());
            myCrossbowman.Add(new Crossbowman());

            List<Resident> myDefenders = new List<Resident>();
            myDefenders.Add(new Pikeman());
            myDefenders.Add(new Pikeman());
            myDefenders.Add(new Pikeman());
            myDefenders.AddRange(myCrossbowman);
            foreach (Defender D in myDefenders) Console.WriteLine(D.ReadyToFight());
            Console.WriteLine();

            List<Resident> myCivilians = new List<Resident>();
            myCivilians.Add(new Civilian());
            myCivilians.Add(new Civilian());
            myCivilians.Add(new Civilian());

            List<Resident> myAllResidents = new List<Resident>();
            myAllResidents.AddRange(myDefenders);
            myAllResidents.AddRange(myCivilians);

            foreach (Resident R in myAllResidents) Console.WriteLine(R.ToString());


        }
    }
}
