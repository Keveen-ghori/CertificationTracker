using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptDrugArrestCount
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public string? EntryNumberType { get; set; }

    public DateTime? Dob { get; set; }

    public string JuvOrAdult { get; set; } = null!;

    public string CustNonCust { get; set; } = null!;
}
