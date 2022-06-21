using System;
using System.Collections;
using System.Collections.Generic;
namespace lds
{
    internal class Program
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            List<string> listG = new List<string>();
            Stack<string> stackG = new Stack<string>();
            Stack stack = new Stack();
            stack.Push("kordi2");
            stack.Push(87.4);
            stack.Push(1);
            stack.Push('й');
            stackG.Push("ananas");
            stackG.Push("burgas");
            stackG.Push("vas");
            stackG.Push("geo");
            list.Add("sirene");
            list.Add(69);
            list.Add(420.69);
            list.Add('>');
            list.Add(null);
            list.Add(true);
            listG.Add("korda");
            listG.Add("hlqb");
            //Console.WriteLine(String.Join(" ", listG));
            //Console.WriteLine(String.Join(" ", list.ToArray()));
            //foreach (var item in listG)
            //{
            //    Console.Write(item + " ");
            //}
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine(String.Join("\n", stackG));
            Console.WriteLine(String.Join("\n", stack.ToArray()));
            stack.Pop();
            Console.WriteLine(String.Join("\n", stack.ToArray()));
            Console.Beep();
        }
        
    }
}
