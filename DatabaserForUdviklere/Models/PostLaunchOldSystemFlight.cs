using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class PostLaunchOldSystemFlight
{
    public int? FlightSeq { get; set; }

    public DateTime? OffBlock { get; set; }

    public string? DepartureCode { get; set; }

    public string? FlightName { get; set; }

    public string? AcReg { get; set; }

    public int? AircraftId { get; set; }

    public int? AircraftModelId { get; set; }

    public decimal? Radiation { get; set; }

    public int? MatchedFlight { get; set; }

    public List<int>? AlternativeFlghts { get; set; }

    public string? Csv { get; set; }

    public string? Message { get; set; }

    public bool? Concurrent { get; set; }
}
