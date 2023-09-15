using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppAoffenseOp7x
{
    public int? DepartmentId { get; set; }

    public int? DeptId { get; set; }

    public int? Name { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? StolenRecoveredWhere { get; set; }

    public int? OffenseCount { get; set; }
}
