namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives two characters and prints all the characters
            //between them according to ASCII (on a single line).
            //NOTE: If the second letter's ASCII value is less than that of the first one,
            //then the two initial letters should be swapped.
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
             
            PrintCharaters(firstChar, secondChar);
        }

        private static void PrintCharaters(char firstChar, char secondChar)
        {
            if (secondChar < firstChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}