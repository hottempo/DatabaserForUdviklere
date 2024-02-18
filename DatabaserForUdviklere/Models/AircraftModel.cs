using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class AircraftModel
{
    public int Id { get; set; }

    public int? AircraftManufacturerId { get; set; }

    public string? Name { get; set; }

    public int? AircraftCategoryId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Wtc { get; set; }

    public int? Engines { get; set; }

    public string? IcaoCode { get; set; }
}
