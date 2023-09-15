using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrreturnA4clearanceJuv
{
    public int? DepartmentId { get; set; }

    public string? Department { get; set; }

    public decimal IncidentId { get; set; }

    public int OffenseReported { get; set; }

    public int Unfounded { get; set; }

    public int ClearedByArrest { get; set; }

    public int? Juvenile { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }
}
