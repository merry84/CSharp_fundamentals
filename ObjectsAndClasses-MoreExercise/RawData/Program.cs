namespace RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                 /*
                  You are the owner of a courier company and you want to make a system for tracking your cars and their cargo. 
                Define a class Car that holds a piece of information about the model, engine and cargo. 
                The Engine and Cargo should be separate classes.
                Create a constructor that receives all of the information 
                about the Car and creates and initializes its inner components (engine and cargo).
                On the first line, of input you will receive a number N – the number of cars you have.
                On each of the next N lines, you will receive the following information about a car:
                "<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>", where the speed, power and weight are all integers. 
                After the N lines, you will receive a single line with one of 2 commands:
                "fragile" or "flamable". 
                If the command is "fragile", print all cars, whose Cargo Type is "fragile" with cargo with weight  < 1000.
                If the command is "flamable", print all of the cars whose Cargo Type is "flamable" and have Engine Power > 250. 
                The cars should be printed in order of appearing in the input.

               */
                int n = int.Parse(Console.ReadLine());
                List<Car> cars = new List<Car>();
                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    string model = input[0];
                    int speed = int.Parse(input[1]);
                    int power = int.Parse(input[2]);
                    int weight = int.Parse(input[3]);
                    string type = input[4];
                    cars.Add(new Car(model, new Cargo(weight, type), new Engine(speed, power)));
                }
                string command = Console.ReadLine();
                if (command == "fragile")
                {

                    //If the command is "fragile", print all cars, whose Cargo Type is "fragile" with cargo with weight  < 1000.
                    foreach (Car car in cars.Where(t => t.Cargo.Type == "fragile" && t.Cargo.Weight < 1000))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                //If the command is "flamable", print all of the cars whose Cargo Type is "flamable" and have Engine Power > 250.
                else
                {
                    foreach (Car car in cars.Where(t => t.Cargo.Type == "flamable" && t.Engine.Power > 250))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
           
        }
       
    }
    class Car
    {
        public Car(string model, Cargo cargo, Engine engine)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;

        }
        public string Model { get; set; }
        public Cargo Cargo { get; set; }

        public Engine Engine { get; set; }
    }
    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }
}

