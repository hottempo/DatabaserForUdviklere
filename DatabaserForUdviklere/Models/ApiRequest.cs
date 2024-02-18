using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class ApiRequest
{
    public int Id { get; set; }

    public int? OwnerId { get; set; }

    public string? Task { get; set; }

    public string? Params { get; set; }

    public string? HttpStatusCode { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Owner? Owner { get; set; }
}
