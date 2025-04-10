using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_05
{
    class FruitIceCream:IceCream
    {
        public bool Waffle { get; set; }
        public string Topping { get; set; }
        public FruitIceCream() : base("Fruit", 4) 
        {
            Waffle = true;
            Topping = "Strawberry";
        }
        public FruitIceCream(string _mainFlavour, int _price, string _topping) : base(_mainFlavour, _price)
        {
            MainFlavour = _mainFlavour;
            Price = _price;
            Waffle = true;
            Topping = _topping;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Main flavour {MainFlavour}, Price {Price}, Topping: {Topping}, Waffle: {(Waffle ? "Yes":"No")} ");
        }
    }
}
