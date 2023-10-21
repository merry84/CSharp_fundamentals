namespace ShoppingList
{/*
Tomatoes!Potatoes!Bread
Unnecessary Milk
Urgent Tomatoes
Go Shopping!
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive an initial list with groceries separated by an exclamation mark "!".
            //After that, you will be receiving 4 types of commands until you receive "Go Shopping!".
            //  •"Urgent {item}" - add the item at the start of the list.  If the item already exists, skip this command.
            //  •"Unnecessary {item}" - remove the item with the given name, only if it exists in the list.
            // Otherwise, skip this command.
            //  •"Correct {oldItem} {newItem}" - if the item with the given old name exists,
            // change its name with the new one.Otherwise, skip this command.
            //  •"Rearrange {item}" - if the grocery exists in the list,
            // remove it from its current position and add it at the end of the list.
            // Otherwise, skip this command.
            //Constraints
            //  •There won't be any duplicate items in the initial list.
            //Output
            //  •Print the list with all the groceries, joined by ", ":
            //"{firstGrocery}, {secondGrocery}, … {nthGrocery}"

            List<string>products = Console.ReadLine()
                .Split("!")
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] inputCommand = input.Split().ToArray();
                string command = inputCommand[0];
                if (command == "Urgent")
                {
                    string item = inputCommand[1];
                    if (!products.Contains(item))
                    {
                        products.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    string item = inputCommand[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string item = inputCommand[1];

                    if (products.Contains(item))
                    {
                        string newItem = inputCommand[2];
                        int newItemIndex = products.IndexOf(item);
                        products.Remove(item);
                        products.Insert(newItemIndex, newItem);
                    }
                }
                else if (command == "Rearrange")
                {
                    string item = inputCommand[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }

                }

                
            }

            Console.WriteLine(string.Join(", ", products));

                
            
        }
    }
}