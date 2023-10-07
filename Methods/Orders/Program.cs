//Create a program that calculates and prints the total price of an order. The method should receive two parameters:
//•	A string, representing a product - "coffee",  "water", "coke", "snacks"
//•	An integer, representing the quantity of the product
//The prices for a single item of each product are:
//•	coffee – 1.50
//•	water – 1.00
//•	coke – 1.40
//•	snacks – 2.00
//Print the result, rounded to the second decimal place.

using System.Net.Http.Headers;

string product = Console.ReadLine();
int quantityOfProduct = int.Parse(Console.ReadLine());
double totalPrice = 0;
PrintTotalPriceOfProduct(totalPrice, product, quantityOfProduct);
static void PrintTotalPriceOfProduct(double totalPrice, string product, int quantityOfProduct)
{


    if (product == "coffee")
    {
        totalPrice = 1.50 * quantityOfProduct;
    }
    else if (product == "water")
    {
        totalPrice = 1.00 * quantityOfProduct;
    }
    else if (product == "coke")
    {
        totalPrice = 1.40 * quantityOfProduct;
    }
    else if (product == "snacks")
    {
        totalPrice = 2.00 * quantityOfProduct;
    }
    Console.WriteLine($"{totalPrice:f2}");


}