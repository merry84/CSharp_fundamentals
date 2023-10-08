namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads positive integers until you receive the "END" command.
            //For each number, print whether the number is a palindrome or not.
            //A palindrome is a number that reads the same backward as forward, such as 323 or 1001. 
            string input = Console.ReadLine();
            
            while (input != "END")
            {
                bool isPalindromNumber = IsPalindrome(input);
                if (!IsPalindrome(input))
                {
                    isPalindromNumber = false;

                    Console.WriteLine("false");
                }
                else
                {
                    isPalindromNumber = true;
                    Console.WriteLine(true);
                }
                input = Console.ReadLine();
            }


        }
        static bool IsPalindrome(string input)
        {
            bool isPalindrom = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    isPalindrom = true;
                    return true;

                }
                else
                {
                    isPalindrom = false;
                    return false;
                }
            }
            return isPalindrom;
        }
    }
}