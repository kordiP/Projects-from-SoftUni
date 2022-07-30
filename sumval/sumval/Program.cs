using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumval
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            string s; 
            s = Console.ReadLine();
            n = int.Parse(s);
            int sum = 0; 
            for (int i = 1; i<= n; i++)
{
                s = Console.ReadLine();
                int number = int.Parse(s);
                sum = sum + number;
            }
            Console.WriteLine("Sum:{0}", sum);
        }
    }
}
