using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main()
        {
            DynamicList diList = new DynamicList();
            diList.Add("kordi");
            diList.Add("drugo kordi");
            diList.Add("razlichno kordi");
            diList.Remove("kordi");

        }
    }
}
