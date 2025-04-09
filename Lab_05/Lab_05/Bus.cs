using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Bus : Vehicle
    {
        public Bus():base(){}
        public Bus(string _engine, int _velocityLimit) : base("bus", _engine, _velocityLimit){}

        public override string GetVehicleType()
        {
            return "Bus";
        }
    }
}
