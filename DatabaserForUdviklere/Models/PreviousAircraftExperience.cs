using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class PreviousAircraftExperience
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? AircraftType { get; set; }

    public int? Hours { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
