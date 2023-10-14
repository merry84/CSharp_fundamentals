using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Create a program to sum all of the adjacent equal numbers in a list of decimal numbers,
            //  starting from left to right.
            //•	After two numbers are summed, the result could be equal to some of its neighbors
            //  and should be summed as well (see the examples below)
            //•	Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available)

            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0;i < numbers.Count -1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt (i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}