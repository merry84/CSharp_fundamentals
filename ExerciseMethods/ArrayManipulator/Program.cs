using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using System;
using System.ComponentModel.Design;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The array may be manipulated by one of the following commands

            //•	exchange { index} – splits the array after the given index
            //and exchanges the places of the two resulting sub-arrays
            //.E.g. [1, 2, 3, 4, 5]->exchange 2->result: [4, 5, 1, 2, 3]

            //o If the index is outside the boundaries of the array, print "Invalid index"

            //•	max even/ odd – returns the INDEX of the max even / odd element-> [1, 4, 8, 2, 3]->max odd->print 4
            //•	min even/ odd – returns the INDEX of the min even / odd element-> [1, 4, 8, 2, 3]->min even > print 3

            //o If there are two or more equal min / max elements, return the index of the rightmost one

            //o   If a min / max even / odd element cannot be found, print "No matches"

            //•	first { count} even / odd – returns the first { count}elements-> [1, 8, 2, 3]->first 2 even->print[8, 2]
            //•	last { count} even / odd – returns the last { count} elements-> [1, 8, 2, 3]->last 2 odd->print[1, 3]

            //o If the count is greater than the array length, print "Invalid count"
            //o If there are not enough elements to satisfy the count,
            //print as many as you can.If there are zero even / odd elements, print an empty array "[]"
            //•	end – stop taking input and print the final state of the array
            //Input
            //•	The input data should be read from the console.
            //•	On the first line, the initial array is received as a line of integers, separated by a single space.
            //•	On the next lines, until the command "end" is received, you will receive the array manipulation commands.
            //•	The input data will always be valid and in the format described.There is no need to check it explicitly.
            //Output
            //•	The output should be printed on the console.
            //•	On a separate line, print the output of the corresponding command.
            //•	On the last line print the final array in square brackets with its elements separated by a comma and a space .
            //•	See the examples below to get a better understanding of your task.
            //Constraints
            //•	The number of input lines will be in the range[2…50].
            //•	The array elements will be integers in the range[0…1000].
            //•	The number of elements will be in the range[1…50].
            //•	The split index will be an integer in the range[-231…231 – 1].
            //•	The first/ last count will be an integer in the range[1…231 – 1].
            //•	There will not be redundant whitespace anywhere in the input.

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] commandArr = command.Split();

                if (commandArr[0] == "exchange")
                {
                    int index = int.Parse(commandArr[1]);
                    Index(index, numbers);
                }
                else if (commandArr[0] == "max")
                {

                }
                else if (commandArr[0] == "min")
                {

                }
                else if (commandArr[0] == "first")
                {

                }
                else if (commandArr[0] == "last")
                {

                }

            }
            static void Index(int index, int[] numbers)
            {
                if (index >= 0 && index < numbers.Length)
                {
                    for (int i = 0; i < index + 1; i++)
                    {
                        int firstDigit = numbers[0];
                        for (int j = 0; j < numbers.Length - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Length - 1] = firstDigit;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            static void MaxEvenNumber(int [] numbers)
            {
                int maxNumber = int.MinValue;

            }
        }
    }
}