namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *You will receive some lines of input in the format
             "{contest}:{password for contest}", until you receive "end of contests".
              Save that data, because you will need it later. After that, you will receive another type of input in the 
               format "{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". 
               Here is what you need to do:
               • Check if the contest is valid (if you received it in the first type of input).
               • Check if the password is correct for the given contest.
               • Save the user with the contest they take part in (a user can take part in many contests) 
            and the points the user has in the given contest.
            If you receive the same contest and the same user, update the points, only if 
               the new ones are more than the older ones.
               In the end, you have to print the info for the user with the most points in the format "Best candidate is 
               {user} with total {total points} points.". After that print all students ordered by their names. For 
               each user print each contest with the points in descending order. See the examples.
               Input
               • Strings in format "{contest}:{password for contest}" until the "end of contests" command. 
               There will be no case with two equal contests.
               • Strings in format "{contest}=>{password}=>{username}=>{points}", until the "end of 
               submissions" command.
               • There will be no case with 2 or more users with the same total points!
               Output
               • On the first line, print the best user in format "Best candidate is {user} with total {total 
               points} points.". 
               • Then print all students, ordered as mentioned above, in format:
               "{user1 name}"
               "# {contest1} -> {points}"
               "# {contest2} -> {points}"
               Constraints
               • The strings may contain any ASCII character except ':', ' =', '>'.
               • The numbers will be in range [0…10000].
               • Second input is always valid.
             */
            Dictionary<string,string>data = new Dictionary<string,string>();

            string lines;
            while ((lines= Console.ReadLine()) != "end of contests")
            {
                string[] arguments = lines.Split(":");
                string contest = arguments[0];
                string password = arguments[1];

                if (!data.ContainsKey(contest))
                {
                    data.Add(contest, password);

                }
            }

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] component = input.Split("=>");
                string contest = component[0];
                string password = component[1];
                string userName = component[2];
                int points = int.Parse(component[3]);

                //• Check if the contest is valid (if you received it in the first type of input).
                // • Check if the password is correct for the given contest.
                if (data.ContainsKey(contest) && data[contest] == password)
                {
                    if (!students.ContainsKey(userName))
                    {
                        students.Add(userName,new Dictionary<string,int >());
                        students[userName].Add(contest,points);
                    }
                    else// If you receive the same contest and the same user, update the points, only if 
                        // the new ones are more than the older ones.
                    {
                        if (!students[userName].ContainsKey(contest))
                        {
                            students[userName].Add(contest, points);
                        }
                        else
                        {
                            if (students[userName][contest] < points)
                            {
                                students[userName][contest] = points;
                            }
                        }
                    }

                    component = input.Split("=>");
                }
            }

            string bestStudent = "";
            int bestPoints = 0;
            foreach (var name in students)
            {
                int point = 0;
                foreach (var course in name.Value)
                {
                    point += course.Value;
                }

                if (point > bestPoints)
                {
                    bestStudent = name.Key;
                    bestPoints = point;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");

            students = students.OrderBy (k => k.Key)
                .ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine("Ranking: ");
            foreach (var name in students)
            {
                Console.WriteLine(name.Key);
                foreach (var course in name.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"#  {course.Key} -> {course.Value}");
                }
            }
        }
    }
}
