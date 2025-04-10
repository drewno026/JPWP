using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_05
{
    class SoftServeIceCream:IceCream
    {
        public bool Waffle { get; set; }
        public bool ChocolateTopping { get; set; }
        public SoftServeIceCream() : base("Soft serve ice cream", 6)
        {
            Waffle = true;
            ChocolateTopping = true;
        }
        public SoftServeIceCream(int _price):base("Soft serve ice cream", 6)
        {
            Waffle = true;
            ChocolateTopping = true;
            Price = _price;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Main flavour {MainFlavour}, Price {Price}," +
                $" Chocolate topping {(ChocolateTopping ? "Yes" : "No")}, Waffle: {(Waffle ? "Yes" : "No")} ");
        }
    }
}
