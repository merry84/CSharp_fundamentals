namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Create two classes: class Person and class Product. Each person should have a name, money and a bag of products.
            Each product should have a name and a cost. 
            Create a program, in which each command corresponds to a person buying a product.
            If the person can afford a product, add it to his bag. 
            If a person doesn't have enough money, print an appropriate message: "{Person} can't afford {Product}".
            On the first two lines, you are given all people and all products.
            After all purchases, print every person in the order of appearance and all products that they have bought,
            also in order of appearance.
            If nothing was bought, print the name of the person followed by "Nothing bought". 
            */
            string[] persons = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> personList = new List<Person>();
            for (int i = 0; i < persons.Length; i++)
            {
                string[] components = persons[i].Split("=");
                string nameOfPerson = components[0];
                int money = int.Parse(components[1]);
                personList.Add(new Person(nameOfPerson, money));
            }
            List<Product> productsList = new List<Product>();
            for (int i = 0; i < products.Length; i++)
            {
                string[] components = products[i].Split("=");
                string nameOfProduct = components[0];
                int cost = int.Parse(components[1]);
                productsList.Add(new Product(nameOfProduct, cost));
            }
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                string[] details = input.Split();
                string personName = details[0];
                string productName = details[1];

                UpdatePersonList(personList, productsList, personName, productName);
            }

            foreach (Person person in personList)
            {
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    List<string> product = person.BagOfProducts.Select(p => p.Name).ToList();
                    Console.WriteLine($"{person.Name} - {string.Join(", ", product)}");
                }
            }

        }

        static void UpdatePersonList(List<Person> personList, List<Product> productList, string nameOfPerson, string nameOfProduct)
        {
            Person currentPerson = personList.Find(p => p.Name == nameOfPerson);
            Product currentProduct = productList.Find(p => p.Name == nameOfProduct);
            // If a person doesn't have enough money, print an appropriate message: "{Person} can't afford {Product}".
            if (currentProduct.Cost > currentPerson.Money)
            {

                Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                return;
            }
            currentPerson.Money -= currentProduct.Cost;
            currentPerson.BagOfProducts.Add(currentProduct);
            Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
        }

    }
}
            
    class Person
    {
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
    }
    class Product
    {
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
