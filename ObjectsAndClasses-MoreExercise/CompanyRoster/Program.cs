namespace CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
                /*
                 Define a class Employee that holds the following information: a name, a salary and a department. 

                 Your task is to write a program, which takes N lines of employees from the console, 

                 calculates the department with the highest average salary, 
                 and prints for each employee in that department their name and salary – sorted by salary in descending order. 
                 The salary should be rounded to two digits after the decimal separator.
                */
                List<Employee> employees = new List<Employee>();
                List<string> departments = new List<string>();
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string input = Console.ReadLine();
                    string[] line = input.Split();
                    string name = line[0];
                    double salary = double.Parse(line[1]);
                    string department = line[2];

                    Employee employee = new Employee(name, salary, department);
                    employees.Add(employee);
                    departments.Add(department);

                }
                //calculates the department with the highest average salary
                string highestSalaryDep = "";
                double highestAverageSalary = double.MinValue;

                foreach (string department in departments)
                {
                    double averageSalary = employees.Where(p => p.Department == department).Select(p => p.Salary).Average();
                    if (averageSalary > highestAverageSalary)
                    {
                        highestSalaryDep = department;
                        highestAverageSalary = averageSalary;
                    }
                }

                Console.WriteLine($"Highest Average Salary: {highestSalaryDep}");
               //prints for each employee in that department their name and salary – sorted by salary in descending order.
                foreach (Employee employee in employees.Where(d => d.Department == highestSalaryDep).OrderByDescending(s => s.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
         
        }
        
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }
    }

}

