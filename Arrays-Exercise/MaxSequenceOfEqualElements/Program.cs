// Create a program that finds the longest sequence of equal elements in an array of integers.
// If several equal sequences are present in the array, print out the leftmost one.
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int count = 1;
int countLenght = 0;
int element = 0;
for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        count++;
    }
    else
    {
        count = 1;
    }
    if (countLenght < count)
    {
        countLenght = count;
        element = numbers[i];
    }
}
for (int j = 1; j <= countLenght; j++)
{
    Console.WriteLine($"{element}");

}
