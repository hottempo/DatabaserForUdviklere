using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Event
{
    public int Id { get; set; }

    public string? EventType { get; set; }

    public int? LogLevel { get; set; }

    public string? Payload { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Info { get; set; }
}
