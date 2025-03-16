using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class Car : Vehicle
    {
        public Car() : base() { }
        public Car(string _engine, int _velocityLimit) : base("car", _engine, _velocityLimit){}

        public override string GetVehicleType()
        {
            return "Car";
        }
    }
}
