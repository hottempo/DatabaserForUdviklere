using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class FlightsOldSystem
{
    public string? Name { get; set; }

    public string? DepartureIata { get; set; }

    public string? OffBlock { get; set; }

    public string? DepartureDatetime { get; set; }

    public string? ArrivalDatetime { get; set; }

    public string? OnBlock { get; set; }

    public string? Note { get; set; }

    public int? OwnerId { get; set; }
}
