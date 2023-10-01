// A train has n number of wagons (integer, received as input).
// On the next n lines, you will receive the number of people that are going to get on each wagon.
//Print out the number of passengers in each wagon followed by the
//total number of passengers on the train
int n = int.Parse(Console.ReadLine());
int sum = 0;
int[] wagons = new int[n];
for (int i = 0; i < n; i++)
{
    int people = int.Parse(Console.ReadLine());
    wagons[i] = people;
    sum += wagons[i];
}
Console.WriteLine(string.Join(" ", wagons));
Console.WriteLine(sum);
