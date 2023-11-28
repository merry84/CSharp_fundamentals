using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             You will receive several messages, which are encrypted, using the legendary star enigma. You should decrypt the messages, following these rules:
               To properly decrypt a message, you should count all the letters [s, t, a, r] – case insensitive and remove the count from the current ASCII value of each symbol of the encrypted message.
               After decryption:
               •	Each message should have a planet name, population, attack type ('A' as an attack or 'D'  as destruction), and soldier count.
               •	The planet name starts after '@' and contains only letters from the Latin alphabet. 
               •	The planet population starts after ':' and is an Integer.
               •	The attack type may be "A"(attack) or "D"(destruction) and must be surrounded by "!" (exclamation mark).
               •	The soldier count starts after "->" and should be an Integer.
               The order in the message should be: planet name -> planet population -> attack type -> soldier count. Each part can be separated from the others by any character except '@', '-', '!', ':' and '>'.
               Input / Constraints
               •	The first line holds n – the number of messages– integer in the range [1…100].
               •	On the next n lines, you will be receiving encrypted messages.
               Output
               After decrypting all messages, you should print the decrypted information in the following format:
               First print the attacked planets, then the destroyed planets.
               "Attacked planets: {attackedPlanetsCount}"
               "-> {planetName}"
               "Destroyed planets: {destroyedPlanetsCount}"
               "-> {planetName}"
               The planets should be ordered by name alphabetically.
               
             */
            List<Messages> messages = new List<Messages>(); //????

            string starPattern = @"[SsTtAaRr]";
            // @"@(?<Planet>[A-Za-z]+)[^\@\-\!\:\>]*:(?<Population>\d+)[^\@\-\!\:\>]*\!(?<AtackType>A|D)\![^\@\-\!\:\>]*\-\>(?<SoldierCount>\d+)";
            string msgPattern = @"@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*(?<soldiers>\d+)";
            //@"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptMsg = Console.ReadLine();
                int decryptKey = Regex.Matches(encryptMsg, starPattern).Count;

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < encryptMsg.Length; j++)
                {
                    sb.Append((char)encryptMsg[j]- decryptKey);
                }
                string encryptMessages = sb.ToString();

                var match = Regex.Match(encryptMessages, msgPattern);
                if (Regex.IsMatch(encryptMessages,msgPattern ) == false)
                {
                    continue;
                }
                else
                {
                    string name = match.Groups["planet"].Value;
                    uint population = uint.Parse( match.Groups["population"].Value);
                    string attackType = match.Groups["type"].Value;
                    uint soldierCount = uint.Parse(match.Groups["soldiers"].Value);

                    Messages message = new Messages(name,population,attackType,soldierCount);
                    messages.Add(message);

                }
            }

            var planet = messages.Where(m => m.AttackType == "A")
                .OrderBy(m => m.Name)
                .ToList();

            Console.WriteLine($"Attacked planets: {planet.Count}");
            planet.ForEach(m=>Console.WriteLine($"-> {m.Name}"));

            planet = messages.Where(m=>m.AttackType == "D")
                .OrderBy(m=> m.Name)
                .ToList();

            Console.WriteLine($"Destroyed planets: {planet.Count}");
            planet.ForEach(m=>Console.WriteLine($"-> {m.Name}"));
        }
        
    }
    class Messages
    {
        public Messages()
        {

        }


        public Messages(string name, uint population, string attackType, uint soldierCount)
        {
            Name = name;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }

        public string Name { get; set; }
        public uint Population { get; set; }
        public string AttackType { get; set; }
        public uint SoldierCount { get; set; }
    }
}
