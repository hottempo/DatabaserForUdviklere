using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class FileLines2
{
    public string? FtpUsername { get; set; }

    public string? FileName { get; set; }

    public string? FileType { get; set; }

    public int? FileSize { get; set; }

    public DateTime? FileMtime { get; set; }

    public int? FileLines { get; set; }

    public int? LineNumber { get; set; }

    public string? LineContent { get; set; }

    public string? CallSign { get; set; }

    public string? DepPort { get; set; }

    public string? OffBlockRaw { get; set; }

    public string? LoadId { get; set; }

    public bool? Deletion { get; set; }

    public int? OwnerId { get; set; }

    public DateTime? OffBlock { get; set; }

    public int? DepartureAirportId { get; set; }

    public int? AircraftId { get; set; }
}
