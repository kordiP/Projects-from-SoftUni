using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Apartment
{
    public int Id { get; set; }

    public int Floor { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Debt { get; set; }

    public int BlockId { get; set; }

    public int Inhabitants { get; set; }

    public int Number { get; set; }

    public int Quadrature { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual Block Block { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Resident> Residents { get; set; } = new List<Resident>();
}
