using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class FlightRelation
{
    public int Id { get; set; }

    public int? FlightId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public decimal? UserRadiationAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? SecondaryRoleId { get; set; }

    public bool? FlyingPilot { get; set; }
}
