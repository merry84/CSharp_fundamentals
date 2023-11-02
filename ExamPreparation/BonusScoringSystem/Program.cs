using System.Threading.Channels;

namespace BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a program that calculates bonus points for each student enrolled in a course.
            //On the first line, you are going to receive the number of students.
            //On the second line, you will receive the total number of lectures in the course.
            //The course has an additional bonus, which you will receive on the third line.
            //On the following lines, you will be receiving the count of attendances for each student.
            //    The bonus is calculated with the following formula:
            //{ total bonus} = { student attendances} / { course lectures}*(5 + { additional bonus})
            //Find the student with the maximum bonus and print them, along with his attendance, in the following format:
            //"Max Bonus: {max bonus points}."
            //"The student has attended {student attendances} lectures."
            //Round the bonus points at the end to the nearest larger number.
            //Input / Constraints
            //  •On the first line, you are going to receive the number of the students – an integer in the range[0…50].
            //  •On the second line, you will receive the number of the lectures – an integer number in the range[0...50].
            //  •On the third line, you will receive the additional bonus – an integer number in the range[0….100].
            //  •On the following lines, you will be receiving the attendance of each student.
            //  •There will never be students with equal bonuses.
            // Output
            //    •	Print the maximum bonus points and the attendance of the given student,
            // rounded to the nearest larger number, scored by a student in this course in the format described above.

            int studentCount = int.Parse(Console.ReadLine());
            int numberOfLecturs = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double maxPoints = 0;//
            int maxAttendance = 0;// max visit lecturs 

            for (int i = 0; i <studentCount ;i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                double totalBonus = ((1.0* attendance / numberOfLecturs) * (5 + bonus));
                if (maxPoints < totalBonus)// ako max point sa po malki ot totalbonus
                {
                    maxPoints = totalBonus;//te sa maxPoint
                    maxAttendance = attendance;//nai mnogo poseshteniq
                }

            }



            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxPoints)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");

            //First, we receive the number of students enrolled in the course – 5.
            //The total count of the lectures is 25, and the additional bonus is 30.
            //Then we calculate the bonus of the student with 12 attendances, which is 16.8.
            //We continue calculating each of the student's bonuses.
            //The one with 24 attendances has the highest bonus – 33.6 (34 rounded),
            //so we print the appropriate message on the console.
            // 
            /*
             5
            25
            3
            // 12poseshteniq/25lekcii *(5+30bonus) = 0.48 * 35  = 16.8 e tottal bonusa
            12-poseshteniq na parviq student
            19******** na vroriq
            24----*---*---- s nai mn poseshteniq i toi e s nai golqm total bonus
            16----*---*---
            20----*---*---
            */       
            
        }
    }
}