using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class MailSubscription
{
    public int Id { get; set; }

    public int? MailType { get; set; }

    public int? UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual User? User { get; set; }
}
