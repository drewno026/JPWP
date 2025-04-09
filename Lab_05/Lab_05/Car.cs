using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Car : Vehicle
    {
        Random rnd = new Random();
        public int carYear;
        public string carMake;
        public Car(string _engine, int _velocityLimit) : base("car", _engine, _velocityLimit)
        {
            carYear = rnd.Next(1990, 2025);
            if (carYear < 2000)
                carMake = "Mustang";
            else
                carMake = "Audi";
        }
        public Car():base()
        {
            Name = "Car";
            Engine = "Diesel";
            carYear = rnd.Next(1990, 2025);
            if (carYear < 2000)
                carMake = "Mustang";
            else
                carMake = "Audi";
        }

        public override string GetVehicleType()
        {
            return $"Car";
        }
        public override string ToString()
        {
            return $"Vehicle type: {GetVehicleType()}, Car make: {carMake}, Made in: {carYear}, Engine: {Engine}, Velocity limit: {VelocityLimit} km/h";
        }
    }
}
