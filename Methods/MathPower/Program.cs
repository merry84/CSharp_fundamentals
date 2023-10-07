//Create a method, which receives two numbers as parameters:
//•	The first number – the base
//•	The second number – the power
// The method should return the base raised to the given power.

double number = double.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

double result = RaiseToPower(number,power);
Console.WriteLine(result);

static double RaiseToPower(double number,int power)
{
    return Math.Pow(number, power);
    
}
