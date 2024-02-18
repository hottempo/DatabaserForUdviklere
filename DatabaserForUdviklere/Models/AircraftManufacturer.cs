using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class AircraftManufacturer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
