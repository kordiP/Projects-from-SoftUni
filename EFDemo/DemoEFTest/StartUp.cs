using DemoEFTest.Data;

namespace DemoEFTest
{
    public class StartUp
    {
        static void Main()
        {
            using (WorkContext context = new WorkContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}