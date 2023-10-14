using System.Collections.Generic;
using System.Security.Cryptography;
using System;
//  A top number is an integer that holds the following properties:

//•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
//•	Holds at least one odd digit, e.g. 232, 707, 87578

//•	Some examples of top numbers are: 17, 161, 251, 4310, 123200
//Create a program to print the range[1…n].
//You will receive a single integer from the console, representing the end value.
//all top numbers in 

int n = int.Parse(Console.ReadLine());
IsTopInteger(n);

static bool OddDigit(int n)
{
    while (n > 0)
    {

        if ((n % 10) % 2 == 1)
            return true;
        n /= 10;
    }

    return false;

}

static bool IsDivisibleBy8(int n)
{
    int digitSum = 0;
    while (n > 0)
    {
        digitSum += n % 10;
        n /= 10;
    }
    if (digitSum % 8 == 0)
    {
        return true;
    }
    return false;
}
static void IsTopInteger(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (OddDigit(i) && IsDivisibleBy8(i))
        {
            Console.WriteLine(i);
        }
    }
}
