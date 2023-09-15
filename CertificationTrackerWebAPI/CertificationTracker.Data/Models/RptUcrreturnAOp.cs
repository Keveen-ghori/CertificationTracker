using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrreturnAOp
{
    public string? Name { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }

    public string? Ucrcode { get; set; }

    public decimal? IncidentId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? Department { get; set; }

    public int? DeptId { get; set; }

    public int? DepartmentId { get; set; }

    public int? SumOffenseReported { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public int Unfounded { get; set; }

    public int ClearedByArrest { get; set; }

    public int Juvenile { get; set; }
}
