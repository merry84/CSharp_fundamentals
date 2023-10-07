//  Create a program that receives three lines of input:
//•	On the first line – a string – "add", "multiply", "subtract", "divide".
//•	On the second line – a number.
//•	On the third line – another number.
//You should create four methods (for each calculation)
//and invoke the corresponding method depending on the command.
//The method should also print the result (needs to be void).

string command = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int result = 0;

result = PrintResult(command, firstNumber, secondNumber, result);
Console.WriteLine(result);

static int PrintResult(string command, int firstNumber, int secondNumber, int result)
{
    if (command == "add")
    {
        result = firstNumber + secondNumber;
    }
    else if (command == "multiply")
    {
        result = firstNumber * secondNumber;
    }
    else if (command == "subtract")
    {
        result = firstNumber - secondNumber;
    }
    else if (command == "divide")
    {
        result = firstNumber / secondNumber;
    }

    return result;
}