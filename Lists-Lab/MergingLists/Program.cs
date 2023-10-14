using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are going to receive two lists of numbers.
            //Create a list that contains the numbers from both of the lists.
            //The first element should be from the first list, the second from the second list, and so on.
            //If the length of the two lists is not equal, just add the remaining elements at the end of the list.
            

            //Hint
            //    •	Read the two lists.
            //    •	Create a result list.
            //    •	Start looping through them until you reach the end of the smallest one.
            //    •	Finally, add the remaining elements(if there are any) to the end of the list.

            List<int>firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int>secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int>result = new List<int>();

            int maxLen = Math.Max(firstNumbers.Count, secondNumbers.Count);// max list count

            for (int i = 0; i < maxLen; i++)
            {
                if (i < firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }

                if (i < secondNumbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));


        }
    }
}