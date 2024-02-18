using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class AhoyVisit
{
    public int Id { get; set; }

    public string? VisitToken { get; set; }

    public string? VisitorToken { get; set; }

    public int? UserId { get; set; }

    public string? Ip { get; set; }

    public string? UserAgent { get; set; }

    public string? Referrer { get; set; }

    public string? ReferringDomain { get; set; }

    public string? LandingPage { get; set; }

    public string? Browser { get; set; }

    public string? Os { get; set; }

    public string? DeviceType { get; set; }

    public string? Country { get; set; }

    public string? Region { get; set; }

    public string? City { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? UtmSource { get; set; }

    public string? UtmMedium { get; set; }

    public string? UtmTerm { get; set; }

    public string? UtmContent { get; set; }

    public string? UtmCampaign { get; set; }

    public string? AppVersion { get; set; }

    public string? OsVersion { get; set; }

    public string? Platform { get; set; }

    public DateTime? StartedAt { get; set; }
}
