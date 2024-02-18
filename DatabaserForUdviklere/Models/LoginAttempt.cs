using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class LoginAttempt
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? PasswordStart { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
