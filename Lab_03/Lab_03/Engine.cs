using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;
        public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }
        public double GetVelocity(double submarineWeight)
        {
            double k = 10000000;
            return k / submarineWeight;
        }
        
        public bool CheckFuelBeforeTravel(double travelTime)
        {
            double consumption = 0;
            string fuelType = tank.GetFuelType();
            if (fuelType == "Diesel")
            {
                consumption =  0.1;
            }
            else if (fuelType == "Nuclear")
            {
                consumption = 0.01;
            }
            double fuelUsed = travelTime * consumption;
            if (tank.Volume < fuelUsed)
                return false;
            double newVolume = tank.Volume - fuelUsed;
            tank.Volume = newVolume;
            if (newVolume < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Travel(double travelTime)
        {
            if (CheckFuelBeforeTravel(travelTime))
            {
                waste.Weight = 2 * travelTime;
            }
            else
            {
                Console.WriteLine("Not enough fuel");
            }
        }
    }
}
