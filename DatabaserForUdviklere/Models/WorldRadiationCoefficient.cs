using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class WorldRadiationCoefficient
{
    public int Id { get; set; }

    public int? Altitude { get; set; }

    public int? Latitude { get; set; }

    public int? Longitude { get; set; }

    public decimal? RadiationCoefficient { get; set; }

    public DateTime? LastGenerationDate { get; set; }
}
