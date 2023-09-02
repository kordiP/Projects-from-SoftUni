namespace accTest
{
    internal class Program
    {
        public static void Main()
        {
            List<string> list1 = new() { "a", "b", "c", "d", "e", "f" };
            List<string> list2 = new() { "g", "h", "i", "j", "k", "l" };

            list1.AddRange(list2);

            foreach (string item in list1) { Console.Write(item + " "); }
        }

    }
}