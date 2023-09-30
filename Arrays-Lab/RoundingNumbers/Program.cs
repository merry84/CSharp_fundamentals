// Read an array of real numbers (space separated),
// round them in "away from 0" style and print the output as in the examples:
double [] numbers = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
int[] roundetNumbers = new int[numbers.Length]; 
for (int i = 0; i < numbers.Length; i++)
{
    roundetNumbers[i] = (int)Math.Round(numbers[i],MidpointRounding.AwayFromZero);
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{numbers[i]} => {roundetNumbers[i]}");
}
