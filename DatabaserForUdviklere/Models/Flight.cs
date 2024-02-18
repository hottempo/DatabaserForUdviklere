using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Flight
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? AircraftId { get; set; }

    public string? Status { get; set; }

    public int? DepartureAirportId { get; set; }

    public int? ArrivalAirportId { get; set; }

    public DateTime? DepartureTime { get; set; }

    public DateTime? OffBlock { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public DateTime? OnBlock { get; set; }

    public decimal? RadiationAmount { get; set; }

    public int? TotalDayMinutes { get; set; }

    public int? TotalNightMinutes { get; set; }

    public int? TotalInstrMinutes { get; set; }

    public int? ApproachTypeId { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? FlightTypeId { get; set; }

    public int? OwnerId { get; set; }

    public bool? NightLanding { get; set; }

    public string? LoadFilename { get; set; }

    public bool? Recalc { get; set; }

    public int? FallbackAcId { get; set; }

    public DateTime? WorkerStartedAt { get; set; }

    public int? RouteDefinedBy { get; set; }

    public double? GctRad { get; set; }

    public double? RrtRad { get; set; }

    public string? RadSource { get; set; }

    public string? ForeignId { get; set; }

    public int? FlightAwareFlightId { get; set; }

    public virtual ICollection<FlightTrack> FlightTracks { get; set; } = new List<FlightTrack>();
}
