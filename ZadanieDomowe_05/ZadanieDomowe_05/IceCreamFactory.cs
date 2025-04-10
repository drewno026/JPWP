using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_05
{
    class IceCreamFactory
    {
        public ProductionMode currentMode;
        public enum ProductionMode
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public void SetProductionMode(ProductionMode mode)
        {
            currentMode = mode;
        }
        public IceCream DailySpecial()
        {
            switch (currentMode)
            {
                case ProductionMode.Monday:
                    return new CreamyIceCream();
                case ProductionMode.Tuesday:
                    return new FruitIceCream();
                case ProductionMode.Wednesday:
                    return new SoftServeIceCream();
                case ProductionMode.Thursday:
                    return new Sorbet();
                case ProductionMode.Friday:
                    return new FruitIceCream("Strawberry", 2, "Sprinkles");
                case ProductionMode.Saturday:
                    return new CreamyIceCream(4, "Strawberry");
                case ProductionMode.Sunday:
                    return new SoftServeIceCream(3);
                default:
                    Console.WriteLine("Unknown production mode. Swtiching to fruit ice cream");
                    return new FruitIceCream("Apple", 3, "Sprinkles");
            }
        }

    }
}
