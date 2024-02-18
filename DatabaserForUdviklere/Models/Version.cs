using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Version
{
    public int Id { get; set; }

    public string ItemType { get; set; } = null!;

    public long ItemId { get; set; }

    public string Event { get; set; } = null!;

    public string? Whodunnit { get; set; }

    public string? Object { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? ObjectChanges { get; set; }
}
