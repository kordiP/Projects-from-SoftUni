using System;
using System.Linq;
namespace ladybug
{
    public class Program
    {
        static void Main()
        {
            const string EndCommand = "end";
            int FieldSize = int.Parse(Console.ReadLine());
            int[] InitialPos = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] ind_dir_fly = Console.ReadLine().Split();
            int[] Field = new int[FieldSize];
            for (int i = 0; i < InitialPos.Length; i++)
                if (InitialPos[i] >= 0 && InitialPos[i] < Field.Length)
                    Field[InitialPos[i]] = 1;
            while (ind_dir_fly[0] != EndCommand)
            {
                int BugIndex = int.Parse(ind_dir_fly[0]);
                int FlyLength = int.Parse(ind_dir_fly[2]);
                string Direction = ind_dir_fly[1];
                int Direction_Symbol = 1;
                if (Direction == "left")
                    Direction_Symbol = -1;
                int NextPos = BugIndex + (FlyLength * Direction_Symbol);
                if (BugIndex < 0 || BugIndex >= FieldSize || Field[BugIndex] == 0)
                {
                    ind_dir_fly = Console.ReadLine().Split();
                    continue;
                }
                if (NextPos > Field.Length - 1 || NextPos < 0)
                    Field[BugIndex] = 0;
                else
                {
                    Field[BugIndex] = 0;
                    if (Field[NextPos] == 1)
                    {
                        if (NextPos + (FlyLength * Direction_Symbol) < Field.Length - 1 && NextPos + (FlyLength * Direction_Symbol) >= 0) Field[NextPos + (FlyLength * Direction_Symbol)] = 1;
                    }
                    else Field[NextPos] = 1;
                }
                ind_dir_fly = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", Field));
        }
    }
}
//100/100