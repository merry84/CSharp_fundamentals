using System.Text;
using System.Numerics;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Explosions are marked with '>'.
            Immediately after the mark, there will be an integer, which signifies the strength of the explosion.
                You should remove x characters (where x is the strength of the explosion),
            starting after the punched character ('>').
                If you find another explosion mark ('>') while you're deleting characters,
            you should add the strength to your previous explosion.
                When all characters are processed, print the string without the deleted characters.
                You should not delete the explosion character – '>',
            but you should delete the integers, which represent the strength.
                Input
                You will receive a single line with the string.
                Output
                Print what is left from the string after the explosions.
                Constraints
                • You will always receive strength for the punches.
                • The path will consist only of letters from the Latin alphabet, integers and the char '>'.
                • The strength of the punches will be in the interval [0…9].
              */
            string text = Console.ReadLine();
            string result = ProcessExplosions(text);
            Console.WriteLine(result);
        }

        private static string ProcessExplosions(string text)
            {
                StringBuilder resultBuilder = new StringBuilder();
                int power = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '>')// ако елемента е този
                    {
                        power += int.Parse(text[i + 1].ToString());// сила на експлозията E i+1
                        resultBuilder.Append(text[i]);//добавяме елемета

                    }
                    else if (power == 0)// ако силата на експлозията е 0
                    {
                        resultBuilder.Append(text[i]);//добавяме само елемента
                    }
                    else
                    {
                        power--;//намаляме силата
                    }
                }

                return resultBuilder.ToString();
            }
        }
    }
