using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class UserLink
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? LinkedUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
