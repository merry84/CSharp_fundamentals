namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program to calculate the winner of a car race.
            // You will receive an array of numbers.
            // Each element of the array represents the time needed to pass through that step (the index).
            // There are going to be two cars.
            // One of them starts from the left side and the other one starts from the right side.
            // The middle index of the array is the finish line. The number of elements in the array will always be odd.
            // Calculate the total time for each racer to reach the finish,
            // which is the middle of the array, and print the winner with his total time (the racer with less time).
            // If you have a zero in the array, you have to reduce the time of the racer that reached
            // it by 20% (from his current time).

            //Print the result in the following format "The winner is {left/right} with total time: {total time}".

            List<double> carRace = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            double sumFirstCar = SumFirstCar(carRace);
            double sumSecondCar = SumSecondCar(carRace);
            if (sumFirstCar > sumSecondCar)
            {
                Console.WriteLine($"The winner is right with total time: {Math.Floor(sumSecondCar)}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {sumFirstCar:f1}");
            }
            
        }
        static double SumFirstCar(List<double> carRace)
        {
            double sum = 0;
            for (int i = 0; i < carRace.Count / 2; i++)
            {
                double currentNumber = carRace[i];
                if (currentNumber == 0)
                {
                    sum = sum * 0.8;
                }
                sum += currentNumber;
            }
            return sum;
        }
        static double SumSecondCar(List<double> carRace)
        {
            double sum = 0;
            for (int j = carRace.Count - 1; j > carRace.Count / 2; j--)
            {
                double currentNumber = carRace[j];
                if (currentNumber == 0)
                {
                    sum = sum * 0.8;
                }
                sum += currentNumber;
            }
            return sum;
        }
    }
}