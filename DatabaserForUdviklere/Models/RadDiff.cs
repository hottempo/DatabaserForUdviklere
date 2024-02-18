using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class RadDiff
{
    public int? Id { get; set; }

    public string? Callsign { get; set; }

    public DateTime? OffBlock { get; set; }

    public string? DepIata { get; set; }

    public string? DepPort { get; set; }

    public string? ArrIata { get; set; }

    public string? ArrPort { get; set; }

    public string? RegistrationCode { get; set; }

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public double? GctRad { get; set; }

    public double? RrtRad { get; set; }

    public double? RadDiff1 { get; set; }

    public double? RealDiff { get; set; }

    public double? RadDiffPct { get; set; }

    public string? TypeName { get; set; }

    public int? AcId { get; set; }

    public int? ModelId { get; set; }
}
