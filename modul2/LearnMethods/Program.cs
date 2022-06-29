//int n = int.Parse(Console.ReadLine());
//PrintHeaderANDBottomRow(n);
//for (int i = 0; i < n - 2; i++)
//{
//    PrintMiddleRow(n);
//}
//PrintHeaderANDBottomRow(n);
//static void PrintHeaderANDBottomRow(int n)
//{
//    Console.WriteLine(new string('-', 2 * n));
//}
//static void PrintMiddleRow(int n)
//{
//    Console.Write("-");
//    for (int i = 0; i < n - 1; i++)
//    {
//        Console.Write("\\/");
//    }
//    Console.WriteLine("-");
//}


//static string TriangleSurfaceArea(int b, int hb)
//{
//    return (b * hb / 2).ToString();
//}
//int b = int.Parse(Console.ReadLine());
//int hb = int.Parse(Console.ReadLine());
//Console.WriteLine(TriangleSurfaceArea(b, hb));

//static void ReceiptHeader()
//{
//    Console.WriteLine("CASH RECEIPT");
//    for (int i = 0; i < 30; i++)
//    {
//        Console.Write("-");
//    }
//    Console.WriteLine();
//}
//static void ReceiptBody()
//{
//    Console.WriteLine("Charged to____________________");
//    Console.WriteLine("Received by____________________");
//}
//static void ReceiptEnd()
//{
//    for (int i = 0; i < 30; i++)
//    {
//        Console.Write("-");
//    }
//    Console.WriteLine("-");
//    Console.WriteLine("\u00A9 SoftUni");
//}
//static void PrintReceipt()
//{
//    ReceiptHeader();
//    ReceiptBody();
//    ReceiptEnd();
//}
//PrintReceipt();

//static void PringSign(int n)
//{
//    if (n < 0)
//        Console.WriteLine($"{n} -> negative");
//    if (n > 0)
//        Console.WriteLine($"{n} -> positive");
//    if (n == 0)
//        Console.WriteLine($"{n} -> zero");
//}
//PringSign(int.Parse(Console.ReadLine()));

static void PrintTopOfTriangle(int start, int end)
{
    for (start = 0; start < end - 1; start++) 
    {
        Console.Write(start + " ");
    }
}
static void PrintMiddleOfTriangle(int start, int end)
{
    for (start = 0; start < end - 1; start++)
        Console.Write(start + " ");
}
static void PrintTriangle()
{
    
}