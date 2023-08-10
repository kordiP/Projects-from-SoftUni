using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Block
{
    public int Id { get; set; }

    public string Region { get; set; } = null!;

    public string Municupality { get; set; } = null!;

    public string Town { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
