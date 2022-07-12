using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Self_Made
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Message One");
            queue.Enqueue("Message Two");
            queue.Enqueue("Message Three");
            queue.Enqueue("Message Four");
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
