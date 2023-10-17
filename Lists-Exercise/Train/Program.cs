namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line, we will receive a list of wagons(integers).
            //Each integer represents the number of passengers that
            //are currently in each wagon of the passenger train.
            //On the next line,you will receive the max capacity of a wagon,represented as a single integer.
            // Until you receive the "end" command,you will be receiving two types of input:

            //• Add { passengers} – add a wagon to the end of the train with the given number of passengers.
            //• { passengers} – find a single wagon to fit all the incoming passengers
            //(starting from the first wagon).

            //In the end, print the final state of the train(all the wagons separated by a space).
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = default;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] argument = input.Split().ToArray();
                string command = argument[0];
                if (command == "Add")
                {
                    int passenger = int.Parse(argument[1]);
                    wagons.Add(passenger);
                }
                else 
                {
                    int newPassenger = int.Parse(argument[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassenger <= capacity)
                        {
                            wagons[i] += newPassenger;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}