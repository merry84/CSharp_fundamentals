using System.Xml.Linq;

namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read a number n and n lines of products.Print a numbered list of all the products ordered by name.

            int n = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string tipeProduct = Console.ReadLine();
                productsList.Add(tipeProduct);
            }
            productsList.Sort();
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productsList[i]}");

            }
        }
    }
}