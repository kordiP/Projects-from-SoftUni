using System;

namespace neshtotukaneshto
{
    internal class Program
    {
        static void Main()
        {
            LinkedList<string> shoppingList = new LinkedList<string>();
            shoppingList.Add("Second");
            shoppingList.Insert("Fourth", 1);
            shoppingList.Insert("Third", 1); // Goes to index 1, item previously assigned with 1 is now 2
            shoppingList.AddSpecial("First");
            Console.WriteLine("We need to buy:");
            for (int i = 0; i < shoppingList.count; i++)
            {
                Console.WriteLine(" - " + shoppingList[i]);
            }
        }
    }

}
