// Create a program that determines if an element exists
// in an array for which the sum of all elements to its left is 
//equal to the sum of all elements to its right.
//If there are no elements to the left or right, their sum is considered to 
//be 0. Print the index of the element that satisfies the condition
//or "no" if there is no such element

int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
for (int i = 0; i <= number.Length - 1; i++)
{
    if (number.Length == 1)
    {
        Console.WriteLine(0);
        return;
    }
    int sumLeft = 0;
    for (int iLeft = i; iLeft > 0; iLeft--)
    {
        int nextPosition = iLeft - 1;
        if (iLeft > 0)
        {
            sumLeft += number[nextPosition];
        }
    }
    int sumRight = 0;
    for (int iRight = i; iRight < number.Length; iRight++)
    {
        int nextPosition = (iRight + 1);
        if (iRight < number.Length - 1)
        {
            sumRight += number[nextPosition];
        }
    }
    if (sumLeft == sumRight)
    {
        Console.WriteLine(i);
        return;
    }
}
Console.WriteLine("no");
