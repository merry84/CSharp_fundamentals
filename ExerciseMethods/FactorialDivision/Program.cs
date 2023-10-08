namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read two integers. Calculate the factorial of each number.
            //Divide the first result by the second and
            //print the result of the division formatted to the second decimal point.
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double fact1 = FirstFacorial(firstNumber);
            double fact2 = SecondFacorial(secondNumber);
            PrintFactorialDivision(fact1,fact2);
        }
        static void PrintFactorialDivision(double fact1,double fact2)
        {

            double result = (double)fact1 / fact2;
            Console.WriteLine($"{result:f2}");
            
        }
        static double FirstFacorial(int firstNumber)
        {
            double fact1 = 1;
            for (int i = 0; i < firstNumber; i++)
            {
                fact1 *= (firstNumber - i);

            }
            return fact1;
        }
        static double SecondFacorial(int secondNumber)
        {
            double fact2 = 1;
            for(int i = 0; i < secondNumber; i++)
            {
                fact2 *= (secondNumber - i);
            }
            return fact2;
        }
    }
}