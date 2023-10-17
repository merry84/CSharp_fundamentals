namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               1 2 3 4 5 5 5 6
               Delete 5
               Insert 10 1
               Delete 5
               end            */
            //Create a program, that reads a list of integers from the console
            //and receives commands to manipulate the list.
            // Your program may receive the following commands:
            //  • Delete { element} – delete all elements in the array,
            // which are equal to the given element.
            //  • Insert { element} { position} – insert the element at the given position.
            // You should exit the program when you receive the "end" command.
            // Print all numbers in the array, separated by a single whitespace
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = default;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] argument = input.Split().ToArray();
                ;
                if (argument[0] == "Delete")
                {
                    int element = int.Parse(argument[1]);
                    numbers.RemoveAll(x => x ==element);
                }
                else if (argument[0] == "Insert")
                {
                    int element = int.Parse(argument[1]);
                    int index = int.Parse(argument[2]);

                    numbers.Insert(index,element);
                }
            }

            Console.WriteLine(string.Join(' ', numbers));

	
        }
    }
}