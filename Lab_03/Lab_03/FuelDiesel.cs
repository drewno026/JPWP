using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class FuelDiesel:Fuel
    {
        public FuelDiesel():base()
        {
            density = 10;
        }
        public override string GetType()
        {
            return "Diesel";
        }
        public override string Type
        {
            get { return GetType(); }
        }
    }
}
