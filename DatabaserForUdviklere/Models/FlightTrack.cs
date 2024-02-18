using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class FlightTrack
{
    public int Id { get; set; }

    public int? FlightId { get; set; }

    public string? TrackSource { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? FlightTrackSteps { get; set; }

    public double? Radiation { get; set; }

    public virtual Flight? Flight { get; set; }
}
