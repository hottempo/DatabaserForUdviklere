using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class CustomerStat
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public int? CrewOps { get; set; }

    public int? ActiveCrew { get; set; }

    public int? ActiveAc { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Month { get; set; }

    public int? Flights { get; set; }

    public int? CrewOpsWithRad { get; set; }

    public int? CrewSimulatorOps { get; set; }
}
