using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class FlightAwareAirport
{
    public int Id { get; set; }

    public string? IcaoCode { get; set; }

    public string? IataCode { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public string? CountryCode { get; set; }

    public double? Elevation { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Province { get; set; }

    public string? Timezone { get; set; }

    public string? WikiUrl { get; set; }
}
