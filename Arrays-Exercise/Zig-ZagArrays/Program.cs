// Create a program that creates 2 arrays.
// You will be given an integer n.
// On the next n lines, you will get 2 integers.
// Form 2 new arrays in a zig-zag pattern as shown below. 
int n = int.Parse(Console.ReadLine());
string[] firstArr = new string[n];
string[] secondArr = new string[n];
bool isfirstNumbers = true;
for (int i = 0; i < n; i++)
{
    string nums = Console.ReadLine();
    string[] numsArr = nums.Split();
    if (isfirstNumbers)
    {
        firstArr[i] = numsArr[0];
        secondArr[i]= numsArr[1];
    }
    else
    {

        firstArr[i] = numsArr[1];
        secondArr[i] = numsArr[0];
    }
    isfirstNumbers = !isfirstNumbers;
}
Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));
