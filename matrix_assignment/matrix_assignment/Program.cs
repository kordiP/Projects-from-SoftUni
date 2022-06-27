using System;

namespace matrix_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows - 1; i++) 
                for (int j = 0; j < columns - 1; j++) 
                    matrix[rows, columns] = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns - 1; j++) 
                    Console.Write(matrix[rows, columns] + " ");
                Console.WriteLine();
            }
        }
    }
}
