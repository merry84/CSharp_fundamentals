namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             You will be given a sequence of strings, each on a new line.
            Every odd line on the console is representing a resource 
            (e.g. Gold, Silver, Copper and so on) and every even - quantity. 
            Your task is to collect the resources and print them 
            each on a new line.
            Print the resources and their quantities in the following format:
            "{resource} –> {quantity}"
            The quantities will be in the range [1… 2 000 000 000]
             */
            Dictionary<string,uint> aMinerTask = new Dictionary<string,uint>();
            string input = string.Empty;
            while ((input= Console.ReadLine()) != "stop")
            {
                string resource = input;
                if(!aMinerTask.ContainsKey(resource))
                {
                    aMinerTask.Add(resource, 0);
                }
                
                var quantity = uint.Parse(Console.ReadLine());
                
                aMinerTask[resource] += quantity;
                
            }
            foreach(KeyValuePair<string,uint> keyValuePair in aMinerTask)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }

        }
    }
}