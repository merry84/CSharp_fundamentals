namespace SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *On the first line of the input, you will receive the concealed message.
             * After that, until the "Reveal" command is given,
             * you will receive strings with instructions for different operations
             * that need to be performed upon the concealed message to interpret it and reveal its actual content.
             * There are several types of instructions, split by ":|:"
               
            · "InsertSpace:|:{index}":
               
                  o Inserts a single space at the given index. The given index will always be valid.
               
            · "Reverse:|:{substring}":
               
                  o If the message contains the given substring, cut it out, reverse it and add it at the end of the message.
               
                  o If not, print "error".
               
                  o This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
               
               · "ChangeAll:|:{substring}:|:{replacement}":
               
                  o Changes all occurrences of the given substring with the replacement text.
               
               Input / Constraints
               
               · On the first line, you will receive a string with a message.
               
               · On the following lines, you will be receiving commands, split by ":|:".
               
               Output
               
               · After each set of instructions, print the resulting string.
               
               · After the "Reveal" command is received, print this message: "You have a new text message: {message}"
             */
            string message = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] inputTokens = input.Split(":|:").ToArray();
                string command = inputTokens[0];
                if (command == "InsertSpace")
                {
                    int action = int.Parse(inputTokens[1]);
                    message = message.Insert(action," ");
                }
                else if (command == "Reverse")
                {
                    string substring = inputTokens[1];
                    int substrigindex = message.IndexOf(substring);
                    if (substrigindex == -1)
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    //If the message contains the given substring, cut it out,                
                    message = message.Remove(substrigindex, substring.Length);
                    string reverseSubstring = new string(substring.Reverse().ToArray());//reverse it 

                    message += reverseSubstring;//and add it at the end of the message.
                }
                else if(command == "ChangeAll")
                {
                    string substring = inputTokens[1];
                    string replacement = inputTokens[2];
                    message = message.Replace(substring, replacement);
                }
                Console.WriteLine(message);
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
