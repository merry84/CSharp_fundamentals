namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a program that counts all characters in a string, except for space (' '). 
             Print all the occurrences in the following format:
              "{char} -> {occurrences}"
            */
            //dictionary<char, int> dic = new dictionary<char, int>();
            //string text = Console.readline();
            //for (int i = 0; i < text.length; i++)
            //{
            //    var currendchar = text[i];
            //    if(currendchar == ' ')
            //    {
            //        continue;
            //    }
            //    if (!dic.containskey(currendchar))
            //    {
            //        dic.add(currendchar, 0);
            //    }
            //    dic[currendchar]++;
            //}

            //foreach (KeyValuePair<char, int> kvp in dic)
            //{
            //    Console.writeline($"{kvp.key} -> {kvp.value}");
            //}
            string input = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char character in input.Where(c => c != ' '))
            {
                if (!chars.ContainsKey(character))
                {
                    chars.Add(character, 0);
                }

                chars[character]++;
            }

            foreach (var kvp in chars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}