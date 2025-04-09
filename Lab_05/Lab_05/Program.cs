namespace Lab_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C2
            // Train electricTrain = new Train("electric", 120);
            // Console.WriteLine(electricTrain);
            List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("electric", 120));
            myVehicles.Add(new Bus("electric", 90));
            myVehicles.Add(new Car("hybrid", 150));
            foreach (Vehicle v in myVehicles) Console.WriteLine(v);

            // C5 zadanie 1
            Console.WriteLine();
            List<VehicleFactory> factories = new List<VehicleFactory>() { new TrainFactory(),
                new BusFactory(), new CarFactory() };
            foreach (VehicleFactory factory in factories)
            {
                Vehicle v = factory.Create();
                Console.WriteLine(v);
            }
            Console.WriteLine();

            CarRentalService car = new CarRentalService(new CarFactory());
            car.Rent();
            Console.WriteLine();

            InterCityTransport interCity = new InterCityTransport();
            // Test: cheapest
            interCity.TravelMode = "cheapest";
            Vehicle vehicle1 = interCity.CreateVehicle();
            Ticket? ticket1 = interCity.CreateTicket();
            Console.WriteLine($"[InterCity - cheapest] Ticket: {ticket1?.Type ?? "brak"}");

            // Test: quickest
            interCity.TravelMode = "quickest";
            Vehicle vehicle2 = interCity.CreateVehicle();
            Ticket? ticket2 = interCity.CreateTicket();
            Console.WriteLine($"[InterCity - quickest] Ticket: {ticket2?.Type ?? "brak"}");

            // Test: convenient
            interCity.TravelMode = "convenient";
            Vehicle vehicle3 = interCity.CreateVehicle();
            Ticket? ticket3 = interCity.CreateTicket();
            Console.WriteLine($"[InterCity - convenient] Ticket: {ticket3?.Type ?? "brak"}");

            Console.WriteLine();

            CityTransport cityTransport = new CityTransport();

            //Test: cheapest
            cityTransport.TravelMode = "cheapest";
            Vehicle vehicle4 = cityTransport.CreateVehicle();
            Ticket? ticket4 = cityTransport.CreateTicket();
            Console.WriteLine($"[InsideCity - cheapest] Ticket: {ticket4?.Type ?? "brak"}");

            // Test: quickest
            cityTransport.TravelMode = "quickest";
            Vehicle vehicle5 = cityTransport.CreateVehicle();
            Ticket? ticket5 = cityTransport.CreateTicket();
            Console.WriteLine($"[InsideCity - quickest] Ticket: {ticket5?.Type ?? "brak"}");

            // Test: convenient
            cityTransport.TravelMode = "convenient";
            Vehicle vehicle6 = cityTransport.CreateVehicle();
            Ticket? ticket6 = cityTransport.CreateTicket();
            Console.WriteLine($"[InsideCity - convenient] Ticket: {ticket6?.Type ?? "brak"}");
            Console.WriteLine();
        }
    }
}
