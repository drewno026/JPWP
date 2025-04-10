using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_05
{
    abstract class IceCream
    {
        public string MainFlavour { get; set; }
        public int Price { get; set; }
        public IceCream(string _mainFlavour, int _price)
        {
            MainFlavour = _mainFlavour;
            Price = _price;
        }
        public abstract void DisplayInfo();
    }
}
