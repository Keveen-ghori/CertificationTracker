using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecurityObjectTouserRole
{
    public int SecurityObjectTouserId { get; set; }

    public int? UserId { get; set; }

    public int? SecurityObjectId { get; set; }

    public int? SecurityRoleId { get; set; }

    public string? Permission { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? ApplytoInvolvementCode { get; set; }

    public virtual SecurityObject? SecurityObject { get; set; }

    public virtual SecurityRole? SecurityRole { get; set; }

    public virtual User? User { get; set; }
}
