using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashGeneratedReport
{
    public decimal CrashGeneratedReportId { get; set; }

    public decimal? CrashId { get; set; }

    public int? CrashStatus { get; set; }

    public int? ReportStatus { get; set; }

    public byte[]? ReportContent { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? ReportContentPath { get; set; }

    public int? Sequence { get; set; }

    public decimal? RmsworkFlowControllerId { get; set; }

    public virtual Crash? Crash { get; set; }

    public virtual SysApplicationStatus? CrashStatusNavigation { get; set; }

    public virtual SysApplicationStatus? ReportStatusNavigation { get; set; }

    public virtual RmsworkFlowController? RmsworkFlowController { get; set; }
}
