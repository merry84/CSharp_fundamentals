using System.Diagnostics;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a program that keeps the information about products and their prices. 
             Each product has a name, a price and a quantity.
             If the product doesn't exist yet, add it with its starting quantity.
             If you receive a product, which already exists, 
             increase its quantity by the input quantity and if its price is different, replace the price as well.
             You will receive products' names, prices and quantities on new lines.
             Until you receive the command "buy", keep adding items. 
             When you do receive the command "buy", print the items with their names and the total price of all 
             the products with that name.
             Input
             • Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
             • The product data is always delimited by a single space.
             Output
             • Print information about each product in the following format: 
             "{productName} -> {totalPrice}"
             • Format the average grade to the 2nd digit after the decimal separator.

             */
            Dictionary<string,Products> products = new Dictionary<string,Products>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split();
                string name = command[0];
                double price = double.Parse(command[1]);
                double quantity = double.Parse(command[2]);

                Products product = new Products(name,price,quantity);

                if (!products.ContainsKey(name))//If the product doesn't exist yet, add it with its starting quantity.
                {
                    products.Add(name, product);
                }
                else
                //If you receive a product,which already exists,increase its quantity by the input quantity and if its price is different,
                //replace the price as well.
                {
                    products[name].UpdatePrice(price,quantity);
                }
            }
            foreach (KeyValuePair<string,Products> keyValuePair in products)
            {
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
    class Products
    {
        public Products(string name,double price,double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public void UpdatePrice(double price, double quantity)
        {
            Price = price;
            Quantity += quantity;
        }
        public double TotalPrice => Price * Quantity;
        public override string ToString()
        {
            return $"{Name} -> {TotalPrice:F2}";
        }
    }
    
}