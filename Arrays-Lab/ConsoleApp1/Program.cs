// Read n numbers and print them in reverse order, separated by a single space.

//First, we need to read n from the console.
//Create an array of integers with n size.

int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
//Read n numbers using for loop.
//Set number to the corresponding index.
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    numbers[i] = number;
}
//Print the array in reversed order.
for (int i = numbers.Length - 1; i >= 0 ; i--)
{
    Console.WriteLine(numbers[i] +" ");
}
