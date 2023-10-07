//You are given an input of two values of the same type.
//The values can be of type int, char or string.
//Create methods called GetMax(),
//which can compare int, char or string and returns the biggest of the two values.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "char")
            {
                char firstChar = Console.ReadLine()[0];
                char secondChar = Console.ReadLine()[0];
                char result = PrintMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (command == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int result = PrintMax(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (command == "string")
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();
                string result = (PrintMax(firstText, secondText));
                Console.WriteLine(result);
            }
        }
        private static char PrintMax(char firstChar, char secondChar)
        {
            if (firstChar.CompareTo(secondChar) > 0) //ако е 1 - значи 
            {
                return (firstChar);
            }
            else
            {
                return (secondChar); //ако е -1 
            }
        }
        private static int PrintMax(int firstNum, int secondNum)
        {
            if (firstNum.CompareTo(secondNum) > 0) //ако е 1 
            {
                return (firstNum);
            }
           return (secondNum); //ако е -1 

        }
        private static string PrintMax(string firstText, string secondText)
        {
            if (firstText.CompareTo(secondText) > 0) //ако е 1
            {
                return (firstText);
            }
            return (secondText); //ако е -1 
        }
    }
}