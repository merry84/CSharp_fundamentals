using System;

namespace Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will be given a series of strings, until you receive an "end" command. Write a program that reverses strings and prints each pair on a separate line in the format "{word} = {reversed word}".

            string input;
           
            while ((input = Console.ReadLine()) != "end")
            {
                char[] reverseWord = input.Reverse().ToArray();

                Console.WriteLine($"{input} = {string.Join("",reverseWord)}");
               
            }
               
        }
    }
}