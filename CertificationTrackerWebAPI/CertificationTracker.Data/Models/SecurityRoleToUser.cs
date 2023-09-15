using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecurityRoleToUser
{
    public decimal SecurityRoleToUserId { get; set; }

    public int? UserId { get; set; }

    public int? SecurityRoleId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual SecurityRole? SecurityRole { get; set; }

    public virtual User? User { get; set; }
}
