
using DemoEFCore.Data;
using DemoEFCore.Models;

namespace DemoEFCore
{
    internal class StartUp
    {
        static void Main()
        {
            using (var context = new MyDbContext())
            {
                var subjects = context.Subjects
                    .Where(a => a.Id >= 1)
                    .Select(x => new { x.Name, x.Id })
                    .OrderBy(n => n.Name);
                foreach (var subject in subjects)
                {
                    Console.WriteLine(subject.Name + " " + subject.Id);
                }
            }

            using (var context = new MyDbContext())
            {
                var subject = new Subject { Name = "Ball" };
                context.Subjects.Add(subject);
                context.SaveChanges();
            }
        }
    }
}