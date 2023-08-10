using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Meeting
{
    public int Id { get; set; }

    public DateTime ScheduledOn { get; set; }

    public int AdminId { get; set; }

    public string Description { get; set; } = null!;

    public byte Mandatory { get; set; }

    public byte? IsFinished { get; set; }

    public virtual Admin Admin { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
