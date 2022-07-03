using System;

namespace perimetarP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("d=");
            double d = double.Parse(Console.ReadLine());
            double b2 = d * d - a * a;
            double b = Math.Sqrt(b2);
            double s = a * b;
            double p = a + a + b + b;
            Console.WriteLine("s= {0} kv. sm",s);
            Console.WriteLine("b= {0} sm",b);
            Console.WriteLine("p= {0} sm",p);

        }
    }
}
