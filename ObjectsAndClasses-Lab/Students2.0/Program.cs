namespace Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use the class from the previous problem.
            //If you receive a student, which already exists (first name and last name should be unique) overwrite the information.

            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] argument = line.Split();
                string firstName = argument[0];
                string lastName = argument[1];
                int age = int.Parse(argument[2]);
                string town = argument[3];

                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                if (student != null)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Town = town;
                }
                else
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Town = town
                    });
                }
                line = Console.ReadLine();
            }

            string filterTown = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Town == filterTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }

            }
        }


class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }

        /*
        Anthony Taylor 15 Chicago
        David Anderson 16 Washington
        Jack Lewis 14 Chicago
        David Lee 14 Chicago
        Jack Lewis 26 Chicago
        David Lee 18 Chicago
        end
        Chicago
        */
    }
}
