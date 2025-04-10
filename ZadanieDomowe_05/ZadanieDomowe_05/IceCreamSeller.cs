using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_05
{
    class IceCreamSeller
    {
        private IceCreamFactory factory;

        public IceCreamSeller(IceCreamFactory factory)
        {
            this.factory = factory;
        }

        public void OfferDailySpecial()
        {
            IceCream iceCream = factory.DailySpecial();
            Console.WriteLine("Today's special:");
            iceCream.DisplayInfo();
            Console.WriteLine(); 
        }
    }
}
