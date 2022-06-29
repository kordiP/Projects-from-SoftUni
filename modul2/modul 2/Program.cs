string binary_start = Console.ReadLine();
int from_base = 2;
int to_base = 10;
string decimal_number_1 = Convert.ToString(Convert.ToInt32(binary_start, from_base), to_base);
Console.Write("      "+decimal_number_1);
int d1 = int.Parse(decimal_number_1);
for (int i = 0; i <= int.MaxValue; i++)
{ 
    d1++;
    Console.ReadKey();
    string decimal_number_2 = Convert.ToString(d1);
    string decimal_number_3 = Convert.ToString(Convert.ToInt32(decimal_number_2, to_base), from_base);
    string binary_2 = Convert.ToString(Convert.ToInt32(decimal_number_3, from_base), to_base);
    Console.Clear();
    Console.WriteLine($"{decimal_number_3}      {binary_2}");

}


