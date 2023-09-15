using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppApropTypeOpveh
{
    public int? DepartmentId { get; set; }

    public int? DeptId { get; set; }

    public string? Name { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public decimal? StolenValue { get; set; }

    public decimal? RecoveredValue { get; set; }

    public string Rptcategory { get; set; } = null!;
}
