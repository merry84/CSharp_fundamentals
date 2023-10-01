// Create a program that prints out all common elements in two arrays.
// You have to compare the elements of the second array to the elements of the first. 
/*
Hey hello 2 4 
10 hey 4 hello 
i love to code 
code i love to 
     */
string input = Console.ReadLine();
string[] firstArr = input.Split();
input = Console.ReadLine();
string[] secondArr = input.Split();
for (int i = 0; i < secondArr.Length; i++)
{
    for (int j = 0; j < firstArr.Length; j++)
    {
        if (secondArr[i] == firstArr[j])
        {
            Console.Write($"{secondArr[i]} ");
            break;
        }
    }
}