using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string.Create a method that prints the character found at its middle.
            //If the length of the string is even, there are two middle characters.

            string letter = Console.ReadLine();

            Console.WriteLine(GetMiddleChar(letter));
        }
        static string GetMiddleChar(string letter)
        {
            int chars = letter.Length;

            string result = "";
            if ( chars % 2 == 1)
            {
                result = letter[letter.Length / 2].ToString();//middle character odd string.
            }
            else
            {
                result = letter[letter.Length / 2 -1].ToString() + letter[letter.Length / 2].ToString();//two middle characters.
            }
            return result;
        } 
    }
}