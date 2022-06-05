using System;
using System.Collections.Generic;
namespace списък
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(5);
            myList.Add(1);
            myList.Add(8);
            myList.Add(-7);
            //myList.RemoveAt(1);

            Console.WriteLine("Elements in myList is: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sort myList is: ");
            myList.Sort();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Reverse myList is:");
            myList.Reverse();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }
    }
}
