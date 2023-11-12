using System.ComponentModel;

namespace SoftUniParking
{
    /*         
        Write a program, which validates a parking place for an online service.
        Users can register to park and unregister to leave.
        The program receives 2 commands:
        1.-> "register {username} {licensePlateNumber}":
           o The system only supports one car per user at the moment, so if a user tries to register another 
        license plate, using the same username, the system should print:
        "ERROR: already registered with plate number {licensePlateNumber}"
           o If the aforementioned checks passes successfully, the plate can be registered, so the system should 
        print:
        "{username} registered {licensePlateNumber} successfully"
        2.-> "unregister {username}":
           o If the user is not present in the database, the system should print:
        "ERROR: user {username} not found"
           o If the aforementioned check passes successfully, the system should print:
        "{username} unregistered successfully"
        After you execute all of the commands, 
        print all of the currently registered users and their license plates in the 
        format: 
        • "{username} => {licensePlateNumber}"
        Input
        • First line: n - number of commands – integer.
        • Next n lines: commands in one of the two possible formats:
        o Register: "register {username} {licensePlateNumber}"
        o Unregister: "unregister {username}"
        The input will always be valid and you do not need to check it explicitly
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> dic = new Dictionary<string, User>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string userName = input[1];

                if (command == "register")
                {
                    string licensePlateNumber = input[2];

                    User user = new User(userName, licensePlateNumber);

                    if (!dic.ContainsKey(userName))
                    {
                        // If the aforementioned checks passes successfully,the plate can be registered,so the system should print:
                        dic.Add(userName, user);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        //The system only supports one car per user at the moment, so if a user tries to register another 
                        //license plate, using the same username, the system should print:
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                }
                if (command == "unregister")
                {
                    if (!dic.ContainsKey(userName))//ако не съществува
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        dic.Remove(userName);// ако го има го махаме

                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (KeyValuePair<string, User> key in dic)
            {
                Console.WriteLine(key.Value);//key.value защото искаме и да принтира user -ТАМ Е тО СТРИНГА
            }
        }
    }

    internal class User
    {
        public User(string name, string licenseNumber)
        {
            Name = name;
            LicenseNumber = licenseNumber;
        }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} => {LicenseNumber}";
        }
    }
}