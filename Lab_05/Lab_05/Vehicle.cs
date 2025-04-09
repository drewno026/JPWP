using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    abstract class Vehicle
    {
        public string Name {  get; set; }
        public string Engine { get; set; }
        public int VelocityLimit { get; set; }
        public Vehicle()
        {
            Name = "unspecified vehicle";
            Engine = "unknown";
            VelocityLimit = 0;
        }
        public Vehicle(string _name, string _engine, int _velocityLimit)
        {
            Name = _name;
            Engine = _engine;
            VelocityLimit = _velocityLimit;
        }
        public abstract string GetVehicleType();
        //{
        //    return Name;
        //}
        public override string ToString()
        {
            return $"Vehicle type: {GetVehicleType()}, Engine: {Engine}, Velocity limit: {VelocityLimit} km/h";
        }
    }
}
