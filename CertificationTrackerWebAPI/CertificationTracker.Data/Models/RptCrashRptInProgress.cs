using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCrashRptInProgress
{
    public int? DepartmentId { get; set; }

    public decimal AppId { get; set; }

    public string? AppNumber { get; set; }

    public string? Cadnumber { get; set; }

    public int IsSupplement { get; set; }

    public string? ReportType { get; set; }

    public string? WorkFlowName { get; set; }

    public string? Status { get; set; }

    public DateTime? OccurredDate { get; set; }

    public string? ReportWriter { get; set; }

    public string? Reviewer { get; set; }

    public string? ReportingUnit { get; set; }

    public DateTime? ReportCreated { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? Location { get; set; }
}
