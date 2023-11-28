using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Text;

namespace PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             First, you will receive a string, and afterward, until the command "Done" is given, you will be receiving strings with commands split by a single space. The commands will be the following:
               => •	"TakeOdd"
                  o Takes only the characters at odd indices and concatenates them to obtain the new raw password
                    and then prints it.
               =>•	"Cut {index} {length}"
                  o Gets the substring with the given length starting from the given index from the password 
                    and removes its first occurrence, then prints the password on the console.
                  o The given index and the length will always be valid.
               =>•	"Substitute {substring} {substitute}"
                  o	If the raw password contains the given substring, replace all of its occurrences 
            with the substitute text given and print the result.
                  o	If it doesn't, prints "Nothing to replace!".
               Input
                  •	You will be receiving strings until the "Done" command is given.
               Output
                  •	After the "Done" command is received, print:
                  o	"Your password is: {password}"
               Constraints
                  •	The indexes from the "Cut {index} {length}" command will always be valid.
               */

            StringBuilder password = new StringBuilder(Console.ReadLine());

            
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commands = command.Split();
                if (commands[0] == "TakeOdd")
                {
                    password = TakeOdd(password);
                }
                else if (commands[0] == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int lenght = int.Parse(commands[2]);
                   password = Cut(password, startIndex, lenght);
                }
                else if (commands[0] == "Substitute")
                {
                    string substring = commands[1];
                    string substitute = commands[2];
                    Substitute(password, substring, substitute);

                }
            }
            
            
            Console.WriteLine($"Your password is: {password}");
        }

        private static StringBuilder Substitute(StringBuilder password, string substring, string substitute)
        {
            if (password.ToString().Contains(substring))
            {
                password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return password;
        }

        private static StringBuilder Cut(StringBuilder password, int startIndex, int lenght)
        {
            //Gets the substring with the given length starting from the given index from the password 
            // and removes its first occurrence, then prints the password on the console.
            password = password.Remove(startIndex, lenght);
            Console.WriteLine(password);
            return password;
        }

        private static StringBuilder TakeOdd(StringBuilder password)
        {
            
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < password.Length; i+=2)
            {
                //Takes only the characters at odd indices and concatenates them to obtain the new raw password
                  //  and then prints it.
                result.Append(password[i]);
            }

            password = result;
            Console.WriteLine(password);
            return password;
        }
    }
}
