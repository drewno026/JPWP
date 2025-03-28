using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;
        public LifeSupportSystem(List<OxygenBottle> oxygenBottles, FoodContainer foodContainer, Waste waste, List<Human> crew)
        {
            this.oxygenBottles = oxygenBottles;
            this.foodContainer = foodContainer;
            this.waste = waste;
            this.crew = crew;
        }
        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            double oxygenConsumptionPerPerson = 1.0;
            double foodConsumptionPerPerson = 0.5;
            int numberOfPeople = crew.Count;

            double requiredOxygen = oxygenConsumptionPerPerson * travelTime * numberOfPeople;
            double requiredFood = foodConsumptionPerPerson * travelTime * numberOfPeople;

            double allOxygen = 0;

            foreach (OxygenBottle bottle in oxygenBottles)
                allOxygen += bottle.Volume;

            double allFood = foodContainer.Volume;
            if (foodContainer.Volume>= requiredFood && allOxygen >= requiredOxygen)
                return true;
            else
                return false;
        }

        public void Run(double travelTime)
        {
            if (CheckSuppliesBeforeTravel(travelTime))
            {
                double oxygenConsumptionPerPerson = 1.0;
                double foodConsumptionPerPerson = 0.5;
                double wasteIncrese = 1;

                int numberOfPeople = crew.Count;

                double usedOxygen = oxygenConsumptionPerPerson * numberOfPeople * travelTime;
                double usedFood = foodConsumptionPerPerson * numberOfPeople * travelTime;
                double wasteGenarated = wasteIncrese * numberOfPeople * travelTime;


                double usagePerBottle = usedOxygen / oxygenBottles.Count;
                foreach (OxygenBottle bottle in oxygenBottles)
                {
                    if (bottle.Volume >= usagePerBottle)
                        bottle.Volume -= usagePerBottle;
                    else
                        bottle.Volume = 0;
                }
                foodContainer.Volume -= usedFood;
                waste.Weight += wasteGenarated;

                Console.WriteLine("The submarine has reached its destination.");
            }
            else
                Console.WriteLine("The submarine hasnt reached its destination.");
        }
    }
}
