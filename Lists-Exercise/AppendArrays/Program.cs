namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to append several arrays of numbers one after another.
            //    • Arrays are separated by '|'
            //    • Their values are separated by spaces(' ', one or several)
            //    • Take all arrays starting from the rightmost and going to the left
            // and place them in a new array in that order

            string[] numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);
            List<string>elementList = ExtactElements(numbers);
            Console.WriteLine(string.Join(' ', elementList));

        }

        private static List<string> ExtactElements(string[] numbers)
        {
            List<string>result = new List<string>();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                string number = numbers[i];
                string[] array = number.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                result.AddRange(array);
            }
            
            return result;
        }
    }
}