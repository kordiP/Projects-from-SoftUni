using System;
using System.Collections.Generic;

namespace DemoEFCore.Models;

public class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Lessons { get; set; }
}
