using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class FlightAwareFlight
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public string? FaIdent { get; set; }

    public DateTime? ActualArrivalTime { get; set; }

    public DateTime? ActualBlockinTime { get; set; }

    public DateTime? ActualBlockoutTime { get; set; }

    public DateTime? ActualDepartureTime { get; set; }

    public bool? Adhoc { get; set; }

    public string? Aircrafttype { get; set; }

    public string? Airline { get; set; }

    public string? AirlineIata { get; set; }

    public int? ArrivalDelay { get; set; }

    public string? AtcIdent { get; set; }

    public bool? Blocked { get; set; }

    public bool? Cancelled { get; set; }

    public string? Codeshares { get; set; }

    public bool? Datalink { get; set; }

    public int? DepartureDelay { get; set; }

    public string? Destination { get; set; }

    public bool? Diverted { get; set; }

    public DateTime? FiledArrivalTime { get; set; }

    public DateTime? FiledBlockinTime { get; set; }

    public DateTime? FiledBlockoutTime { get; set; }

    public DateTime? FiledDepartureTime { get; set; }

    public int? FiledEte { get; set; }

    public string? Flightnumber { get; set; }

    public string? FullAircrafttype { get; set; }

    public string? Ident { get; set; }

    public string? Origin { get; set; }

    public string? Route { get; set; }

    public string? Status { get; set; }

    public string? Tailnumber { get; set; }

    public string? FlightType { get; set; }

    public string? FlightTracks { get; set; }

    public double? Radiation { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? State { get; set; }
}
