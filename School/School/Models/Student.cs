using System;
using System.Collections.Generic;

namespace School.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<StudentsExam> StudentsExams { get; } = new List<StudentsExam>();

    public virtual ICollection<StudentsSubject> StudentsSubjects { get; } = new List<StudentsSubject>();

    public virtual ICollection<Teacher> Teachers { get; } = new List<Teacher>();
}
