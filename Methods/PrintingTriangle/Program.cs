//Create a method for printing triangles as shown below:
// 3    1
//      1 2
//      1 2 3
//      1 2
//      1


int number = int.Parse(Console.ReadLine());

PrintTriangles(number);

for (int row = number - 1; row >= 1; row--)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write(col + " ");
    }
    Console.WriteLine();
}

static void PrintTriangles(int number)
{
    for (int col = 1; col <= number; col++)
    {
        for (int row = 1; row <= col; row++)
        {
            Console.Write(row + " ");
        }
        Console.WriteLine();
    }
}
