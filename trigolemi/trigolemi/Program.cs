using System;

namespace trigolemi
{
    class Program
    {
        static void Main(string[] args)
        {
           var x = Console.ReadLine();
            var y = Console.ReadLine();
            var z = Console.ReadLine();
            if (x > y && x > z) { Console.WriteLine("x e nai-golqmo"); }
            if (y > x&&y>z) { Console.WriteLine("y e nai-golqmo"); }
            if (z > x&&z>y) { Console.WriteLine("z e nai-golqmo"); }
            
            
            
        
        }
    }
}
