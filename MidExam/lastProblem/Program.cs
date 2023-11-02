namespace lastProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> coffes = Console.ReadLine()
                .Split()
                .ToList();
            int n = int.Parse(Console.ReadLine());
            string input = default;
                while ((input = Console.ReadLine()) != "end")
                {
                    string[] inputTokens = coffes.ToArray();
                    string command = inputTokens[0];
                    if (command == "Include")
                    {
                        string coffe = inputTokens[1];
                        coffes.Add(coffe);

                    }
                    else if (command == "Remove")
                    {
                        if (inputTokens[1] == "first")
                        {
                            int indexRemove = int.Parse(i];

                            coffes.RemoveAt(indexRemove);
                        }
                        else if (inputTokens[1] == "last")
                        {
                            int indexRemove = int.Parse(inputTokens[2]);


                        }

                    }
                    else if (command == "Prefer")
                    {

                    }
                    else if(command == "Reverse")
                    {

                    }
                }

            







        }
    }
}