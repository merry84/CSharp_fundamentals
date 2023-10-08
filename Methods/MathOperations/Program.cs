//Write a method that receives two numbers and an operator,
//calculates the result and returns it.
//You will be given three lines of input.
//The first will be the first number,
//the second one will be the operator
//and the last one will be the second number.
//The possible operators are: /, *, + and -.

internal class Program
{
    private static void Main()
    {
        int firsNum = int.Parse(Console.ReadLine());
        string operators = Console.ReadLine();
        int secondNum = int.Parse(Console.ReadLine());

        int resultSum = ResultOperations(firsNum, operators, secondNum);
        Console.WriteLine(resultSum);
        static int ResultOperations(int firsNum, string operators, int secondNum)
        {

            int result = 0;

            if (operators == "+")
            {
                result = firsNum + secondNum;
            }
            else if (operators == "-")
            {
                result = firsNum - secondNum;
            }
            else if (operators == "*")
            {
                result = firsNum * secondNum;
            }
            else if (operators == "/")
            {
                result = firsNum / secondNum;
            }
            return result;

        }
    }
} 