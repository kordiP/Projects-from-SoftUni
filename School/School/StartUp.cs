using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School
{
    internal class StartUp
    {
        static void Main()
        {
            var context = new SchoolContext(); /*!!!*/

            // var studentToUpdate = context.Students.FirstOrDefault(s => s.Id == 4);
            // if (studentToUpdate != null) studentToUpdate.FirstName = "March";
            // context.SaveChanges();

            // var examInsert = new Exam(DateTime.UtcNow, null);

            // context.Exams.Add(examInsert);
            // context.SaveChanges();

            // var exams = context.Exams.ToList();
            //
            // foreach (var exam in exams ) 
            // { 
            //     Console.WriteLine(exam.Subject.Name); 
            // }

            // var examToDelete = context.Exams.FirstOrDefault(e => e.Id == 25);
            // if (examToDelete != null) examToDelete.SubjectId = null;
            // context.SaveChanges();

            // context.Exams.Remove(examToDelete);
            // context.SaveChanges();
        }
    }
}