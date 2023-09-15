using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrmonthlyArson1bSelectClearance
{
    public int? DepartmentId { get; set; }

    public string? Department { get; set; }

    public int UcrcodeId { get; set; }

    public string? Ucrcode { get; set; }

    public decimal IncidentId { get; set; }

    public bool? IsPrimary { get; set; }

    public int? IncidentStatusId { get; set; }

    public int OffenseReported { get; set; }

    public int Juvenile { get; set; }

    public int Unfounded { get; set; }

    public int ClearedByArrest { get; set; }

    public DateTime? ClearanceDate { get; set; }
}
