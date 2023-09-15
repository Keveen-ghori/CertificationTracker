using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptLarcenyAuto
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? IncidentReportType { get; set; }

    public string? ActAttempt { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public string LarcenyType { get; set; } = null!;
}
