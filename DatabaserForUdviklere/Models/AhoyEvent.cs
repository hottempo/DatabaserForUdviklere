using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class AhoyEvent
{
    public int Id { get; set; }

    public int? VisitId { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Properties { get; set; }

    public DateTime? Time { get; set; }
}
