//You will receive input until you receive "END". Find what data type is the input. Possible data types are:
//• Integer
//• Floating point 
//• Characters
//• Boolean
//• Strings
//Print the result in the following format: "{input} is {data type} type".
 var  input = Console.ReadLine();
int integer  = 0;
double floating = 0;
char charcter = ' ';
bool boolean;

while (input != "END")
{
    if (int.TryParse(input, out integer))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (double.TryParse(input, out floating))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (char.TryParse(input, out charcter))
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (bool.TryParse(input, out boolean))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }

    input = Console.ReadLine();
}