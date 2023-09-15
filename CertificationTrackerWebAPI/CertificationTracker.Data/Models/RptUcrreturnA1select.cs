using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrreturnA1select
{
    public int? UcrcodeId { get; set; }

    public decimal IncidentId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? Department { get; set; }

    public int? OffenseReported { get; set; }

    public bool? IsPrimary { get; set; }

    public int? DepartmentId { get; set; }

    public int? IncidentStatusId { get; set; }

    public int Unfounded { get; set; }

    public int ClearedByArrest { get; set; }

    public int Juvenile { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }
}
