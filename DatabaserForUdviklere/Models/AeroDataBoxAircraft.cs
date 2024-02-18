using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class AeroDataBoxAircraft
{
    public int Id { get; set; }

    public string? Reg { get; set; }

    public string? AirlineName { get; set; }

    public string? IataCodeShort { get; set; }

    public string? IataCodeLong { get; set; }

    public string? Model { get; set; }

    public string? ModelCode { get; set; }

    public string? TypeName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
