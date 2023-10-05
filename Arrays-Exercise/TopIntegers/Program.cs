//Create a program to find all the top integers in an array.
//A top integer is an integer that is greater than all the 
//elements to its right
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < input.Length; i++)
{
    bool topInt = true;
    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] <= input[j])
        {
            topInt = false;
        }



    }
    if (topInt)
    {
        Console.Write(input[i] + " ");

    }


}

