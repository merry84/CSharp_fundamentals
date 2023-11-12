/*
 Create a program that keeps information about companies and their employees. 
You will be receiving a company name and an employee's id, until you receive the "End" command. Add each 
employee to the given company. Keep in mind that a company cannot have two employees with the same id.
When you finish reading the data, print the company's name and each employee's id in the following format:
{companyName}
-- {id1}
-- {id2}
-- {idN}
Input / Constraints
• Until you receive the "End" command, you will be receiving input in the format:
"{companyName} -> {employeeId}".
• The input always will be valid.
 */

namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> infoCompany = new Dictionary<string, Company>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" -> ");
                string nameCompany = command[0];
                string idEmployee = command[1];
                if (!infoCompany.ContainsKey(nameCompany))
                {
                    Company company = new Company(nameCompany);
                    infoCompany.Add(nameCompany, company);

                }

                infoCompany[nameCompany].AddId(idEmployee);
            }
            foreach (KeyValuePair<string,Company> keyValuePair in infoCompany)
            {
                Console.WriteLine(keyValuePair.Value);
            }

        }
    }
    class Company
    {
        public Company(string nameCompany)
        {
            NameCompany = nameCompany;
            IdEmployee = new List<string>();
        }
        public string NameCompany { get; set; }
        public List<string> IdEmployee { get; set; }
        public override string ToString()
        {
            string result = $"{NameCompany}\n";
            foreach (string id in IdEmployee)
            {
                result += $"-- {id}\n";
            }
            return result.Trim();
        }
        public void AddId(string id)// Keep in mind that a company cannot have two employees with the same id.
        {
            if (!IdEmployee.Contains(id))
            {
                IdEmployee.Add(id);
            }
        }

    }
}