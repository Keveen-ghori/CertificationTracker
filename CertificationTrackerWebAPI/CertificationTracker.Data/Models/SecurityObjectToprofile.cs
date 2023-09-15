using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecurityObjectToprofile
{
    public int SecurityObjectToprofileId { get; set; }

    public int? SecurityProfileId { get; set; }

    public int? SecurityObjectId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Permission { get; set; }

    public virtual SecurityObject? SecurityObject { get; set; }

    public virtual SecurityProfile? SecurityProfile { get; set; }
}
