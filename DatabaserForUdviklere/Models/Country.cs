using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? IsoCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Province { get; set; }

    public string? Iso2Code { get; set; }

    public int Status { get; set; }
}
