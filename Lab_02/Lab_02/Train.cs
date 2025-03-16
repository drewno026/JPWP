using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class Train : Vehicle
    {
        public Train() : base(){}
        public Train(string _engine, int _velocityLimit) :base("train", _engine, _velocityLimit){}

        public override string GetVehicleType()
        {
            return "train";
        }
        //public override string ToString()
        //{
        //    return $"Vehicle type: {GetVehicleType()}, Engine: {Engine}, Velocity limit: {VelocityLimit} km/h";
        //}
    }
}
