namespace Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives a single string and prints all the digits on the first line,
            //on the second – all the letters, and on the third – all the other characters.
            //There will always be at least one digit, one letter and one other character.

            string symbols = Console.ReadLine();

            Console.WriteLine(string.Join("",symbols.Where(char.IsDigit)));
            Console.WriteLine(string.Join("",symbols.Where(char.IsLetter)));
            Console.WriteLine(string.Join("",symbols.Where(character => !char.IsLetterOrDigit(character))));
        }
       
    }
}