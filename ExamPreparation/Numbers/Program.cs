namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read a sequence of integers
            //and find and print the top 5 numbers greater than the average value in the sequence,
            //sorted in descending order.
            //    Input
            //    •	Read from the console a single line holding space - separated integers.
            //    Output
            //    •	Print the above - described numbers on a single line, space - separated.
            //    •	If less than 5 numbers hold the property mentioned above, print less than 5 numbers.
            //    •	Print "No" if no numbers hold the above property.
            //    Constraints
            //    •	All input numbers are integers in the range[-1 000 000 … 1 000 000]. 
            //    •	The count of numbers is in the range[1…10 000].

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double average = numbers.Average();
            int topCount = 0;

            List<int> topNumbers = new List<int>(5);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    topNumbers.Add(numbers[i]);
                    topCount++;
                }
            }

            if (topCount == 0)
            {
                Console.WriteLine("No");
                return;

            }
            topNumbers.Sort();
            topNumbers.Reverse();

            if (topNumbers.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{topNumbers[i]} ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(' ', topNumbers));

            }

        }
    }
}