using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrmonthlyArson2bGroupArson
{
    public string? Name { get; set; }

    public string? OffenseGroup { get; set; }

    public string? Classification { get; set; }

    public string? Ucrcode { get; set; }

    public int? IncidentOccuredDtstart { get; set; }

    public int? DeptId { get; set; }

    public int? Department { get; set; }

    public int DepartmentId { get; set; }

    public int? SumOffenseReported { get; set; }

    public int? EditedOn { get; set; }

    public int? Unfounded { get; set; }

    public int? ClearedByArrest { get; set; }

    public int? Juvenile { get; set; }

    public int? UninhabitedStructures { get; set; }

    public int? TotalValue { get; set; }
}
