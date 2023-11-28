using System.Text;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Create a program that returns an encrypted version of the same text.
               Encrypt the text by shifting each character with three positions forward.
               For example, A would be replaced by D, B would become E and so on. 
               Print the encrypted text.
             */
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char s in text)
            {
                int cryptChar = s + 3;
                sb.Append((char)cryptChar);
            }
            Console.WriteLine(sb);
        }
    }
}
