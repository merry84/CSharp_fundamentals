// Create a program,
// which prints all unique pairs in an array of integers whose sum is equal to a given number.
int[]numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sumOfNum = int.Parse(Console.ReadLine());
for(int i = 0; i < numbers.Length-1; i++)
{
    for(int j = i+1; j < numbers.Length; j++)
    { 
        if (numbers[i] + numbers[j] == sumOfNum)
        {
            Console.WriteLine(numbers[i]+ " " + numbers[j]);
        }
    }
}