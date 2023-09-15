using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppAoffenseOp
{
    public decimal? IncidentId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DeptId { get; set; }

    public string? Name { get; set; }

    public string? OffenseGroup { get; set; }

    public string? Classification { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? Offense { get; set; }

    public string? Ucrcode { get; set; }

    public decimal? StolenValue { get; set; }
}
