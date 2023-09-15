using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class UserToken
{
    public int UserTokenId { get; set; }

    public int UserId { get; set; }

    public Guid Token { get; set; }

    public bool? Expired { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? AddedName { get; set; }
    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiry { get; set; }

    public virtual User User { get; set; } = null!;
}
