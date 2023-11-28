using System.Text;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a string from the console and replaces any sequence
            //of the same letter with a single corresponding letter.
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text[0]);//добавяме първия индекс
            for (int i = 1;i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                {
                    sb.Append(text[i]);
                }

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
