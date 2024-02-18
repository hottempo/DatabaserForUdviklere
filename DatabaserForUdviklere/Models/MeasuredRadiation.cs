using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class MeasuredRadiation
{
    public int Id { get; set; }

    public DateTime? UtcTime { get; set; }

    public int? Corr1 { get; set; }

    public int? Corr2 { get; set; }

    public int? Corr3 { get; set; }

    public int? Corr4 { get; set; }

    public int? Corr5 { get; set; }

    public int? AvgCorr { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
