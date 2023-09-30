//Enter a number in range 1-7 and print out the word representing it or "Invalid Day!".
//Use an array of strings.

string[] days = { "Monday", "Tuesday", "Wednesday",
"Thursday", "Friday", "Saturday", "Sunday" };
int day = int.Parse(Console.ReadLine());
if (day >= 1 && day <= 7)
    Console.WriteLine(days[day - 1]);
else
    Console.WriteLine("Invalid day!");