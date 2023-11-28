using System.Text;
using System.Text.RegularExpressions;


namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program that processes information about a race. On the first line, you will be given a list of participants separated by ", ". On the next few lines, until you receive a line "end of the race", 
               you will be given some info which will be some alphanumeric characters. 
               In between them, you could have some extra characters which you should ignore. 
               For example: "G!32e%o7r#32g$235@!2e". 
               The letters are the name of the person and the sum of the digits is the distance he ran.
               So here we have George who ran 29 km. Store the information about the person
               only if the list of racers contains the name of the person. 
               If you receive the same person more than once, just add the distance to his old distance. 
               At the end print the top 3 racers in the format:
               "1st place: {first racer}
               2nd place: {second racer}
               3rd place: {third racer}"
               
             */
            List<string> nameOfParticipants = Console.ReadLine().Split(", ").ToList();

            List<Participant> participants = new List<Participant>();

            foreach (string name in nameOfParticipants)
            {
                Participant p = new Participant(name);
                participants.Add(p);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string pattern = @"[A-Za-z]";
                StringBuilder nameBuilder = new StringBuilder();

                foreach (Match match in Regex.Matches(input, pattern))
                {
                    nameBuilder.Append(match.Value);
                }

                string participantName = nameBuilder.ToString();

                uint distance = 0;
                string digitPattern = @"\d";

                foreach (Match match in Regex.Matches(input, digitPattern))
                {
                    distance += uint.Parse(match.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(x => x.Name == participantName);
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }
            }

            List<Participant> firstThreeParticipants = participants
                .OrderByDescending(d => d.Distance)
                .Take(3)
                .ToList();

            Console.WriteLine($"1st place: {firstThreeParticipants[0].Name}");
            Console.WriteLine($"2nd place: {firstThreeParticipants[1].Name}");
            Console.WriteLine($"3rd place: {firstThreeParticipants[2].Name}");
        }
    }

    class Participant
    {
        public string Name { get; set; }
        public uint Distance { get; set; }

        public Participant(string name)
        {
            Name = name;
        }
    }
}
