using System.Reflection;

namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
            //Define a class Truck with the following properties: Brand, Model, and Weight.
            //Define a class Car with the following properties: Brand, Model, and Horse Power.
            //Define a class Catalog with the following properties: Collections of Trucks and Cars.

            //You must read the input, until you receive the "end" command.It will be in following format:
            //"{type}/{brand}/{model}/{horse power / weight}"
            //In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
            //"Cars:
            //{Brand}: {Model}- { Horse Power}hp
            //Trucks:
            //{ Brand}: { Model}- { Weight}kg"
            string input = Console.ReadLine();
            List<Cars> cars = new List<Cars>();
            List<Truck> trucks = new List<Truck>();

            while (input != "end")
            {
                string[] command = input.Split("/");
                string type = command[0];
                string brand = command[1];
                string model = command[2];
                int powerOrWeight = int.Parse(command[3]);
                if(type == "Car")
                {
                    Cars car = new Cars();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsPower = powerOrWeight;
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = powerOrWeight;
                    trucks.Add(truck);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Cars:");
            foreach (Cars car in cars.OrderBy(x=> x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsPower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (Truck truck in trucks.OrderBy(x=> x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

    }
    class Cars
    {
        public string Brand { get; set; } 
        public string Model { get; set;}
        public int HorsPower { get; set;} 

    }
    class Truck
    {
        public string Brand { get; set;}  
        public string Model  { get; set;}
        public int Weight { get; set;}
    
    }
    class Catalog
    {
        public List<Cars> Cars { get; set;}
        public List<Truck> Truck { get; set;}

    }
}