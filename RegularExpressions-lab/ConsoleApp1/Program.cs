using System.Text.RegularExpressions;

namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Program to match full names from a list of names and print them on the console.
            string redex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection matchName = Regex.Matches(names, redex);
            foreach (Match name in matchName)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
