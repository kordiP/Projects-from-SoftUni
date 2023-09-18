namespace NOD
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int nod = NODRecursiveWithSubtraction(num1, num2); // Change method here

            Console.WriteLine(nod);
        }
        static int NODFinderNonRecursive(int number1, int number2)
        {
            int smallerNumber = number1 < number2 ? number1 : number2;
            int nod = 1;
            for (int i = 1; i <= smallerNumber; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    nod = i;
                }
            }
            return nod;
        }
        static int NODRecursiveWithSubtraction(int number1, int number2)
        {
            number1 = 
                number1 > number2 ? 
                NODRecursiveWithSubtraction(number1 - number2, number2) : number1;

            number2 = 
                number1 < number2 ? 
                NODRecursiveWithSubtraction(number1, number2 - number1) : number2;      

            return 
                number1 == number2 ?
                number1 : NODRecursiveWithSubtraction(number1, number2);           
        }
        
    }
}