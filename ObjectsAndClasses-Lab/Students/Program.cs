using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define a class called Student, which will hold the following information about some students: 
            //•	first name
            //•	last name
            //•	age
            //•	home town
            //Input / Constraints
            //Read information about some students, until you receive the "end" command.
            //After that, you will receive a city name.
            //Output
            //Print the students who are from the given city in the following format:
            //"{firstName} {lastName} is {age} years old."

            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] argument = line.Split();
                string firstName = argument[0];
                string lastName = argument[1];
                int age = int.Parse(argument[2]);
                string town = argument[3];
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Town = town

                };
                students.Add(student);
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

    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
    }
}