// See https://aka.ms/new-console-template for more information
int v = int.Parse(Console.ReadLine());
int p1 = int.Parse(Console.ReadLine()); 
int p2 = int.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double p = p1 + p2;
double water = p1 * h + p2 * h;
if (water<=v)
{
    double pipe1 = (p1 / p) * 100;
    double pipe2 = (p2 / p) * 100;
    Console.WriteLine($"The pool is {Math.Truncate(water/v*100)}% full. Pipe 1: {Math.Truncate(pipe1)}%. Pipe 2: {Math.Truncate(pipe2)}%.");
}
else
{
    double overflow = water - v;
    Console.WriteLine($"For {h} hours the pool overflows with {overflow} liters.");
}