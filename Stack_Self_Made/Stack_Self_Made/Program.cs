using System;
namespace Stack_Self_Made
{
    internal class Program
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1. Ivan");
            stack.Push("2. Nikolay");
            stack.Push("3. Maria");
            stack.Push("4. George");
            for (int i = 0; i < stack.Count; i++) Console.WriteLine(stack[i]);
        }
    }
}
