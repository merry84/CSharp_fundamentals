namespace ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given an array with integers.
            //Write a program to modify the elements after receiving the following commands:
            //  •"swap {index1} {index2}" takes two elements and swap their places.
            //  •"multiply {index1} {index2}" takes element at the 1st index and multiply it with the element at 2nd index.
            // Save the product at the 1st index.
            //  •"decrease" decreases all elements in the array with 1.
            //Input
            //On the first input line, you will be given the initial array values separated by a single space.
            //On the next lines, you will receive commands until you receive the command "end".
            // The commands are as follows: 
            //  •"swap {index1} {index2}"
            //  •"multiply {index1} {index2}"
            //  •	"decrease"
            //Output
            // The output should be printed on the console and consist of elements
            // of the modified array – separated by a comma and a single space ", ".
            //  Constraints
            // •Elements of the array will be integer numbers in the range[-231...231].
            // •Count of the array elements will be in the range[2...100].
            // •Indexes will be always in the range of the array.

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = default;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputTokens = input.Split().ToArray();
                string command = inputTokens[0];

                if (command == "swap")
                {
                    int index2 = int.Parse(inputTokens[2]);
                    int index1 = int.Parse(inputTokens[1]);
                    (numbers[index1], numbers[index2]) = (numbers[index2], numbers[index1]);
                }
                else if (command == "multiply")
                {
                    int index2 = int.Parse(inputTokens[2]);
                    int index1 = int.Parse(inputTokens[1]);

                    numbers[index1] *= numbers[index2];
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                }

            }

            Console.WriteLine(string.Join(", " , numbers));


        }
    }
}