using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Airport
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CountryId { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public int? RunwayAltitude { get; set; }

    public int? RunwayLength { get; set; }

    public string? IataCode { get; set; }

    public string? IcaoCode { get; set; }

    public int? GmtOffset { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? State { get; set; }
}
