using System;

namespace ladybugs
{
    using System;
    internal class Program
    {
        static void Main()
        {
            int[] BugMovement = new int[int.Parse(Console.ReadLine())];
            string[] where_ladybug = Console.ReadLine().Split();
            string[] fly_info = Console.ReadLine().Split();
            for (int i = 0; i < where_ladybug.Length; i++)
                BugMovement[int.Parse(where_ladybug[i])] = 1;
            while (fly_info[0] != "end")
            {
                int WhichBug = int.Parse(fly_info[0]);
                string Dir = fly_info[1];
                int direction = 0;
                if (Dir == "right")
                    direction = 1;
                else if (Dir == "left")
                    direction = -1;
                int FlyLength = int.Parse(fly_info[2]);
                int NextPos = WhichBug + (FlyLength * direction);
                BugMovement[WhichBug] = 0;
                if (WhichBug + NextPos <= BugMovement.Length - 1 && WhichBug + NextPos >= 0)
                {
                    if (BugMovement[NextPos] == 1)
                        BugMovement[(NextPos + NextPos) * direction] = 1;
                    BugMovement[NextPos] = 1;
                }
                fly_info = Console.ReadLine().Split();
            }
            Console.WriteLine($"{String.Join(" ", BugMovement)}");
        }
    }
}
