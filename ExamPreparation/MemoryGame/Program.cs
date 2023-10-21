namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                // Write a program that recreates the Memory game.
                //On the first line, you will receive a sequence of elements. Each element in the sequence will have a twin.
                //Until the player receives "end" from the console, you will receive strings with two integers separated by a space,
                //representing the indexes of elements in the sequence.

                //If the player tries to cheat and enters two equal indexes or indexes which are out of bounds of the sequence,
                //you should add two matching elements at the middle of the sequence in the following format:
                //            "-{number of moves until now}a"
                //Then print this message on the console:
                //"Invalid input! Adding additional elements to the board"

                //Input
                //· On the first line, you will receive a sequence of elements
                //· On the following lines, you will receive integers until the command "end"
                //Output
                //· Every time the player hit two matching elements, you should remove them from the sequence and print on the console the following message:
                //"Congrats! You have found matching elements - ${element}!"
                //· If the player hit two different elements, you should print on the console the following message:
                //            "Try again!"
                //· If the player hit all matching elements before he receives "end" from the console, you should print on the console the following message:
                //            "You have won in {number of moves until now} turns!"
                //· If the player receives "end" before he hits all matching elements, you should print on the console the following message:
                //"Sorry you lose :(
                //{the current sequence's state}"
                //Constraints
                //· All elements in the sequence will always have a matching element.

                List<string> sequence = Console.ReadLine()
                    .Split()
                    .ToList();
                string input = string.Empty;
                int moveCount = 0;

                while ((input = Console.ReadLine()) != "end")
                {
                    List<int> elements = input
                        .Split()
                        .Select(int.Parse)
                        .ToList();
                    int firstElement = elements[0];
                    int secondElement = elements[1];
                    moveCount++;
                    if ((firstElement == secondElement) //If the player tries to cheat and enters two equal indexes or indexes which are out of bounds of the sequence
                        || (firstElement < 0 || firstElement >= sequence.Count)
                        || (secondElement < 0 || secondElement >= sequence.Count))
                    {
                        string newSymbol = $"-{moveCount}a";
                        //you should add two matching elements at the middle of the sequence 
                        List<string> newElements = new List<string> { newSymbol, newSymbol };
                        int middleIndex = sequence.Count / 2;//middle of the sequence 
                        sequence.InsertRange(middleIndex, newElements);
                        Console.WriteLine("Invalid input! Adding additional elements to the board");

                    }
                    else
                    {
                        //Every time the player hit two matching elements, you should remove them from the sequence and print on the console the following message:
                        //"Congrats! You have found matching elements - ${element}!"
                        if (sequence[firstElement] == sequence[secondElement])
                        {
                            string element = sequence[firstElement];
                            Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                            if (firstElement < secondElement)//you should remove them from the sequence
                            {
                                sequence.RemoveAt(firstElement);
                                sequence.RemoveAt(secondElement - 1);
                            }
                            else if (firstElement > secondElement)
                            {
                                sequence.RemoveAt(secondElement);
                                sequence.RemoveAt(firstElement - 1);
                            }
                            // If the player hit two different elements, you should print on the console the following message:
                            //            "Try again!"

                        }
                        else if (sequence[firstElement] != sequence[secondElement])
                        {
                            Console.WriteLine("Try again!");
                        }


                        //If the player hit all matching elements before he receives "end" from the console, you should print on the console the following message:
                        //            "You have won in {number of moves until now} turns!"
                        if (sequence.Count == 0)
                        {
                            Console.WriteLine($"You have won in {moveCount} turns!");
                            break;
                        }


                    }

                    //If the player receives "end" before he hits all matching elements, you should print on the console the following message:
                    //"Sorry you lose :(
                    //{the current sequence's state}"

                }
                if (sequence.Count != 0)
                {
                    Console.WriteLine("Sorry you lose :(");
                    Console.WriteLine(string.Join(" ", sequence));
                }
            }


        }
    }
}
    
