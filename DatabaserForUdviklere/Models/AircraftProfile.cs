using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class AircraftProfile
{
    public int Id { get; set; }

    public int? AircraftModelId { get; set; }

    public int? Minutes { get; set; }

    public int? Altitude { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
