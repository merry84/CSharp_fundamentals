using System.Text;

namespace Course
{
    /*         
           Create a program that keeps the information about courses. Each course has a name and registered students.
    You will be receiving a course name and a student name, until you receive the command "end". Check if such a 
    course already exists, and if not, add the course. Register the user into the course. When you receive the command 
    "end", print the courses with their names and total registered users. For each contest print the registered users.
    Input
    • Until the "end" command is received, you will be receiving input in the format: "{courseName} : 
    {studentName}".
    • The product data is always delimited by " : ".
    Output
    • Print the information about each course in the following the format: 
    "{courseName}: {registeredStudents}"
    • Print the information about each student in the following the format:
    "-- {studentName}"
       */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Courses> course = new Dictionary<string,Courses>();
            string input;
            while ((input =Console.ReadLine())!= "end")
            {
                string[] command = input.Split(" : ");
                string courseName = command[0];
                string studentName = command[1];
                if (!course.ContainsKey(courseName))
                {
                    Courses courses = new Courses(courseName);
                    course.Add(courseName, courses);

                }
                course[courseName].StudentName.Add(studentName);

            }
            foreach( KeyValuePair<string,Courses> infoCouses in course )
            {
                Console.WriteLine(infoCouses.Value);
            }

        }
        

           
    }
    class Courses
    {
        public Courses(string name)
        {
            Name = name;
            StudentName = new List<string>();
        }
        public string Name { get; set; }
        public List<string>StudentName { get; set; }
        public override string ToString()
        {
            string result = $"{Name}: {StudentName.Count}\n";
            foreach (var student in StudentName)
            {
                result += $"-- {student}\n".ToString() ;
            }
            return result.Trim();
        }
    }
}


