namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero
            //entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the
            //number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other)
            //row is 1(the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in
            //the fourth row.
            //If you want more info about it: https://en.wikipedia.org/wiki/Pascal's_triangle
            //Print each row element separated with whitespace.

            int rows = int.Parse(Console.ReadLine());

            int[] currentArray = { 1 };
            for (int row = 1; row < rows; row++)
            {
                int[] nextArray = new int[currentArray.Length + 1];
                for (int i = 0; i < currentArray.Length; i++)
                {
                    nextArray[i] += currentArray[i];
                    nextArray[i + 1] += currentArray[i];
                }
                Console.WriteLine(string.Join(' ', currentArray));
                currentArray = nextArray;
            }
            Console.WriteLine(string.Join(' ', currentArray));
        }
    }
}