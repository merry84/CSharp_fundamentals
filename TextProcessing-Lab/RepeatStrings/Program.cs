using System.Text;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads an array of strings. Each string is repeated N times, where N is the length of the string.
            //Print the concatenated string.

            string[] words = Console.ReadLine().Split();
            
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                   
                      Console.Write(word);
                   
                }
              
            }
        }
    }
}