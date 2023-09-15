using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecurityProfile
{
    public int SecurityProfileId { get; set; }

    public string? Name { get; set; }

    public string? Comments { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual ICollection<SecurityObjectToprofile> SecurityObjectToprofiles { get; set; } = new List<SecurityObjectToprofile>();
}
