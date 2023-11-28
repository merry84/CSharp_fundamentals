using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> list = new List<Furniture>();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)\!(?<quantity>\d+)";
            
            string input ;

            while ((input = Console.ReadLine()) != "Purchase")
            {

                foreach (Match match in Regex.Matches(input,pattern))
                {
                    Furniture f = new Furniture();
                    f.Name = match.Groups["name"].Value;
                    f.Price = double.Parse(match.Groups["price"].Value);
                    f.Quantity = double.Parse(match.Groups["quantity"].Value);
                    list.Add(f);
                }
            }

            double totaCost = 0;
            Console.WriteLine("Bought furniture:");
            foreach (Furniture name in list)
            {
                Console.WriteLine(name.Name);
                totaCost += name.Total();
            }

            Console.WriteLine($"Total money spend: {totaCost:f2}");


        }

        class Furniture
        {
            public string Name { get; set; }

            public double Price { get; set; }

            public double Quantity { get; set; }

            public double Total()
            {
                return Price * Quantity;
            }
 
        }
    }
}
