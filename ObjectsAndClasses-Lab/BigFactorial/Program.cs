namespace BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive a number N in the range [0…1000].
            //Calculate the Factorial of N and print out the result.

            int number = int.Parse(Console.ReadLine());

            System.Numerics.BigInteger f = 1;
            for (int i = 2; i <= number; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }

    }
}