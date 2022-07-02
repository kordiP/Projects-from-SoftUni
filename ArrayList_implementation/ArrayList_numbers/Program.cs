using System;
using System.Collections;

namespace ArrayList_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add(3);
            list.Add(4);
            int sum = 0;
            for (int i=0;i<list.Count;i++)
            {
                int value = (int)list[i];
                sum = sum + value;
            }
            Console.WriteLine("Sum="+sum);
        }
    }
}
