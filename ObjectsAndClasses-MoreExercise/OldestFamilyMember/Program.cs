namespace OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            {
                /*
                Create two classes – Family and Person. 
                The Person class should have Name and Age properties. 
                The Family class should have a list of people,
                a method for adding members (void AddMember(Person member)),
                and a method, which returns the oldest family member (Person GetOldestMember()). 
                Write a program that reads the names and ages of N people and adds them to the family. 
                Then print the name and age of the oldest member.
                */
                int n = int.Parse(Console.ReadLine());

                Family family = new Family();

                for (int i = 0; i < n; i++)
                {

                    family.AddMember(Console.ReadLine().Split());
                }
                Person old = family.GetOldestMember();
                Console.WriteLine($"{old.Name} {old.Age}");

            }

        }

    }
    class Family
    {
        public List<Person> People { get; set; } = new List<Person>();
        //method for adding members (void AddMember(Person member))
        public void AddMember(string[] members)
        {
            Person newMember = new Person(members[0], int.Parse(members[1]));
            People.Add(newMember);
        }
        //which returns the oldest family member (Person GetOldestMember())
        public Person GetOldestMember()
        {
            {
                Person personOld = People.OrderByDescending(a => a.Age).FirstOrDefault();
                return personOld;
            }
        }


    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public string Name { get; set; }

        public int Age { get; set; }
    }
}

