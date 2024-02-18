using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class ActiveAdminComment
{
    public int Id { get; set; }

    public string? Namespace { get; set; }

    public string? Body { get; set; }

    public int? ResourceId { get; set; }

    public string? ResourceType { get; set; }

    public int? AuthorId { get; set; }

    public string? AuthorType { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
