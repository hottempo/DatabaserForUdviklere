using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class Owner
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? StreetAddress1 { get; set; }

    public string? StreetAddress2 { get; set; }

    public string? PostalCode { get; set; }

    public string? Prefix { get; set; }

    public int? OwnerTypeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? CountryId { get; set; }

    public string? City { get; set; }

    public string? FtpUsername { get; set; }

    public string? FtpPassword { get; set; }

    public string? StorageType { get; set; }

    public bool? LockoutUsers { get; set; }

    public int? ThresholdLow { get; set; }

    public int? ThresholdPregnantLow { get; set; }

    public int? ThresholdHigh { get; set; }

    public int? ThresholdPregnantHigh { get; set; }

    public string? EmailRecipients { get; set; }

    public bool? ProcessFlightAware { get; set; }

    public string? IcaoCode { get; set; }

    public string? DefaultUserEmail { get; set; }

    public bool? SendDailyMails { get; set; }

    public bool? PublishRrtRad { get; set; }

    public bool? Active { get; set; }

    public string? AirlineApiUserIdentifier { get; set; }

    public string? AirlineApiUserSecret { get; set; }

    public bool? AirlineApiPostRadiation { get; set; }

    public string? FlightDataSource { get; set; }

    public int? CsvSeparators { get; set; }

    public DateOnly? EarlyBoundary { get; set; }

    public string? SecretIdentifier { get; set; }

    public virtual ICollection<ApiRequest> ApiRequests { get; set; } = new List<ApiRequest>();

    public virtual ICollection<ThresholdExceedMailTemplate> ThresholdExceedMailTemplates { get; set; } = new List<ThresholdExceedMailTemplate>();
}
