using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptUcrmonthlyArson3getPropertyValue
{
    public int? DepartmentId { get; set; }

    public string? Department { get; set; }

    public decimal? IncidentId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? PropertyInvolvementCode { get; set; }

    public decimal? PropertyValue { get; set; }
}
