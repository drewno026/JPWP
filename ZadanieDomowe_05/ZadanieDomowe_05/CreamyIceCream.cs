using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_05
{
    class CreamyIceCream:IceCream
    {
        public bool Waffle { get; set; }
        public bool ChocolateTopping { get; set; }
        public string Topping { get; set; }
        public CreamyIceCream() : base("Cream", 3)
        {
            Waffle = true;
            Topping = "Strawberry";
            ChocolateTopping = true;
        }
        public CreamyIceCream(int _price, string _topping) : base("Cream", _price)
        {
            Price = _price;
            Topping = _topping;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Main flavour {MainFlavour}, Price {Price}, Topping: {Topping}," +
                $" Chocolate topping {(ChocolateTopping ? "Yes":"No")}, Waffle: {(Waffle ? "Yes" : "No")} ");
        }
    }
}
