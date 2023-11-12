namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a program that extracts all elements from a given sequence of words
            that are present in it an odd number of times (case-insensitive).
            • Words are given on a single line, space-separated.
            • Print the result elements in lowercase, in their order of appearance
             */
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordToLower = word.ToLower();
                if (counts.ContainsKey(wordToLower))
                {
                    counts[wordToLower]++;
                }
                else
                {
                    counts.Add(wordToLower, 1);

                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");

                }
            }
        }
    }
}