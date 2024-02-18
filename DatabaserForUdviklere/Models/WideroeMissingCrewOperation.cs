using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class WideroeMissingCrewOperation
{
    public string? CrewFileName { get; set; }

    public int? CrewLineNumber { get; set; }

    public string? CrewLineContent { get; set; }

    public string? FlightFileName { get; set; }

    public int? FlightLineNumber { get; set; }

    public string? FlightLineContent { get; set; }

    public DateTime? FfMtime { get; set; }

    public int? Id { get; set; }

    public int? FlightId { get; set; }

    public string? OffBlock { get; set; }

    public string? FlightName { get; set; }

    public int? AirportId { get; set; }

    public string? IataCode { get; set; }

    public string? IcaoCode { get; set; }

    public int? UserId { get; set; }

    public string? LoadId { get; set; }

    public string? RoleName { get; set; }

    public int? OwnerId { get; set; }

    public string? FtpUsername { get; set; }
}
