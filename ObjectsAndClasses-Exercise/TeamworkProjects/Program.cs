using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

namespace TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //It's time for the teamwork projects and you are responsible for gathering the teams.
            //First, you will receive an integer – the count of the teams you will have to register.
            //You will be given a user and a team, separated with "-".
            //The user is the creator of the team.
            //For every newly created team you should print a message:
            //      "Team {teamName} has been created by {user}!".
            // Next, you will receive а user with a team, separated with "->",
            //which means that the user wants to join that team.
            //   Upon receiving the command:
            // "end of assignment", you should print every team,
            // ordered by the count of its members(descending) and then by name(ascending).
            // For each team, you have to print its members sorted by name(ascending).However,
            //there are several rules:
            //• If а user tries to create a team more than once, a message should be displayed:
            //     -"Team {teamName} was already created!"
            //• A creator of a team cannot create another team –
            //the following message should be thrown:
            //     -"{user} cannot create another team!"
            //• If а user tries to join a non-existent team
            //a message should be displayed:
            //     -"Team {teamName} does not exist!"
            //• A member of a team cannot join another team – the following message should be thrown:
            //     -"Member {user} cannot join team {team Name}!"
            //• In the end, teams with zero members(with only a creator) should disband
            //  and you have to print them ordered by name in ascending order.
            //• Every valid team should be printed ordered by name(ascending) in the following format:
            //  "{teamName}
            //  - { creator}
            //  -- { member}…

            List<Teams> listTeams = new List<Teams>();
            int countOfTeam = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeam; i++)
            {
                string[] teams = Console.ReadLine().Split("-");//user and a team, separated with "-".
                string creatorName = teams[0];
                string teamName = teams[1];
                
                Teams team = new Teams(teamName,creatorName);

                Teams findTeams = listTeams.Find(t => t.TeamName == teamName);
                Teams creatorFound = listTeams.Find(t => t.Creator == creatorName);

                if(findTeams != null)//If а user tries to create a team more than once, a message should be displayed:
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                    continue;
                }

                if(creatorFound != null)//A creator of a team cannot create another team
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }

                listTeams.Add(team);
                Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
            }

            string commnand ;
            while( (commnand = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = commnand.Split("->");
                string userName = arguments[0];
                string teamName = arguments[1];

                if(!listTeams.Any(t=>t.TeamName== teamName))
                { 
                //non-existent team
                
                    Console.WriteLine($"Team {teamName} does not exist!");

                        continue;
                }
                //member of a team cannot join another team
                if (listTeams.Any(t=> t.Creator == userName) || 
                    listTeams.Any(t=> t.Members.Contains(userName)))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    continue;
                }
                //add username-> members
                listTeams.Find(t => t.TeamName == teamName).Members.Add(userName);
            }
            List<Teams>leftTeams = listTeams.Where(t => t.Members.Count > 0).ToList();

            List<Teams> orderedTeams = leftTeams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();
            orderedTeams.ForEach(team => Console.WriteLine(team));

            List<Teams> disbandTeams = listTeams.Where(t => t.Members.Count == 0).ToList();
            Console.WriteLine("Teams to disband:");
            disbandTeams= disbandTeams.OrderBy(t => t.TeamName).ToList();
            disbandTeams.ForEach(team=> Console.WriteLine(team.TeamName));
        } 
        class Teams
        {
            public Teams(string name,string creator)//konstruktor
            {
                TeamName = name;
                Creator = creator;
                Members = new List<string>();
            }
            public string TeamName { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }
            public override string ToString()// Every valid team should be printed ordered by name(ascending) in the following format:
            {
                return $"{TeamName}\n" +// + nov red 
                       $"- {Creator}\n" +
                       $"{GetMemberString()}";
            }
            public string GetMemberString()//print every team,
            // ordered by the count of its members(descending) and then by name(ascending).
            {
                Members = Members
                    .OrderBy(name => name)
                    .ToList();//name(ascending).
                              //Когато трябва многоредов string, винаги ползвайте StringBuilder.
                              //Когато връщате StringBuilder, винаги слагайте накрая .TrimEnd(), за да няма празен ред в края.

                StringBuilder result = new StringBuilder();

                foreach (var member in Members)
                {
                    result.Append($"-- {member}");
                }
                return result.ToString().TrimEnd();
            }           
        }
    }
}