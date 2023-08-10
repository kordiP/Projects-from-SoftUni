using System;
using System.Collections.Generic;

namespace HomeAdminDemo.Data;

public partial class Resident
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public int ApartmentId { get; set; }

    public virtual Apartment Apartment { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
