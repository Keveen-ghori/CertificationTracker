using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCriminalHistoryOfficer
{
    public int? DepartmentId { get; set; }

    public string? ArrestNumber { get; set; }

    public string? IncidentNumber { get; set; }

    public string? ArrestingOfficer { get; set; }

    public string? ReportedOfficer { get; set; }
}
