using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class ThresholdExceedMailTemplate
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public int? ThresholdPregnant { get; set; }

    public int? ThresholdNonpregnant { get; set; }

    public string? AdminText { get; set; }

    public string? PregnantText { get; set; }

    public string? NonpregnantText { get; set; }

    public bool? SendToPregnant { get; set; }

    public bool? SendToNonpregnant { get; set; }

    public bool? IsDefault { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Owner? Owner { get; set; }
}
