//Create a method, which receives two numbers as parameters:
//•	The first number – the base
//•	The second number – the power
// The method should return the base raised to the given power.

int number = int.Parse(Console.ReadLine());
double power = double.Parse(Console.ReadLine());
double result = RaiseToPower(power, number);
Console.WriteLine(result);

static double RaiseToPower(double power,int number)
{
    double result = Math.Pow(number, power);
    return result;
}
