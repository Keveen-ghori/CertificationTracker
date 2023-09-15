using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptRecentlyFiledCrash
{
    public int? DepartmentId { get; set; }

    public string? CrashNumber { get; set; }

    public string? CrashType { get; set; }

    public string? Status { get; set; }

    public DateTime? CrashStart { get; set; }

    public string? ReportWriter { get; set; }

    public string? ReportingUnit { get; set; }

    public DateTime? FiledDate { get; set; }

    public string? CrashLocation { get; set; }
}
