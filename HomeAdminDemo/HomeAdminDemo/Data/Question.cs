using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Question
{
    public int Id { get; set; }

    public int ResidentId { get; set; }

    public string Description { get; set; } = null!;

    public string? Answer { get; set; }

    public int MeetingId { get; set; }

    public virtual Meeting Meeting { get; set; } = null!;

    public virtual Resident Resident { get; set; } = null!;
}
