using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class PreviousEmployment
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public DateOnly? AccumulatedAt { get; set; }

    public double? TotalHours { get; set; }

    public double? SimulatorHours { get; set; }

    public double? PicHours { get; set; }

    public double? FoHours { get; set; }

    public double? IfrHours { get; set; }

    public double? NightHours { get; set; }

    public double? InstructorHours { get; set; }

    public double? StudentHours { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
