using System.Diagnostics.CodeAnalysis;
using System.Linq;
//Next, we are going to implement more complicated list commands,
//extending the previous task. Again, read a list and keep reading commands until you receive "end":
//    •	Contains { number} – check if the list contains the number and if so - print "Yes",
// otherwise print "No such number".
//    •	PrintEven – print all the even numbers, separated by a space.
//    •	PrintOdd – print all the odd numbers, separated by a space.
//    •	GetSum – print the sum of all the numbers.
//    •	Filter { condition}{ number} – print all the numbers that fulfill the given condition.
//The condition will be either '<', '>', ">=", "<=".
//    After the end command, print the list only if you have made some changes to the original list.
// Changes are made only from the commands from the previous task.

internal class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        string input = default;
        bool isChange = false;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputTokens = input.Split().ToArray();
            string command = inputTokens[0];
            if (inputTokens[0] == "Remove" || inputTokens[0] == "Add" || inputTokens[0] == "RemoveAt" ||
                inputTokens[0] == "Insert")
            {
                isChange = true;
            } 
            if (command == "Contains")
            {
                int number = int.Parse(inputTokens[1]);
                Contains(number, numbers);

            }
            else if (command == "PrintEven")
            {
                PrintEven(numbers);
                
            }
            else if (command == "Add")
            {
                int number = int.Parse(inputTokens[1]);
                numbers.Add(number);
            }
            else if (command == "RemoveAt")
            {
                int index = int.Parse(inputTokens[1]);
                numbers.RemoveAt(index);
            }
            else if (command == "Insert")
            {
                int number = int.Parse(inputTokens[1]);

                int index = int.Parse(inputTokens[2]);
                numbers.Insert(index, number);
            }
            else if (command == "PrintOdd")
            {
                PrintOdd(numbers);
                Console.WriteLine();

            }
            else if (command == "GetSum")
            {
                GetSum(numbers);

            }
            else if (command == "Filter")
            {
                string condition = inputTokens[1];
                int numberToCond = int.Parse(inputTokens[2]);
                Filter(numbers, condition, numberToCond);
                Console.WriteLine();

            }

        }
        if (isChange)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }

    static void Contains(int number, List<int> numbers)
    {
        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }

    }

    static void PrintEven(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        Console.WriteLine();
    }

    static void PrintOdd(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }

    static void GetSum(List<int> numbers)
    {
        numbers.Sum();
        Console.WriteLine(numbers.Sum());
    }

    static void Filter(List<int> numbers, string condition, int numberToCond)
    {
        foreach (int number in numbers)
        {
            if ((condition == "<" && number < numberToCond) ||
                (condition == ">" && number > numberToCond) ||
                (condition == ">=" && number >= numberToCond) ||
                (condition == "<=" && number <= numberToCond))
            {
                Console.Write(number + " ");
            }

        }
    }
}

