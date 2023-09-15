using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class WarrantGeneratedReport
{
    public decimal WarrantGeneratedReportId { get; set; }

    public decimal? WarrantId { get; set; }

    public int? WarrantStatus { get; set; }

    public int? ReportStatus { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? ReportContentPath { get; set; }

    public int? Sequence { get; set; }

    public decimal? RmsworkFlowControllerId { get; set; }

    public virtual SysApplicationStatus? ReportStatusNavigation { get; set; }

    public virtual RmsworkFlowController? RmsworkFlowController { get; set; }

    public virtual Warrant? Warrant { get; set; }

    public virtual SysApplicationStatus? WarrantStatusNavigation { get; set; }
}
