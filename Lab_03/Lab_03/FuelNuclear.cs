using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class FuelNuclear:Fuel
    {
        public FuelNuclear()
        {
            density = 10;
        }
        public override string GetType()
        {
            return "Nuclear";
        }
        public override string Type
        {
            get { return GetType(); }
        }
    }
}
