using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrmonthlyArson5
{
    public string? Name { get; set; }

    public string? OffenseGroup { get; set; }

    public string? Classification { get; set; }

    public string? Ucrcode { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? DeptId { get; set; }

    public string? Department { get; set; }

    public int DepartmentId { get; set; }

    public int? SumOffenseReported { get; set; }

    public DateTime? EditedOn { get; set; }

    public int Unfounded { get; set; }

    public int ClearedByArrest { get; set; }

    public int Juvenile { get; set; }

    public int? UninhabitedStructures { get; set; }

    public decimal? PropertyValue { get; set; }

    public decimal? VehicleValue { get; set; }
}
