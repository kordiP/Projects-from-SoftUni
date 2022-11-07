using System;
using System.Threading;

namespace Text_animation_test
{
    internal class Program
    {
        static void Main()
        {
            string text = "Hi! This is a test to see if I can make something like an animation for text in C#!\nIt worked first try!\nHonestly, amazing!";
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(69);
            }
        }
    }
}
