using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that sorts some students by their grade in descending order.
            //Each student should have:
            //• First name(string)
            //• Last name(string)
            //• Grade(a floating - point number)
            //Input
            //• On the first line, you will receive a number n - the count of all students.
            //• On the next n lines, you will be receiving information about these students in the following format:
            //"{first name} {second name} {grade}".

            //Output
            //• Print out the information about each student in the following format: "{first name} {second name}: {grade}".

            int countOfStudent = int.Parse(Console.ReadLine());
            List<Students> students1 = new List<Students>();
            for (int i = 0; i < countOfStudent; i++)
            {
                Students students = new Students();
                string[] currStudent = Console.ReadLine().Split();
                students.FirstName = currStudent[0];
                students.LastName = currStudent[1];
                students.Grade = double.Parse(currStudent[2]);
                students1.Add(students);
            }
            students1 = students1.OrderByDescending(student => student.Grade).ToList();//sorts some students by their grade in descending order.
            Console.WriteLine(string.Join("\n",students1));
           
        }
        class Students
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }

        }

    }
}