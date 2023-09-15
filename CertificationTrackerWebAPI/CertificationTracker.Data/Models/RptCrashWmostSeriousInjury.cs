using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCrashWmostSeriousInjury
{
    public decimal CrashId { get; set; }

    public int? DepartmentId { get; set; }

    public int? CrashStatusId { get; set; }

    public string? CrashNumber { get; set; }

    public DateTime? CrashOccuredDtstart { get; set; }

    public string? CrashType { get; set; }

    public string? Injury { get; set; }
}
