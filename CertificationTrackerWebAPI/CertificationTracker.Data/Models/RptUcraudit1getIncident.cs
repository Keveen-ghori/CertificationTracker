using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcraudit1getIncident
{
    public int? DepartmentId { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? LocationShortDisplayString { get; set; }

    public int? IncidentStatusId { get; set; }

    public string? ClearanceCode { get; set; }

    public string? Status { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? FullName { get; set; }

    public decimal? RefItemId { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }
}
