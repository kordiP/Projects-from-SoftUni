using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Project
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public decimal Cost { get; set; }

    public int BlockId { get; set; }

    public virtual Block Block { get; set; } = null!;
}
