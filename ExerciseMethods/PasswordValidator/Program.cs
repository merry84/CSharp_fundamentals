using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that checks if a given password is valid.
            // The password validation rules are:

            //•	It should contain 6 – 10 characters(inclusive)
            //•	It should contain only letters and digits
            //•	It should contain at least 2 digits

            //If it is not valid, for any unfulfilled rule print the corresponding message:
            //•	"Password must be between 6 and 10 characters"
            //•	"Password must consist only of letters and digits"
            //•	"Password must have at least 2 digits"
            //Hints
           // Write a method for each rule.

            var input = Console.ReadLine();
            bool isValid = true;

            if (!CharactersAll(input))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!LettersAndDigits(input))
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!CharactersTwo(input))
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");

            }
            if (isValid == true)
            {

                Console.WriteLine("Password is valid");
            }
            static bool CharactersAll(string input)
            {
                return input.Length is >= 6 and <= 10;
            }
            static bool LettersAndDigits(string input)
            {
                return input.All(char.IsLetterOrDigit);
            }
            static bool CharactersTwo(string input)
            {
                return input.Count(char.IsDigit) >=2;

            }
        }
    }
}