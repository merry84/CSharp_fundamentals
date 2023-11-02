namespace gsm
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                string[] tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                if (action == "Add")
                {
                    string phone = tokens[1];
                    if (!list.Contains(phone)) list.Add(phone);
                }
                else if (action == "Remove")
                {
                    string phone = tokens[1];
                    if (list.Contains(phone)) list.Remove(phone);
                }
                else if (action == "Bonus phone")
                {
                    string[] splitted = tokens[1].Split(":");
                    string oldOne = splitted[0];
                    string newOne = splitted[1];
                    int index = list.IndexOf(oldOne);
                    if (list.Contains(oldOne)) list.Insert(index + 1, newOne);
                }
                else if (action == "Last")
                {
                    string phone = tokens[1];
                    int index = list.IndexOf(phone);
                    if (list.Contains(phone))
                    {
                        list.Add(phone);
                        list.RemoveAt(index);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
    // 100 / 100


