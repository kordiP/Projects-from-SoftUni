using System;
using System.Collections.Generic;

namespace School.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Lessons { get; set; }

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();

    public virtual ICollection<StudentsSubject> StudentsSubjects { get; } = new List<StudentsSubject>();

    public virtual ICollection<Teacher> Teachers { get; } = new List<Teacher>();
}
