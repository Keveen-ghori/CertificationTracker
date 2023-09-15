using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ExcelCrashSummary
{
    public string? Department { get; set; }

    public string? CrashNumber { get; set; }

    public string? Cadnumber { get; set; }

    public string? AdminStatus { get; set; }

    public string? CrashStatus { get; set; }

    public string Duicrash { get; set; } = null!;

    public string? CrashType { get; set; }

    public DateTime? CrashTime { get; set; }

    public string? ServiceCallType { get; set; }

    public string? ReportedEmployee { get; set; }

    public string? EventTypeCategory { get; set; }

    public string? HitgislayerName { get; set; }

    public string? HitgeometryName { get; set; }

    public string? StreetName { get; set; }
}
