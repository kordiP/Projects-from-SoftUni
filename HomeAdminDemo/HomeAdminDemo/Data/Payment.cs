using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Payment
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public int ApartmentId { get; set; }

    public virtual Apartment Apartment { get; set; } = null!;
}
