namespace P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Until the "Sail" command is given, you will be receiving:

               · You and your crew have targeted cities, with their population and gold, separated by "||".

               · If you receive a city that has already been received, you have to increase the population and gold with the given values.

               After the "Sail" command, you will start receiving lines of text representing events until the "End" command is given.

               Events will be in the following format:

               ->· "Plunder=>{town}=>{people}=>{gold}"

               o You have successfully attacked and plundered the town, killing the given number of people and stealing the respective amount of gold.

               o For every town you attack print this message: "{town} plundered! {gold} gold stolen, {people} citizens killed."

               o If any of those two values (population or gold) reaches zero, the town is disbanded.

               § You need to remove it from your collection of targeted cities and print the following message: "{town} has been wiped off the map!"

               o There will be no case of receiving more people or gold than there is in the city.

               -> · "Prosper=>{town}=>{gold}"

               o There has been dramatic economic growth in the given city, increasing its treasury by the given amount of gold.

               o The gold amount can be a negative number, so be careful. If a negative amount of gold is given, print: "Gold added cannot be a negative number!" and ignore the command.

               o If the given gold is a valid amount, increase the town's gold reserves by the respective amount and print the following message:

               "{gold added} gold added to the city treasury. {town} now has {total gold} gold."

               Input

               · On the first lines, until the "Sail" command, you will be receiving strings representing the cities with their gold and population, separated by "||"

               · On the following lines, until the "End" command, you will be receiving strings representing the actions described above, separated by "=>"

               Output

               · After receiving the "End" command, if there are any existing settlements on your list of targets, you need to print all of them, in the following format:

               "Ahoy, Captain! There are {count} wealthy settlements to go to:

               {town1} -> Population: {people} citizens, Gold: {gold} kg

               {town2} -> Population: {people} citizens, Gold: {gold} kg

               …

               {town…n} -> Population: {people} citizens, Gold: {gold} kg"

               · If there are no settlements left to plunder, print:

               "Ahoy, Captain! All targets have been plundered and destroyed!"

               Constraints

               · The initial population and gold of the settlements will be valid 32-bit integers, never negative, or exceed the respective limits.

               · The town names in the events will always be valid towns that should be on your list.
             */
            List<City> cityList = new List<City>();
            string input;

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] tokens = input.Split("||");
                string cityName = tokens[0];
                double population = double.Parse(tokens[1]);
                double gold = double.Parse(tokens[2]);
                //If you receive a city that has already been received, you have to increase the population and gold with the given values.
                City city = cityList.FirstOrDefault(x => x.Name == cityName);
                if (city != null)
                {
                    city.Population += population;
                    city.Gold += gold;
                    continue;
                }

                cityList.Add(new City
                {
                    Name = cityName,
                    Population = population,
                    Gold = gold
                });
            }

            input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split("=>").ToArray();
                string command = inputTokens[0];
                string cityName = inputTokens[1];
                City city = cityList.FirstOrDefault(x=> x.Name == cityName);
                if (command == "Plunder")// "Plunder=>{town}=>{people}=>{gold}"
                {
                    double population = double.Parse(inputTokens[2]);
                    double gold = double.Parse(inputTokens[3]);
                    city.Population -= population;
                    city.Gold -= gold;
                    Console.WriteLine($"{city.Name} plundered! {gold} gold stolen, {population} citizens killed.");
                    //If any of those two values (population or gold) reaches zero, the town is disbanded.
                    // 
                    // § You need to remove it from your collection of targeted cities
                    if (city.Gold <= 0 || city.Population <= 0)
                    {
                        Console.WriteLine($"{city.Name} has been wiped off the map!");
                        cityList.Remove(city);
                    }
                }
                else if (command == "Prosper")//"Prosper=>{town}=>{gold}"
                {
                    double gold = double.Parse(inputTokens[2]);
                    if (gold < 0)//he gold amount can be a negative number, so be careful. If a negative amount of gold is given,
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    city.Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");
                }
            }

            if (cityList.Count == 0)//If there are no settlements left to plunder, print:
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {cityList.Count} wealthy settlements to go to:");
            foreach (var city in cityList)
            {
                Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
            }

        }
    }

    class City
    {
        public string Name { get; set; }

        public double Population { get; set; }
        public double Gold { get; set; }
    }
}
