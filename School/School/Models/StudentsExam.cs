using System;
using System.Collections.Generic;

namespace School.Models;

public partial class StudentsExam
{
    public int StudentId { get; set; }

    public int ExamId { get; set; }

    public decimal Grade { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
