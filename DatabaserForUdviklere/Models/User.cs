using System;
using System.Collections.Generic;
using System.Net;

namespace DatabaserForUdviklere.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string EncryptedPassword { get; set; } = null!;

    public string? ResetPasswordToken { get; set; }

    public DateTime? ResetPasswordSentAt { get; set; }

    public DateTime? RememberCreatedAt { get; set; }

    public int SignInCount { get; set; }

    public DateTime? CurrentSignInAt { get; set; }

    public DateTime? LastSignInAt { get; set; }

    public IPAddress? CurrentSignInIp { get; set; }

    public IPAddress? LastSignInIp { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Username { get; set; }

    public int? OwnerId { get; set; }

    public int? DefaultRoleId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public int? CountryId { get; set; }

    public string? PhoneOffice { get; set; }

    public string? PhoneMobile { get; set; }

    public string? Initials { get; set; }

    public string? EmployeeNo { get; set; }

    public string? SocSecNo { get; set; }

    public string? CertificateNo { get; set; }

    public DateOnly? PregDeclaredAt { get; set; }

    public string? Base { get; set; }

    public bool? PregGrounded { get; set; }

    public string? OldPassword { get; set; }

    public string? LoadId { get; set; }

    public int? RolesMask { get; set; }

    public bool? HasCompletedFirstLogin { get; set; }

    public string? Nationality { get; set; }

    public int FailedAttempts { get; set; }

    public string? UnlockToken { get; set; }

    public DateTime? LockedAt { get; set; }

    public DateTime? LatestFlightAt { get; set; }

    public double? RadFullYear { get; set; }

    public double? RadCalYear { get; set; }

    public double? RadPregnant { get; set; }

    public double? RadTotal { get; set; }

    public DateTime? RadUpdatedAt { get; set; }

    public string? SsoIdpId { get; set; }

    public string? SsoIdpIp { get; set; }

    public string? SsoToken { get; set; }

    public DateTime? SsoTokenCreatedAt { get; set; }

    public DateTime? SsoSignedInAt { get; set; }

    public string? AuthenticationToken { get; set; }

    public virtual ICollection<MailSubscription> MailSubscriptions { get; set; } = new List<MailSubscription>();
}
