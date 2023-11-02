namespace MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You have initial health 100 and initial bitcoins 0.
            // You will be given a string representing the dungeon's rooms.
            // Each room is separated with ' | ' (vertical bar): "room1|room2|room3…"
            //    Each room contains a command and a number, separated by space.
            // The command can be:
            //  •"potion"
            //        o You are healed with the number in the second part.But your health cannot exceed your initial health(100).
            //        o First print: "You healed for {amount} hp."
            //        o After that, print your current health: "Current health: {health} hp."
            //  •"chest"
            //        o You've found some bitcoins, the number in the second part.
            //        o Print: "You found {amount} bitcoins."

            //  •In any other case, you are facing a monster, which you will fight.
            //    The second part of the room contains the attack of the monster.
            //    You should remove the monster's attack from your health. 
            //        o If you are not dead(health <= 0), you've slain the monster, and you should print: "You slayed {monster}."
            //        o If you've died, print "You died! Killed by {monster}." and your quest is over.
            //           Print the best room you've managed to reach: "Best room: {room}"

            //    If you managed to go through all the rooms in the dungeon, print on the following three lines:
            //    "You've made it!
            //    Bitcoins: { bitcoins}
            //    Health: { healt}h
            //    "
            //    Input / Constraints
            //    You receive a string representing the dungeon's rooms, separated with ' | ' (vertical bar): "room1|room2|room3…".
            //        Output
            //    Print the corresponding messages described above.

            List<string> rooms = Console.ReadLine()
                .Split("|")
                .ToList();
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Count; i++)
            {
                string[] inputTokens = rooms[i].Split().ToArray();

                if (inputTokens[0] == "potion")
                {
                    int amount = int.Parse(inputTokens[1]);
                    int currentHealt = health;
                    health = amount + currentHealt;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    if (health < 100)
                    {
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    else if (health == 100)
                    {
                        Console.WriteLine($"You healed for {100 - currentHealt} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                }
                else if (inputTokens[0] == "chest")
                {
                    int amountBitcoins = int.Parse(inputTokens[1]);
                    bitcoins = amountBitcoins + bitcoins;

                    Console.WriteLine($"You found {amountBitcoins} bitcoins.");
                }
                else
                {
                    string monster = inputTokens[0];
                    int attackMonster = int.Parse(inputTokens[1]);
                    health = health - attackMonster;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else if (health <= 0)
                    {

                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");



        }
    }
}