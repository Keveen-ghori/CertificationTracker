using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptLarcenyAutoArrest
{
    public int? DepartmentId { get; set; }

    public decimal ArrestId { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? IncidentLocation { get; set; }

    public string? FullName { get; set; }

    public DateTime? ArrestDateTime { get; set; }

    public DateTime? Dob { get; set; }

    public string? ArresteeRes { get; set; }

    public decimal? Mpid { get; set; }

    public string LarcenyType { get; set; } = null!;
}
