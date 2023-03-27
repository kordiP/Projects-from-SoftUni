using System;
using System.Collections.Generic;

namespace School.Models;

public partial class Exam
{
    public Exam(DateTime? date, int? subjectId)
    {
        this.Date = date;
        this.SubjectId = subjectId;
    }
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? SubjectId { get; set; }

    public virtual ICollection<StudentsExam> StudentsExams { get; } = new List<StudentsExam>();

    public virtual Subject? Subject { get; set; }
}
