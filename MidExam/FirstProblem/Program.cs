using System.Transactions;
/*
50
2
1.0
0.10
10.0
 
 */
namespace FirstProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());//брой студенти
            double priceFloor = double.Parse(Console.ReadLine());//всеки пети е безплатен
            double priceOneEgg = double.Parse(Console.ReadLine());//едно яйце
            double priceApron = double.Parse(Console.ReadLine());//престилки
            double student = Math.Ceiling(students * 1.20);

            
            double sets = (priceApron * student)  + (priceFloor * students) + ((priceOneEgg * 10) * students);//???
            if (students % 5 == 0)
            {
                double stud= students / 5;
                
                sets = (priceApron * student) + (priceFloor  * (students - stud) + ((priceOneEgg * 10) * students));//???

            }

            if (buget >= sets)
            {
                 Console.WriteLine($"Items purchased for {sets:f2}$.");

            }
            else
            {
                Console.WriteLine($"{Math.Abs(buget - sets):f2}$ more needed.");

            }
            // · "Items purchased for {the cost of the items}$."

            //· "{neededMoney}$ more needed."

        }
    }
}