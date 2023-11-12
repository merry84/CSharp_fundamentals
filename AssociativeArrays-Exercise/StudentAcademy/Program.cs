/*
 Create a program that keeps the information about students and their grades. 
You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade. 
Check if the student already exists and if not, add him. Keep track of all grades for each student.
When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
Print the students and their average grade in the following format:
"{name} –> {averageGrade}"
Format the average grade to the 2nd decimal place
  */

using System.Xml.Linq;

namespace StudentAcademy
{   
       
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Students> students = new Dictionary<string,Students>();
            int countOfStudets = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudets; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName,new Students(studentName));
                }
                students[studentName].Grade.Add(grade);

            }
            //When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
            IEnumerable<KeyValuePair<string, Students>> filterGrade = students.Where(grade => grade.Value.Grade.Average() >= 4.50);
            foreach (KeyValuePair<string,Students> keyValuePair in filterGrade)
            {
                Console.WriteLine(keyValuePair.Value);
            }
            
        }
    }
    class Students
    {
        public Students(string name)
        {
            Name = name;
            Grade = new List<double>();
        }
        public string Name { get; set; }
        public List<double> Grade { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Grade.Average():f2}";
        }
    }
}