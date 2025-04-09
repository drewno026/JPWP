using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class CarFactory:VehicleFactory
    {
        public override Vehicle Create()
        {
            Car car = new Car("electric", 150);
            return car;
        }
    }
}
