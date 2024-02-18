using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Aircraft
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public string? RegistrationCode { get; set; }

    public int? AircraftModelId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? ModelConfirmed { get; set; }

    public bool? SkipRadCalc { get; set; }

    public bool? IsSimulator { get; set; }

    public int? AeroDataBoxAircraftId { get; set; }
}
