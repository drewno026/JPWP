namespace Lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Vehicle vehicle = new Vehicle();
            Train train = new Train();
            Vehicle trainAsVehicle = new Train();

            //Console.WriteLine(vehicle.GetVehicleType());
            Console.WriteLine(train.GetVehicleType());
            Console.WriteLine(trainAsVehicle.GetVehicleType());

            Console.WriteLine();

            Train electricTrain = new Train("electric", 120);
            Console.WriteLine(electricTrain);

            Console.WriteLine();

            List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("electric", 120));
            myVehicles.Add(new Bus("electric", 90));
            myVehicles.Add(new Car("hybrid", 150));
            foreach (Vehicle v in myVehicles) Console.WriteLine(v);
        }
    }
}
