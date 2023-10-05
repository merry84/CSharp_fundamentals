// Create a program that receives an array and several rotations that you have to perform.
// The rotations are done by moving the first element of the array from the front to the back.
// Print the resulting array. 
string[] numberArr = Console.ReadLine().Split();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    string firstNum = numberArr[0];
    for (int j = 0; j < numberArr.Length - 1; j++)
    {
        numberArr[j] = numberArr[j + 1];
    }
    numberArr[^1] = firstNum;
}

Console.WriteLine(string.Join(" ", numberArr));
    
