namespace SmallestOfThreeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that prints out the smallest of three integer numbers.
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int result = PrintSmallestNumber(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);

            static int PrintSmallestNumber(int firstNum, int secondNum, int thirdNum)
            {
                int smallestNum = Math.Min(Math.Min(firstNum, secondNum),thirdNum);
                return smallestNum;
            }
        }
    }
}