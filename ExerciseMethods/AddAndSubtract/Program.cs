namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive 3 integers.
            //Create a method that returns the sum of the first two integers
            //and another method that subtracts the third integer from the result of the sum method.

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            //SubstactsThirdResult(firstNum, secondNum, thirdNum);
            int result = SubstractsThirdResult(firstNum, secondNum, thirdNum);  
            Console.WriteLine(result);
           
        }
        static int SubstractsThirdResult(int firstNum,int secondNum , int thirdNum)
        {
            int sum = SumFirstAndSecondNum(firstNum, secondNum);
            return sum - thirdNum;
        }
        static int SumFirstAndSecondNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}