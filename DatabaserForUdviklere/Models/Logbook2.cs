using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Logbook2
{
    public int? UserId { get; set; }

    public int? OwnerId { get; set; }

    public string? LoadId { get; set; }

    public int? FlightId { get; set; }

    public DateTime? OffBlock { get; set; }

    public int? FlightRelationId { get; set; }

    public decimal? RadiationAmount { get; set; }
}
