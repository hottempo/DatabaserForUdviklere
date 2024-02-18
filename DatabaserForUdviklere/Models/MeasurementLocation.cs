using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class MeasurementLocation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Website { get; set; }

    public decimal? Altitude { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public decimal? RadiationCoefficient { get; set; }

    public DateTime? LatestUtcDate { get; set; }
}
