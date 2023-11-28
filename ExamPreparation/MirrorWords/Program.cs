using System.Collections.Immutable;
using System.Text;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             On the first line of the input, you will be given a text string. To win the competition,
            you have to find all hidden word pairs, read them, and mark the ones that are mirror images of each other.
               First of all, you have to extract the hidden word pairs. Hidden word pairs are:
               •	Surrounded by "@" or "#" (only one of the two) in the following pattern
                   #wordOne##wordTwo# or @wordOne@@wordTwo@
               •	At least 3 characters long each (without the surrounding symbols).
               •	Made up of letters only.
               If the second word, spelled backward, is the same as the first word and vice versa (casing matters!), 
            they are a match, and you have to store them somewhere. Examples of mirror words: 
               #Part##traP# @leveL@@Level@ #sAw##wAs#
               •	If you don`t find any valid pairs, print: "No word pairs found!"
               •	If you find valid pairs print their count: "{valid pairs count} word pairs found!"
               •	If there are no mirror words, print: "No mirror words!"
               •	If there are mirror words print:
               "The mirror words are:
               {wordOne} <=> {wordtwo}, {wordOne} <=> {wordtwo}, … {wordOne} <=> {wordtwo}"
               Input / Constraints
               •	You will recive a string.
               Output
               •	Print the proper output messages in the proper cases as described in the problem description.
               •	If there are pairs of mirror words, print them in the end, each pair separated by ", ".
               •	Each pair of mirror word must be printed with " <=> " between the words.
               
             */

            string text = Console.ReadLine();
            string wordPattern = @"([@#])(?<word>[A-Za-z]{3,})\1\1(?<mirror>[A-Za-z]{3,})";
            // @"(?<word>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))(?<mirror>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))"
            StringBuilder mirrorBuilder = new StringBuilder();
            MatchCollection match = Regex.Matches(text, wordPattern);
            foreach (Match matches in match)
            {
                string word = matches.Groups["word"].Value;
                string mirror = matches.Groups["mirror"].Value;
                string mirrorWord = new string(mirror.ToCharArray().Reverse().ToArray());
                if (word.Equals(mirrorWord))
                {
                    mirrorBuilder.Append($"{word} <=> {mirror}, ");
                }
            }
            //If you don`t find any valid pairs, print: "No word pairs found!"
            Console.WriteLine( match.Count == 0 ? "No word pairs found!": $"{match.Count} word pairs found!" );
            //If there are no mirror words
            if (mirrorBuilder.Length == 0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }

            mirrorBuilder.Remove(mirrorBuilder.Length - 2, 2);// cut ## and @@
            Console.WriteLine($"The mirror words are: \n {mirrorBuilder}");


        }
    }
}
