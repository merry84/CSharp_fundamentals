namespace Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> judge = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string,int>user = new Dictionary<string,int>();
            string input;
            while ((input= Console.ReadLine()) != "no more time")
            {
                string[] argument = input.Split(" -> ");
                string userName = argument[0];
                string contest = argument[1];
                int points = int.Parse(argument[2]);
                if (!judge.ContainsKey(userName))
                {
                    judge.Add(contest,new Dictionary<string, int>());
                    judge[contest][userName] = points;
                }
                else
                {
                    if (!judge[contest].ContainsKey(userName))
                    {
                        judge[contest][ userName ] = points;

                    }
                    else
                    {
                        if (judge[contest][userName] < points)
                        {
                            judge[contest][userName] = points;
                        }
                    }
                }
            }

            foreach (var contest in judge)
            {
                foreach (var name in contest.Value)
                {
                    if (!user.ContainsKey(name.Key))
                    {
                        user.Add(name.Key, name.Value);
                    }
                    else
                    {
                        user[name.Key] = user[name.Key] + name.Value;
                    }
                }
            }

            int count = 0;
            foreach (var name in user
                         .OrderByDescending(u => u.Value)
                         .ThenBy(u => u.Key))
            {

            }
        }
    }
}
