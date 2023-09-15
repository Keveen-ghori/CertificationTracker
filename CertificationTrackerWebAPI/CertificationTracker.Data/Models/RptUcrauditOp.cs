using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrauditOp
{
    public int? DepartmentId { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? LocationShortDisplayString { get; set; }

    public string? ClearanceCode { get; set; }

    public string? Status { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? FullName { get; set; }

    public decimal? StolenValue { get; set; }

    public decimal? RecoveredValue { get; set; }
}
