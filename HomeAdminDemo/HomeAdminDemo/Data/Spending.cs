using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Spending
{
    public int Id { get; set; }

    public decimal? Electricity { get; set; }

    public decimal? Cleaning { get; set; }

    public decimal? ApartmentTax { get; set; }

    public decimal? Lift { get; set; }

    public decimal? Parking { get; set; }

    public decimal? Other { get; set; }

    public decimal? PersonalTax { get; set; }

    public decimal? Repairs { get; set; }
}
