// Create a program that reads an array of strings, reverses it, and prints its elements.
// The input consists of a sequence of space-separated strings.
// Print the output on a single line (space separated).
string[] strings = Console.ReadLine()
    .Split()
    .ToArray();
for (int i = 0; i < strings.Length /2; i++)
{
    string firstString = strings[i];
    string lastString = strings[strings.Length - 1 - i];

    strings[i] = lastString;
    strings[strings.Length - 1 - i] = firstString;
}
Console.WriteLine(string.Join(" ", strings));
