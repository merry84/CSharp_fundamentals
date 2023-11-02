namespace secondProblem
{/*
SamsungA50, MotorolaG5, IphoneSE
Add - Iphone10
Remove - IphoneSE
End
  
HuaweiP20, XiaomiNote
Remove - Samsung
Bonus phone - XiaomiNote:Iphone5
End
  
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phone = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = default;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = inputTokens[0];
                if (command == "Add")
                {
                    string model = inputTokens[1];
                    
                    if (!phone.Contains(model))
                    {
                        phone.Add(model);

                    }
                }
                else if (command == "Remove")
                {
                    string model = inputTokens[1];
                    if (phone.Contains(model))
                    {
                        phone.Remove(model);
                    }
                }
                else if (command == "Bonus phone")
                {
                    string[] splited = inputTokens[1].Split(":");
                    string model = splited[0];
                    string newModel = splited[1];
                    int index = phone.IndexOf(model);
                    if (phone.Contains(model))
                    {
                        phone.Insert(index + 1, newModel);
                    }
                }
                else if (command == "Last")
                {
                    string model = inputTokens[1];
                    int index = phone.IndexOf(model);
                    if (phone.Contains(model))
                    {
                        phone.Add(model);
                        phone.RemoveAt(index);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phone));

        }



    }
}