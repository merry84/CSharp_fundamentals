using System.Xml.Linq;

namespace OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             You will receive an unknown number of lines. On each line you will receive an array with 3 elements:
            • The first element is a string - the name of the person
            • The second element a string - the ID of the person
            • The third element is an integer - the age of the person
            If you get a person whose ID you have already received before, update the name and age for that ID with that of
            the new person. 
            When you receive the command "End", print all of the people, ordered by age. 
            */
            List<ID> iD = new List<ID>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] elements = input.Split();
                string name = elements[0];
                string iDValue = elements[1];
                int age = int.Parse(elements[2]);

                ID FoundPerson = iD.FirstOrDefault(x => x.IdValue == iDValue);
                if (FoundPerson != null)
                {
                    FoundPerson.Age = age;
                    FoundPerson.Name = name;
                }

                iD.Add(new ID(name, iDValue, age));

            }
            List<ID> orderBy = iD.OrderBy(x => x.Age).ToList();
            foreach (ID id in orderBy)
            {
                Console.WriteLine(id);

            }
        }
    }
    class ID
    {
        public ID(string name, string idValue, int age)
        {
            Name = name;
            IdValue = idValue;
            Age = age;
        }
        public string Name { get; set; }
        public string IdValue { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {IdValue} is {Age} years old.";
        }
    }

}








