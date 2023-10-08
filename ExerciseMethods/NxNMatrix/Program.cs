using System;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3	3 3 3
                3 3 3
                3 3 3
            */
            //Create a method that receives a single integer n and prints an NxN matrix
            //using this number as a filler.

            int number = int.Parse(Console.ReadLine()); 
            int[]n = new int[number];
            ArrN(n, number);
            PrintMatrix(n,number);
       
        }
        static void ArrN(int[] n, int number)
        {
            for (int i = 0; i < n.Length; i++)

                n[i] = number;
        }
        static void PrintMatrix(int[] n, int number)
        {
            for (int i = 0; i < n.Length; i++)
            {

                Console.WriteLine(string.Join(" ", n));
            }

        }
    }
}
