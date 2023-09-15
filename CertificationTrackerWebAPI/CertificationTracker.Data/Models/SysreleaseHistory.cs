using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysreleaseHistory
{
    public int ReleaseId { get; set; }

    public string? ReleaseVersion { get; set; }

    public DateTime? AddedOn { get; set; }
}
