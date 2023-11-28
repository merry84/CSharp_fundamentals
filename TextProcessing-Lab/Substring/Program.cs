using System.Collections.Generic;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*On the first line, you will receive a string.On the second line, you will receive a second string.
             * Create a program that removes all of the occurrences of the first string in the second,
             * until there is no match. 
             * At the end print the remaining string.
             */
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();
            while (secondText.Contains(firstText))
            {
                secondText = secondText.Remove(secondText.IndexOf(firstText),firstText.Length);
            }
            Console.WriteLine(secondText);

        }
    }
}