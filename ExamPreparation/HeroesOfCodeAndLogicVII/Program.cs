using System.IO;
using System.Text;

namespace HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static List<Hero> party = new List<Hero>();
        static void Main(string[] args)
        {
            /*
              On the first line of the standard input, you will receive an integer n –
            the number of heroes that you can choose for your party.
           On the next n lines,the heroes themselves will follow with their hit points and mana points
           separated by a single space in the following format: "{hero name} {HP} {MP}"

               - HP stands for hit points and MP for mana points
               - a hero can have a maximum of 100 HP and 200 MP

                After you have successfully picked your heroes, you can start playing the game.
               You will be receiving different commands, each on a new line, separated by " – ", until the "End" command is given.
               There are several actions that the heroes can perform:

              -> "CastSpell – {hero name} – {MP needed} – {spell name}"
               · If the hero has the required MP, he casts the spell, thus reducing his MP. Print this message:
                     o "{hero name} has successfully cast {spell name} and now has {mana points left} MP!"
               · If the hero is unable to cast the spell print:
                     o "{hero name} does not have enough MP to cast {spell name}!"
             -> "TakeDamage – {hero name} – {damage} – {attacker}"
               · Reduce the hero HP by the given damage amount. If the hero is still alive (his HP is greater than 0) print:
                    o "{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"
               · If the hero has died, remove him from your party and print:
                    o "{hero name} has been killed by {attacker}!"
             ->  "Recharge – {hero name} – {amount}"
               · The hero increases his MP. If it brings the MP of the hero above the maximum value (200), MP is increased to 200.
                 (the MP can't go over the maximum value).
               · Print the following message:
               o "{hero name} recharged for {amount recovered} MP!"
             ->  "Heal – {hero name} – {amount}"
               · The hero increases his HP. If a command is given that would bring the HP of the hero above the maximum value (100), HP is increased to 100 (the HP can't go over the maximum value).
               · Print the following message:
                     o "{hero name} healed for {amount recovered} HP!"
               Input
               · On the first line of the standard input, you will receive an integer n.
               · On the following n lines, the heroes themselves will follow with their hit points and mana points separated by a space in the following format
               · You will be receiving different commands, each on a new line, separated by " – ", until the "End" command is given.
               Output
               · Print all members of your party who are still alive in the following format (their HP/MP need to be indented 2 spaces):
               "{hero name}
               HP: {current HP}
               MP: {current MP}"
               Constraints
               · The starting HP/MP of the heroes will be valid, 32-bit integers will never be negative or exceed the respective limits.
               · The HP/MP amounts in the commands will never be negative.
               · The hero names in the commands will always be valid members of your party. No need to check that explicitly.          
                            */
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Hero heros = new Hero(input[0], int.Parse(input[1]), int.Parse(input[2]));
                party.Add(heros);

            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" - ");

                if (arguments[0] == "CastSpell")
                {
                    CastSpell(arguments[1], int.Parse(arguments[2]), arguments[3]);
                }
                else if (arguments[0] == "TakeDamage")
                {
                    TakeDamage(arguments[1], int.Parse(arguments[2]), arguments[3]);
                }
                else if (arguments[0] == "Recharge")
                {
                    Recharge(arguments[1], int.Parse(arguments[2]));
                }
                else if (arguments[0] == "Heal")
                {
                    Heal(arguments[1], int.Parse(arguments[2]));
                }
            }
            party.ForEach(h => Console.Write(h));
        }

        private static void Heal(string heroName, int amount)
        {
            Hero foundHero = party.FirstOrDefault(x => x.Name == heroName);
            if (foundHero != null)
            {
                int recovered = foundHero.Heal(amount);
                Console.WriteLine($"{foundHero.Name} healed for {recovered} HP!");
            }
        }

        private static void Recharge(string heroName, int amount)
        {
            Hero foundHero = party.FirstOrDefault(x => x.Name == heroName);
            if (foundHero != null)
            {
                int recovered = foundHero.Recharge(amount);
                Console.WriteLine($"{foundHero.Name} recharged for {recovered} MP!");
            }
        }

        static void CastSpell(string name, int neededmp, string spellName)
        {
            Hero foundHero = party.FirstOrDefault(x => x.Name == name);

            if (foundHero != null && foundHero.Mp >= neededmp)
            {
                foundHero.Mp -= neededmp;
                Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.Mp} MP!");
            }
            else { Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spellName}!"); }
        }
        static void TakeDamage(string heroName, int damage, string attacker)
        {
            Hero foundHero = party.FirstOrDefault(x => x.Name == heroName);

            if (foundHero != null)
            {
                foundHero.Hp -= damage;

            }
            if (foundHero.Hp > 0)
            {
                Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attacker} and now has {foundHero.Hp} HP left!");

            }
            else
            {
                party.Remove(foundHero);
                Console.WriteLine($"{foundHero.Name} has been killed by {attacker}!");
            }
        }


    }
    class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            Heal(hp);
            Recharge(mp);

        }
        public int Heal(int hp)
        {
            int recoveredHp = Math.Min(hp, 100 - Hp);
            Hp += recoveredHp;
            return recoveredHp;

        }
        public int Recharge(int mp)
        {
            int recoverdMp = Math.Min(mp, 200 - Mp);
            Mp += recoverdMp;
            return recoverdMp;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Name);
            stringBuilder.AppendLine($"  HP: {Hp}");
            stringBuilder.AppendLine($"  MP: {Mp}");
            return stringBuilder.ToString();
        }
        public string Name { get; set; }

        public int Hp { get; set; }

        public int Mp { get; set; }
    }
}


