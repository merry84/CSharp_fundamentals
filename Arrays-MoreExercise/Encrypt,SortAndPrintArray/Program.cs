namespace Encrypt_SortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
            //• The code of each vowel multiplied by the string length
            //• The code of each consonant divided by the string length
            //Sort the number sequence in ascending order and print it in the console.
            //On the first line, you will always receive the number of strings you have to read.

            int n = int.Parse(Console.ReadLine());

            string[] arrNames = new string[n];
            int[] currentArr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arrNames[i] = Console.ReadLine();
                string currentName = arrNames[i];
                sum = 0;
                for (int j = 0; j < currentName.Length; j++)
                {
                    char digit = currentName[j];
                    int value = (int)digit;
                    if (digit == 'a' || digit == 'i' || digit == 'o' || digit == 'u' || digit == 'e'
                       || digit == 'A' || digit == 'I' || digit == 'O' || digit == 'U' || digit == 'E')
                    {
                        sum += value * currentName.Length; //• The code of each vowel multiplied by the string length
                    }
                    else
                    {
                        sum += value / currentName.Length;//• The code of each consonant divided by the string length
                    }
                }
                currentArr[i] = sum;
            }
            Array.Sort(currentArr); //Sort the number sequence in ascending order and print it in the console.
            for (int i = 0; i < currentArr.Length; i++)
            {
                Console.WriteLine(currentArr[i]);
            }

        }
    }
}