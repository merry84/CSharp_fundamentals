namespace MovingTarget
{/*
  52 74 23 44 96 110
  Shoot 5 10
  Shoot 1 80
  Strike 2 1
  Add 22 3
  End
  */
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // You are at a shooting gallery and you need a program that helps you keep track of moving targets.
            // On the first line, you will receive a sequence of targets with their integer values, split by a single space.
            // Then, you will start receiving commands for manipulating the targets until the "End" command.
            // The commands are the following:
            //->"Shoot {index} {power}"
            //o Shoot the target at the index, if it exists, by reducing its value by the given power(integer value).
            //o Remove the target, if it is shot.A target is considered shot when its value reaches 0.

            //->"Add {index} {value}"
            //o Insert a target with the received value at the received index, if it exists.
            //o If not, print: "Invalid placement!".

            //->"Strike {index} {radius}"
            //o Remove the target at the given index and the ones before and after it, depending on the radius.
            //o If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.

            //->"End"
            //o Print the sequence with targets in the following format and end the program:
            //            "{target1}|{target2}…|{targetn}"

            //Input / Constraints
            // · On the first line, you will receive the sequence of targets – integer values[1…10000].
            //· On the following lines, until the "End" command, you will be receiving the commands described above – strings.
            //· There will never be a case when the "Strike" command would empty the whole sequence.
            //Output
            //· Print the appropriate message in case of any command if necessary.
            //· In the end, print the sequence of targets in the format described above.

            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = default;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputCommand = input.Split().ToArray();
                string command = inputCommand[0];
                int index = int.Parse(inputCommand[1]);
                int value = int.Parse(inputCommand[2]);

                if (command == "Shoot")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets[index] -= value; //Shoot the target at the index, if it exists
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index); //remove the target, if it is shot.A target is considered shot when its value reaches 0.

                        }
                    }

                }
                else if (command == "Add")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets.Insert(index, value); //Insert a target with the received value at the received index, if it exists.
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!"); //If not, print: "Invalid placement!".
                    }

                }
                else //Strike {index} {radius}"
                {
                    if (IsValidIndex(index, targets)
                        && IsValidIndex(index - value, targets)
                        && IsValidIndex(index + value, targets))
                    {
                        for (int i = 1; i <= value; i++)// strike right
                        {
                            targets.RemoveAt(index + i);
                        }
                        targets.RemoveAt(index);
                        for (int i = 1; i <= value; i++)//strike left
                        {
                            targets.RemoveAt(index - i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

            }

            Console.WriteLine(string.Join("|", targets));

            static bool IsValidIndex(int index, List<int> targets)
            {
                return index < targets.Count && index >= 0;
            }
        }


    }
}

