namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that helps you keep track of your shot targets.
            // You will receive a sequence with integers, separated by a single space, representing targets and their value.
            // Afterward, you will be receiving indices until the "End" command is given,
            // and you need to print the targets and the count of shot targets.

            //Every time you receive an index, you need to shoot the target on that index, if it is possible.
            //Every time you shoot a target, its value becomes -1, and it is considered shot. Along with that, you also need to:

            //•	Reduce all the other targets, which have greater values than your current target, with its value. 

            //•	Increase all the other targets, which have less than or equal value to the shot target, with its value.

            //Keep in mind that you can't shoot a target, which is already shot. You also can't increase or reduce a target,
            //which is considered a shot.
            //When you receive the "End" command, print the targets in their current state and the count of shot targets in the following format:
            //   "Shot targets: {count} -> {target1} {target2}… {targetn}"
            //Input / Constraints
            //•	On the first line of input, you will receive a sequence of integers, separated by a single space – the targets sequence.
            //•	On the following lines, until the "End" command, you be receiving integers each on a single line – the index of the target to be shot.
            //Output
            //•	The format of the output is described above in the problem description.

            List<int> targetSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            int shoot = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);
                if (targetIndex < 0 || targetIndex >= targetSequence.Count)//if it is possible.
                {
                    continue;
                }

                int targetValue = targetSequence[targetIndex];//Every time you shoot a target, its value becomes -1, and it is considered shot.

                if (targetValue == -1)
                {
                    continue;
                }

                targetSequence[targetIndex] = -1;//shoot a target, its value becomes -1!!!
                shoot++;

                for (int i = 0; i < targetSequence.Count; i++)
                {
                    if (targetSequence[i] == -1)
                    {
                        continue;
                    }
                    else if (targetValue >= targetSequence[i])
                    {
                        targetSequence[i] += targetValue;//Increase all the other targets, which have less than or equal value to the shot target, with its value.
                    }
                    else if (targetValue < targetSequence[i])
                    {
                        targetSequence[i] -= targetValue;//Reduce all the other targets, which have greater values than your current target, with its value.
                    }
                }

            }
            Console.WriteLine($"Shot targets: {shoot} -> {string.Join(" ", targetSequence)}");
        }
    }
}