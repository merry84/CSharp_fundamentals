using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Your first task is to determine if the given sequence of characters is a valid barcode or not.

               Each line must not contain anything else but a valid barcode. A barcode is valid when:

               · It is surrounded by a "@" followed by one or more "#"

               · It is at least 6 characters long (without the surrounding "@" or "#")

               · It starts with a capital letter

               · It contains only letters (lower and upper case) and digits

               · It ends with a capital letter

               Examples of valid barcodes: @#FreshFisH@#, @###Brea0D@###, @##Che46sE@##, @##Che46sE@###

               Examples of invalid barcodes: ##InvaliDiteM##, @InvalidIteM@, @#Invalid_IteM@#

               Next, you have to determine the product group of the item from the barcode. The product group is obtained by concatenating all the digits found in the barcode. If there are no digits present in the barcode, the default product group is "00".

               Examples:
               @#FreshFisH@# -> product group: 00

               @###Brea0D@### -> product group: 0

               @##Che4s6E@## -> product group: 46
                 Input
                On the first line, you will be given an integer n – the count of barcodes that you will be receiving next.
                On the following n lines, you will receive different strings.

                Output
               For each barcode that you process, you need to print a message.

               If the barcode is invalid:

               · "Invalid barcode"

              If the barcode is invalid:

               · "Product group: {product group}"
             */
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@#+(?<barcode>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})\@#+";
            RegexOptions options = RegexOptions.Multiline;
            for (int i = 0; i < n; i++)
            {

                string input = Console.ReadLine();
                GroupCollection groupCollection = Regex.Match(input, pattern, options).Groups;

                if (groupCollection.Count == 1)
                {
                    Console.WriteLine("Invalid barcode");//If the barcode is invalid:
                    continue;   
                }
                string barcode = groupCollection["barcode"].Value;
                string barcodeDigit = string.Empty;

                for (int index = 0; index < barcode.Length; index++)
                {
                    if (char.IsDigit(barcode[index]))
                    {
                        barcodeDigit += barcode[index];

                    }
                }

                if (barcodeDigit.Length == 0)
                {
                    Console.WriteLine("Product group: 00");//If there are no digits present in the barcode, the default product group is "00".
                }
                else
                {
                    Console.WriteLine($"Product group: {barcodeDigit}");//If the barcode is invalid:
                }
            }
        }
    }
}
