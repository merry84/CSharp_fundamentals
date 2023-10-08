namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single string and prints out the number of vowels contained in it.

            string word = Console.ReadLine();
            int sumOfVowels = PrintVowelsInWord(word);
            Console.WriteLine(sumOfVowels);

            static int PrintVowelsInWord(string word)
            {
                int vowel = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'A' || word[i] == 'o' || word[i] == 'O'
                    || word[i] == 'e' || word[i] == 'E' || word[i] == 'i' || word[i] == 'I'
                    || word[i] == 'u' || word[i] == 'U'
                    || word[i] == 'y' || word[i] == 'Y')
                    {
                        vowel ++;
                    }

                }               
                return vowel;
            }
        }
    }
}