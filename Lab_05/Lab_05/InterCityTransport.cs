using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class InterCityTransport:TransportFactory
    {
        public override Vehicle CreateVehicle()
        {
            switch (travelMode)
            {
                case "quickest":
                    return new Train();
                case "cheapest":
                    return new Bus();
                case "convenient":
                    return new Car();
                default:
                    Console.WriteLine("Unknown travel mode. Defaulting to Train.");
                    return new Train();
            }
        }
        public override Ticket? CreateTicket()
        {
            switch (CreateVehicle())
            {
                case Train:
                    return new TrainTicket();
                case Bus:
                    return new BusTicket();
                default:
                    return null;
            }
        }
    }
}
