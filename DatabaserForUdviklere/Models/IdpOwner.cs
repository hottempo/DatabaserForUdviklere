using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class IdpOwner
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public int? IdpId { get; set; }

    public string? Token { get; set; }
}
