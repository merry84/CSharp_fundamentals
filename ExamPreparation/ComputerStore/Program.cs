﻿using System.ComponentModel.DataAnnotations;

namespace ComputerStore
{
    internal class Program
    {
        /*
        1050
        200
        450
        2
        18.50
        16.86
        special

        1023
        15
        -20
        -0.50
        450
        20
        17.66
        19.30
        regular
        */
        static void Main(string[] args)
        {
            //Write a program that prints you a receipt for your new computer.
            //You will receive the parts' prices (without tax) until you receive what type of customer this is
            //- special or regular. Once you receive the type of customer you should print the receipt.
            //The taxes are 20 % of each part's price you receive.
            // ** If the customer is special, he has a 10 % discount on the total price with taxes.
            // ** If a given price is not a positive number,you should print "Invalid price!"
            // on the console and continue with the next price.
            //  **If the total price is equal to zero, you should print "Invalid order!" on the console.
            // Input
            //  · You will receive numbers representing prices(without tax) until command "special" or "regular":
            //Output
            //  · The receipt should be in the following format:
            //"Congratulations you've just bought a new computer!
            //Price without taxes: { total price without taxes}$
            //Taxes: { total amount of taxes}$
            //-----------
            //    Total price: { total price with taxes}$"
            //Note: All prices should be displayed to the second digit after the decimal point!
            //The discount is applied only to the total price.
            //Discount is only applicable to the final price

            string input;
            decimal totalPrice = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "special" || input == "regular")
                {
                    break;
                }
                if (input != "special" || input != "regular")
                {

                    decimal price = decimal.Parse(input);
                    if (price < 0)
                    {
                        Console.WriteLine("Invalid price!");
                        continue;
                    }

                    totalPrice += price;
                }


            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                decimal taxPrice = totalPrice * (20m / 100m);
                decimal allPrice = taxPrice + totalPrice;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxPrice:f2}$");
                decimal discount = allPrice * (10m / 100m);

                Console.WriteLine("-----------");
                if (input == "special")
                {
                    Console.WriteLine($"Total price: {(allPrice-discount):f2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {allPrice:f2}$");

                }

            }
        }
    }
}