﻿using System;

namespace ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *The first line of the input will be your raw activation key. It will consist of letters and numbers only.
               
               After that, until the "Generate" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the raw activation key.
               
               There are several types of instructions, split by ">>>":
               
               · "Contains>>>{substring}":
               
               o If the raw activation key contains the given substring, print "{raw activation key} contains {substring}".
               
               o Otherwise, print "Substring not found!"
               
               · "Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
               
               o Changes the substring between the given indices (the end index is exclusive) to upper or lower case and then prints the activation key.
               
               o All given indexes will be valid.
               
               · "Slice>>>{startIndex}>>>{endIndex}":
               
               o Deletes the characters between the start and end indices (the end index is exclusive) and prints the activation key.
               
               o Both indices will be valid.
               
               Input
               
               · The first line of the input will be a string consisting of letters and numbers only.
               
               · After the first line, until the "Generate" command is given, you will be receiving strings.
               
               Output
               
               · After the "Generate" command is received, print:
               
               o "Your activation key is: {activation key}"
             */

            string activationKey = Console.ReadLine();
            string input ;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] inputTokens = input.Split(">>>").ToArray();
                string command = inputTokens[0];
                if (command == "Contains")
                {
                    string substring = inputTokens[1];
                    Console.WriteLine(activationKey.Contains(substring) ? $"{activationKey} contains {substring}" : "Substring not found!");
                    continue;
                }
                else if (command == "Flip")//"Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
                {
                    activationKey = UpperOrLowerS(inputTokens, activationKey, out var upperOrLower, out var startIndex, out var endIndex);
                }
                else if(command == "Slice")
                {
                    int startIndex = int.Parse(inputTokens[1]);
                    int endIndex = int.Parse(inputTokens[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                }
                Console.WriteLine($"{activationKey}");
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        private static string UpperOrLowerS(string[] inputTokens, string activationKey, out string upperOrLower,
            out int startIndex, out int endIndex)
        {
            upperOrLower = inputTokens[1];
            startIndex = int.Parse(inputTokens[2]);
            endIndex = int.Parse(inputTokens[3]);
            string extractedSubstring = activationKey.Substring(startIndex, endIndex - startIndex);
            if (upperOrLower == "Upper")
            {
                extractedSubstring = extractedSubstring.ToUpper();
            }
            else
            {
                extractedSubstring = extractedSubstring.ToLower();
            }

            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
            activationKey = activationKey.Insert(startIndex, extractedSubstring);
            return activationKey;
        }
    }
}
