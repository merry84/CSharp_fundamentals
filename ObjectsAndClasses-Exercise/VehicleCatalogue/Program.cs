namespace VehicleCatalogue
{
    internal class Program
    {
                               
        
            static void Main(string[] args)
            {
                /*
                       Until you receive the "End" command, you will be receiving lines of input in the following format:
                    "{typeOfVehicle} {model} {color} {horsepower}"
                    When you receive the "End" command, you will start receiving information about some vehicles.
                    For every vehicle, print out the information about it in the following format:
                    "Type: {C}
                    Model: {modelOfVehicle}
                    Color: {colorOfVehicle}
                    Horsepower: {horsepowerOfVehicle}"
                    When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the
                    average horsepower of the trucks in the format:
                    "{typeOfVehicles} have average horsepower of {averageHorsepower}."
                    The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by
                    the total count of all vehicles from that type. Format the answer to the second digit after the decimal point.

                    Constraints
                    • The type of vehicle will always be either a car or a truck.
                    • You will not receive the same model twice.
                    • The received horsepower will be an integer in the range [1…1000].
                    • You will receive at most 50 vehicles.
                    • The separator will always be single whitespace.
                */

                List<Vehilche> catalog = new List<Vehilche>();
                string input = "";
                while ((input = Console.ReadLine()) != "End")
                {
                    string[] command = input.Split();
                    string typeOfVehicle = command[0];
                    string modelOfVehicle = command[1];
                    string colorOfVehicle = command[2];
                    string horsePower = command[3];
                    catalog.Add((new Vehilche(typeOfVehicle, modelOfVehicle, colorOfVehicle, horsePower)));

                }
                while ((input = Console.ReadLine()) != "Close the Catalogue")
                {
                    string modelOfVehicle = input;

                    Vehilche found = catalog.FirstOrDefault(v => v.Model == modelOfVehicle);
                    if (found != null)
                    {
                        Console.WriteLine(found);
                    }
                }
                double averageHorsePower = catalog.Where(vehilche => vehilche.Type == Types.Car)
                    .Select(vehilche => vehilche.HorsePower)
                    .DefaultIfEmpty()
                    .Average();
                Console.WriteLine($"Cars have average horsepower of: {averageHorsePower:f2}.");
                averageHorsePower = catalog.Where(vehilche => vehilche.Type == Types.Truck)
                    .Select(vehilche => vehilche.HorsePower)
                    .DefaultIfEmpty()
                    .Average();
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsePower:f2}.");
            }
            class Vehilche
            {
                public Vehilche(string type, string model, string color, string horsePower)
                {
                    Type = type == "car" ? Types.Car : Types.Truck;
                    Model = model;
                    Color = color;
                    HorsePower = double.Parse(horsePower);
                }

                public Types Type { get; set; }
                public string Model { get; set; }
                public string Color { get; set; }

                public double HorsePower { get; set; }

                public override string ToString()
                {
                    return $"Type: {Type}\n " +
                           $"Model: {Model}\n" +
                           $"Color: {Color}\n" +
                           $"Horsepower: {HorsePower}";

                }
            }
            enum Types
            {
                Car,
                Truck
            }

        }

    }

    
