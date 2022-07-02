using System;
using System.Linq;

namespace DynamicListWithReverse
{
    class Program
    {
        static DynamicList list = new DynamicList();
        static void Main()
        {
            string line;
            while ("END" != (line = Console.ReadLine()))
            {
                string[] cmdArgs = line.Split(' ');
                switch (cmdArgs[0])
                {
                    case "Add":
                        list.Add(cmdArgs[1]);
                        break;
                    case "AddFirst":
                        list.AddFirst(cmdArgs[1]);
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(cmdArgs[1]));
                        break;
                    case "Remove":
                        list.Remove(cmdArgs[1]);
                        break;
                    case "Contains":
                        list.Contains(cmdArgs[1]);
                        break;
                    case "Insert":
                        list.Insert(int.Parse(cmdArgs[1]), cmdArgs[2]);//index, item
                        break;
                    case "Print":
                        for (int i = 0; i < list.Count; i++)
                            Console.WriteLine(list[i]);
                        break;
                    case "Reverse":
                        list.Reverse();
                        break;
                }
            }
        }
    }
}
