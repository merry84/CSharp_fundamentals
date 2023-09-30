// Create a program that calculates the difference between the sum
// of the even and the sum of the odd numbers in an array.
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sumEven = 0;
int sumOdd = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int currentNum = numbers[i];
    if (currentNum % 2 == 0)
    {
        sumEven += numbers[i];
    }
    else { sumOdd += numbers[i]; }
}
Console.WriteLine(sumEven- sumOdd);