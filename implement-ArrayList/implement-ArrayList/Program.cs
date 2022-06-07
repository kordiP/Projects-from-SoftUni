using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.RemoveAt(0);
            list.RemoveItem(4);
            list.Print();
        }
    }
}
