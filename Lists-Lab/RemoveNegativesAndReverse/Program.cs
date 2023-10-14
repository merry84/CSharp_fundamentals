using System.Xml.Linq;

namespace RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main()
        {
            //Read a list of integers, remove all negative numbers
            //from it and print the remaining elements in reversed order.
            //If there are no elements left in the list, print "empty".

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }

            }
            numbers.Reverse();

            if (numbers.Count != 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}