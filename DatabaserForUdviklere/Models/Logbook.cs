using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Logbook
{
    public int? UserId { get; set; }

    public int? OwnerId { get; set; }

    public string? LoadId { get; set; }

    public int? FlightId { get; set; }

    public DateTime? OffBlock { get; set; }

    public decimal? RadiationAmount { get; set; }
}
