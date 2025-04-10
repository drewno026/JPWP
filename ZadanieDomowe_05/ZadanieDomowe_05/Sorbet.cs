using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_05
{
    class Sorbet:IceCream
    {
        public Sorbet() : base("Sorbet", 4){}
        public override void DisplayInfo()
        {
            Console.WriteLine($"Main flavour {MainFlavour}, Price {Price},");
        }
    }
}
