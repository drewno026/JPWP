using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class BusFactory:VehicleFactory
    {
        public override Vehicle Create()
        {
            Bus bus = new Bus("electric", 90);
            return bus;
        }
    }
}
