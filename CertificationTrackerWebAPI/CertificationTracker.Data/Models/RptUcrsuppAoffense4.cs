using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrsuppAoffense4
{
    public int? DepartmentId { get; set; }

    public int? DeptId { get; set; }

    public string? Department { get; set; }

    public string? OffenseGroup { get; set; }

    public string? Classification { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? Offense { get; set; }

    public string? Ucrcode { get; set; }

    public decimal? StolenValue { get; set; }

    public decimal IncidentId { get; set; }

    public decimal? PropertyId { get; set; }
}
