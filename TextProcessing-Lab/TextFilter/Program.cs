namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that takes a text and a string of banned words.
            //All words included in the ban list should be replaced with a string of asterisks '*',
            //whose length must be equal to the word's length.
            //The entries in the ban list will be separated by a comma and space ", ".
            //The ban list should be entered on the first input line and the text on the second input line. 

            string[] banWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            
            for (int i = 0; i < banWords.Length; i++)
            {

                while (text.Contains(banWords[i]))
                {
                   text= text.Replace(banWords[i],new string('*', banWords[i].Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}