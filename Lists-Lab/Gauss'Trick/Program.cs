using System.Collections.Generic;

namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that sums all numbers in a list in the following order:
            //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

            List<int> listNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
           List<int>result = new List<int>();
            for (int i = 0; i < listNumbers.Count/2; i++)
            {
                int firstElement = listNumbers[i];
                int lastElement = listNumbers[listNumbers.Count -i -1];
                result.Add(firstElement + lastElement);
            }
            if(listNumbers.Count % 2 == 1)
            {
                int midIndex = listNumbers.Count / 2;
               result.Add(listNumbers[midIndex]); 
            }
            Console.WriteLine(string.Join(" ",result));

        }
    }
}