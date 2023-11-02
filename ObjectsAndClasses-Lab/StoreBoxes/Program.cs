using System.Diagnostics;
using System.Xml.Linq;

namespace StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define a class Item, which contains these properties: Name and Price.
            // Define a class Box, which contains these properties:
            // Serial Number, Item, Item Quantity and Price for a Box.
            // Until you receive "end", you will be receiving data in the following format:
            // "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
            //The Price of one box has to be calculated: itemQuantity* itemPrice.
            //Print all the boxes ordered descending by price for a box, in the following format: 
            //{ boxSerialNumber}
            //-- {boxItemName} - ${boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}
            //The price should be formatted to the 2nd digit after the decimal separator.

            string input = Console.ReadLine();
            List<Box> output = new List<Box>();
            while(input != "end")
            {
                string[] infoArray = input.Split();

                string serialNumber = infoArray[0];
                string itemName = infoArray[1];
                int quantity = int.Parse(infoArray[2]);
                decimal itemPrice = decimal.Parse(infoArray[3]);

                Item item = new Item
                {
                    Name = itemName,
                    Price = itemPrice,

                };
                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    Quatity = quantity,
                    PriceForBox = quantity * itemPrice,
                };
                output.Add(box);

                input = Console.ReadLine();
            }
            //Print all the boxes ordered descending by price for a box

            foreach(Box box in output.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quatity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");

            }
        }
    }
    public class Box
    {
        public string SerialNumber { get; set; }   
        public Item Item { get; set; }
        
        public int Quatity { get; set; }
        public decimal PriceForBox { get; set; }


    }
    public class Item
    {
       
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}