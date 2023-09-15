using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCrashReportHfd
{
    public int? DepartmentId { get; set; }

    public string? CrashNumber { get; set; }

    public string? Cadnumber { get; set; }

    public string CrashType { get; set; } = null!;

    public DateTime? CrashOn { get; set; }

    public string? ReportWriter { get; set; }

    public string? LastEditedBy { get; set; }

    public string? LastActivity { get; set; }

    public string? InvestigativeStatus { get; set; }

    public int? CrashStatusId { get; set; }

    public string? Cstatus { get; set; }

    public int? ReportStatusId { get; set; }

    public string? Rstatus { get; set; }
}
