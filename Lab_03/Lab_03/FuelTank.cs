using Lab_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class FuelTank: ITransportable, IVisitPort
    {
        public double MaxCapacity { get; private set; }
        private Fuel fuel;

        public FuelTank(double maxCapacity, Fuel fuel)
        {
            this.MaxCapacity = maxCapacity;
            this.fuel = fuel;
        }
        public double Volume
        {
            get { return fuel.Volume; }
            set { fuel.Volume = value; }
        }
        public double Weight
        {
            get { return fuel.Weight; }
            set 
            { 
                fuel.Weight = value;
                if (fuel.Volume > MaxCapacity) fuel.Volume = MaxCapacity;
            }
        }
        public double GetMaxCapacity()
        {
            return MaxCapacity;
        }
        public string GetFuelType()
        {
            return fuel.Type;
        }

        public double VisitPort()
        {
            double currentVolume = fuel.Volume;
            double missing = MaxCapacity - currentVolume;
            double costsPerUnit = 2000000.0;
            double cost = missing * costsPerUnit;
            fuel.Volume = MaxCapacity;
            return cost;
        }
    }
}
