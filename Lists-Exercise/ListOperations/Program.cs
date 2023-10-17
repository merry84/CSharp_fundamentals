using System.Globalization;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The first input line will hold a list of integers.
            //Until we receive the "End" command, we will be given operations we
            //have to apply to the list.
            // The possible commands are:
            //    • Add { number} – add the given number to the end of the list
            //    • Insert { number}{ index} – insert the number at the given index
            //    • Remove { index} – remove the number at the given index
            //    • Shift left { count} – first number becomes last.
            // This has to be repeated the specified number of times
            //    • Shift right { count} – last number becomes first.
            // To be repeated the specified number of times
          
            //Note: the index given may be outside of the bounds of the array. In that case print:
            //"Invalid index".

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = default;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] argument = input.Split().ToArray();
                string command = argument[0];
                if (command == "Add")
                {
                    int number = int.Parse(argument[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(argument[1]);
                    int index = int.Parse(argument[2]);
                    if (isNotValidIndex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else { numbers.Insert(index, number);; }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(argument[1]);
                    if (isNotValidIndex(index, numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else { numbers.RemoveAt(index); }
                    
                }
                else if (command == "Shift")
                {
                    int count = int.Parse(argument[2]);
                    string dicection = argument[1];
                    count %= numbers.Count;
                    if (dicection == "left")
                    {
                        List<int> shiftPart = numbers.GetRange(0, count);
                        numbers.RemoveRange(0, count);
                        numbers.InsertRange(numbers.Count, shiftPart);
                    }
                    else if (dicection == "right")
                    {
                        List<int> shiftPart = numbers.GetRange(numbers.Count - count, count);
                        numbers.RemoveRange(numbers.Count - count, count);
                        numbers.InsertRange(0, shiftPart);
                    }

                }
            }

            Console.WriteLine(string.Join(' ', numbers));

           
        }
        private static bool isNotValidIndex(int index, int numbersCount)
        {
            return index < 0 || index >= numbersCount;
               
               
        }
}
}