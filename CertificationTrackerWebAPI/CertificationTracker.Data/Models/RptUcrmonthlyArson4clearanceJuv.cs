using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrmonthlyArson4clearanceJuv
{
    public int? DepartmentId { get; set; }

    public string? Department { get; set; }

    public string? OffenseGroup { get; set; }

    public string? Classification { get; set; }

    public int UcrcodeId { get; set; }

    public string? Ucrcode { get; set; }

    public int OffenseReported { get; set; }

    public int Unfounded { get; set; }

    public int ClearedByArrest { get; set; }

    public int? Juvenile { get; set; }

    public int UninhabitedStructures { get; set; }

    public int PropertyValue { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public int? ReportDefinitionId { get; set; }
}
