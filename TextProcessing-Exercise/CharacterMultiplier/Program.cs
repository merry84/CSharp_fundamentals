using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that takes two strings as arguments and
            //returns the sum of their character codes multiplied.
            //Multiply str1[0] with str2[0] and add to the total sum.
            //Then continue with the next two characters.If one of the strings is longer than the other,
            //add the remaining character codes to the total sum without multiplication.
            string[] text = Console.ReadLine().Split();
            int result = Sum(text[0], text[1]);
            Console.WriteLine(result);
           // firstText.Length > secondText.Length ? firstText : secondText;
        }
        static int Sum(string text1, string text2)
        {
            int result = 0;
            int lenght = Math.Max(text1.Length, text2.Length);
            for (int i = 0; i < lenght; i++)
            {
                if(i < text1.Length && i < text2.Length)
                {
                    result += text1[i] * text2[i];
                }
                else if (i < text1.Length)
                {
                    result += text1[i];
                }
                else if(i < text2.Length)
                {
                    result += text2[i];
                }
            }
                return result;
        }
    }
}
