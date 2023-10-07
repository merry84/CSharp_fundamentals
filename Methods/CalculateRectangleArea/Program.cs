//Create a method that calculates and returns the area of a rectangle. 

double length = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

PrintAreaOfRectangle(height, length);

static void PrintAreaOfRectangle(double lenght, double height)
{
    double area = 0;
    area = lenght * height;
    Console.WriteLine(area);
}