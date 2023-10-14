namespace RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Fibonacci sequence is a quite famous sequence of numbers. Each member of the sequence is calculated from
            //the sum of the two previous elements. The first two elements are 1, 1. Therefore the sequence goes like 1, 1, 2, 3, 5,
            //8, 13, 21, 34…
            //The following sequence can be generated with an array, but that's easy, so your task is to implement recursively.
            //So if the function GetFibonacci(n) returns the n
            //th Fibonacci number we can express it using GetFibonacci(n)
            //= GetFibonacci(n - 1) + GetFibonacci(n - 2).
            //However, this will never end and in a few seconds, a StackOverflow Exception is thrown. For the recursion to stop, it
            //has to have a “bottom”. The bottom of the recursion is GetFibonacci(2) should return 1 and
            //GetFibonacci(1) should return 1.
            //Input Format
            //• On the only line in the input, the user should enter the wanted Fibonacci number.
            //Output Format
            //• The output should be the nth Fibonacci number counting from 1.
            //Constraints
            //• 1 ≤ N ≤ 50
            //or the N
            //For the Nth Fibonacci number, we calculate the N-1th and the N-2th number, but for the calculation of the N-1th
            //number we calculate the N-1-1th(N-2th) and the N-1-2
            //thе number, so we have a lot of repeated calculations.

            int n = int.Parse(Console.ReadLine());
            int[] fibonacciSequence = new int[50];

            fibonacciSequence[0] = 1;
            fibonacciSequence[1] = 1;

            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2]; //GetFibonacci(n)= GetFibonacci(n - 1) + GetFibonacci(n - 2).
                }
            }
            Console.WriteLine(fibonacciSequence[n - 1]);
        }
    }
}