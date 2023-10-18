using System.Diagnostics.Metrics;

namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will be given a list of numbers and a string.
            //For each element of the list you must calculate the sum of its digits and take the element,
            //corresponding to that index from the text.If the index is greater than the length of the text,
            //start counting from the beginning (so that you always have a valid index
            //After you get that element from the text,
            //you must remove the character you have taken
            //from it(so for the next index the text will be with one characterless)

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<char> text = Console.ReadLine()
                .ToList();
            List<char> letter = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int num = IndexFromText(numbers[i], text.Count);
                letter.Add(text[num]);
                text.RemoveAt(num);
            }
            Console.WriteLine(string.Join("", letter));

            static int SumOfDigits(int number)
            {
                int result = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    result += lastDigit;
                    number /= 10;
                }
                return result;
            }
            static int IndexFromText(int number, int count)
            {
                int index = SumOfDigits(number);
                if (index > count)
                {
                    if (index % count == 0)
                    {
                        index = count - 1;
                    }
                    else
                    {
                        index %= count;
                    }
                }
                return index;
            }
        }
    }
}