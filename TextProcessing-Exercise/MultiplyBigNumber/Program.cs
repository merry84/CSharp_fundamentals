namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             You are given two lines – the first one can be a really big number (0 to 1050). 
            The second one will be a single-digit 
            number (0 to 9). Your task is to display the product of these numbers.
            Note: do not use the BigInteger class.
             */
            string firstNumber = Console.ReadLine();
            string multyPlyNumbers = Console.ReadLine();
            //ulong multyPlySum= firstNumber * secondNumber;
            Console.WriteLine(MultiPlySum(firstNumber,multyPlyNumbers));

        }
        static string MultiPlySum( string firstNumber, string multyPlyNumbers)
        {
            if(firstNumber == "0" || multyPlyNumbers == "0")
            {
                return "0";
            }
            int carry = 0;//число наум
            int multyplyNumber = int.Parse(multyPlyNumbers);
            char[] chars = new char[firstNumber.Length + 1];// + 1 защото масива започва от нула заради числото наум
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(firstNumber[i].ToString());//всяка цифра от голямото число
                int product = digit * multyplyNumber + carry;
                chars[i+1] = (char)(product % 10 + '0');// тук е [i +1] защото в цикъла е /firstNumber.Length - 1/= за единици
                carry = product / 10;//наум десетиците
            }
            if(carry > 0 )
            {
                chars[0] = (char)(carry+ '0');// на 0 индекс записваме числото наум
            }
            return new string(chars).TrimStart('\0');// Премахваме 0, ако стои в началото на резултата
        }

    }
}
