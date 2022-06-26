using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name1 = input[0]; int age1 = int.Parse(input[1]);
                Person p1 = new Person(name1, age1); 
                family.AddMember(p1);
            }
            Console.Write("Име на фамилия: ");
            family.Name = Console.ReadLine();
            family.Print();
            //Console.WriteLine(family.GetAverageAge()); // Average w/ Method
            //Console.WriteLine(family.Average); // Average w/ Property
        }
    }
}
