using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class VwAircraft
{
    public int? Id { get; set; }

    public string? RegistrationCode { get; set; }

    public string? ManName { get; set; }

    public string? ModName { get; set; }
}
