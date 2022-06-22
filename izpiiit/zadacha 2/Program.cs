using System;
using System.Linq;
using System.Collections.Generic;
namespace zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> patients = Console.ReadLine().Split(", ").ToList();
            const string end = "END OF PATIENTS";
            string command = Console.ReadLine();
            while (command != end)
            {
                switch (command)
                {
                    case "Add patient":
                        patients.Add(Console.ReadLine());
                        break;
                    case "Add patient on position":
                        string name = Console.ReadLine();
                        int pos = int.Parse(Console.ReadLine());
                        patients.Insert(pos, name);
                        break;
                    case "Remove patient on position":
                        patients.RemoveAt(int.Parse(Console.ReadLine()));
                        break;
                    case "Remove last patient":
                        patients.RemoveAt(patients.Count - 1);
                        break;
                    case "Remove first patient":
                        patients.RemoveAt(0);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", patients));
        }
    }
}
