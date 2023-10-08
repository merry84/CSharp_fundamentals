using System.Runtime.Intrinsics.X86;
//Create a program that multiplies the sum of all even digits of a number
//by the sum of all odd digits of the same number:
//•	Create a method called GetMultipleOfEvenAndOdds()
//•	Create a method GetSumOfEvenDigits()
//•	Create GetSumOfOddDigits()
//•	You may need to use Math.Abs() for negative numbers

int number = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine(GetMultipleOfEvenAndOdds(number));

static int GetMultipleOfEvenAndOdds(int a)
{
    int result = GetSumOfEvenDigits(a) * GetSumOfOddDigits(a);
    
    return result;
}

static int GetSumOfEvenDigits(int number)
{
    int sumEven = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 == 0)// четно
        {
            sumEven += lastDigit;
        }
        number /= 10;
    }
    return sumEven;
}


static int GetSumOfOddDigits(int number)
{
    int sumOdd = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 == 1) //нечетно
        {
            sumOdd += lastDigit;
        }
        number /= 10;

    }
    return sumOdd;

}
