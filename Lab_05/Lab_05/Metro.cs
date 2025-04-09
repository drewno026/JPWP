using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class Metro:Vehicle
    {
        public Metro():base()
        {
            Name = "Metro";
            Engine = "Electric";
            VelocityLimit = 0;
        }
        public override string GetVehicleType()
        {
            return "Metro";
        }
    }
}
