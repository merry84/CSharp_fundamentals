using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System;

namespace RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will be given a string that will contain words separated by a single space.
            //Randomize their order and print each word on a new line.

            //•	Split the input string by(space) and create an array of words.
            //•	Create a random number generator – an object rnd of type Random.
            //•	In a for loop exchange each number at positions 0, 1,…,
            //words.Length - 1 by a number at random position.
            //To generate a random number in range use rnd.Next(minValue, maxValue).
            //Note that by definition minValue is inclusive, but maxValue is exclusive.
            //•	Print each word in the array on new line.

            string[] words = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int wordIndex = random.Next(words.Length);
                string currentWord = words[i];
                string randomWord = words[wordIndex];
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}