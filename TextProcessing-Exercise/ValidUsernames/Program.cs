using System.ComponentModel;
//Create a program that reads user names on a single line(joined by ", ") and prints all valid usernames.
//A valid username
//• has length between 3 and 16 characters
//• contains only letters, numbers, hyphens and underscores

string[] userNames = Console.ReadLine().Split(", ");

foreach (string user in userNames.Where(l => l.Length >= 3 && l.Length <= 16
    && !l.Any(c => !char.IsLetterOrDigit(c) && c != '_' && c != '-')))
{
    Console.WriteLine(user);
}
