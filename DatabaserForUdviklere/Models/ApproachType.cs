using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class ApproachType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
