using System.Data;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a list of integers.Then until you receive "end",
            //you will receive different commands:
            //    •	Add { number}: add a number to the end of the list.
            //    •	Remove { number}: remove a number from the list.
            //    •	RemoveAt { index}: remove a number at a given index.
            //    •	Insert { number}
            //{ index}: insert a number at a given index.
            //    Note: All the indices will be valid!
            //    When you receive the "end" command, print the final state of the list(separated by spaces).

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = default;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputTokens = input.Split().ToArray();
                string command = inputTokens[0];

                if (command == "Add")
                {
                    int number = int.Parse(inputTokens[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(inputTokens[1]);
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(inputTokens[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputTokens[1]);
                   
                    int index = int.Parse(inputTokens[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}