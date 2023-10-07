////Create a method that receives two parameters:
//•	A string 
//•	A number n (integer) represents how many times the string will be repeated
// The method should return a new string, containing the initial one,
// repeated n times without space. 

string name = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

string result = StringRepeate(name,n);
Console.WriteLine(result);
static string StringRepeate(string name,int n)
{
     string newName = "";
    for (int i = 0; i < n; i++)
    {
        newName += name;
    }
    return newName;
}


