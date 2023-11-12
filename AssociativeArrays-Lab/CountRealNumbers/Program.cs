namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Read a list of integers and print them in ascending order, along with their number of occurrences. 
           */

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();
            foreach (int number in numbers)
            {

                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);

                }
            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}