using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); // Reading shit
            int[] field = new int[fieldSize]; if (field.Length > 1000) return;
            int[] ladybugsOnStart = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int ladyIndex = 0;
            for (int i = 0; i < ladybugsOnStart.Length; i++) // Filling the ladybugs into the field
            {
                ladyIndex = ladybugsOnStart[i];
                for (int k = 0; k < field.Length; k++)
                {
                    if (k == ladyIndex)
                    {
                        field[k] = 1;
                    }
                }
            }

            string[] command = Console.ReadLine().Split().ToArray(); // Reading the command and splitting it
            int commandCounter = 0;
            int ladybug = 0;
            string direction = string.Empty;
            int jumps = 0;

            while (command[0] != "end" && commandCounter <= 100)
            {
                ladybug = int.Parse(command[0]); if (ladybug >= int.MaxValue || ladybug <= int.MinValue) return;
                direction = command[1];
                jumps = int.Parse(command[2]); if (jumps >= int.MaxValue || jumps <= int.MinValue) return;
                if (field[ladybug] == 0) //Check if there is a ladybug on the given index
                {
                    break;
                }
                else // If there is...
                {
                    if (direction == "right")
                    {
                        bool exitWhile = false; // variable for false data, to stop the while cycle
                        while (exitWhile != true)
                        {
                            if (ladybug + jumps <= field.Length - 1 && ladybug + jumps >= 0)
                            { // check if the ladybug + index  is still in the field Length
                                if (field[ladybug + jumps] == 0)
                                {
                                    field[ladybug] = 0; // clear the current ladybug position
                                    field[ladybug + jumps] = 1; // There will be a ladybug
                                    exitWhile = true; // stop the cycle
                                }
                                else
                                {
                                    jumps += jumps; // double the jumps
                                }

                            }
                            else //if the ladybug "flies away":
                            {
                                field[ladybug] = 0;
                                exitWhile = true;
                            }
                        }


                    }
                    else
                    {
                        bool exitWhile = false; // variable for false data, to stop the while cycle
                        while (exitWhile != true)
                        {
                            if (ladybug - jumps <= field.Length - 1 && ladybug - jumps >= 0)
                            { // check if the ladybug + index  is still in the field Length
                                if (field[ladybug - jumps] == 0)
                                {
                                    field[ladybug] = 0; // clear the current ladybug position
                                    field[ladybug - jumps] = 1; // There will be a ladybug
                                    exitWhile = true; // stop the cycle
                                }
                                else
                                {
                                    jumps += jumps; // double the jumps
                                }

                            }
                            else //if the ladybug "flies away":
                            {
                                field[ladybug] = 0;
                                exitWhile = true;
                            }
                        }
                    }
                }
                commandCounter++;
                command = Console.ReadLine().Split().ToArray(); // read the new command
            }


            Console.WriteLine(String.Join(" ", field)); // Don't you know what this is ?
        }
    }
}