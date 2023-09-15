using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentGeneratedReport
{
    public decimal IncidentGeneratedReportId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? IncidentStatus { get; set; }

    public int? ReportStatus { get; set; }

    public byte[]? ReportContent { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? ReportContentPath { get; set; }

    public int? Sequence { get; set; }

    public decimal? RmsworkFlowControllerId { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual SysApplicationStatus? IncidentStatusNavigation { get; set; }

    public virtual SysApplicationStatus? ReportStatusNavigation { get; set; }

    public virtual RmsworkFlowController? RmsworkFlowController { get; set; }
}
