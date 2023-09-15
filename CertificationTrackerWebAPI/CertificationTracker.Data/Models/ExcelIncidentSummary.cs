using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ExcelIncidentSummary
{
    public string? DepartmentName { get; set; }

    public string? ReportedEmployee { get; set; }

    public string? Cadnumber { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? IncidentReportType { get; set; }

    public string? PickUpCategoryGroup { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public string? IncidentStatus { get; set; }

    public string? ReportStatus { get; set; }

    public string? HbfinialCallType { get; set; }

    public string? CallPriority { get; set; }

    public string? HitgislayerName { get; set; }

    public string? HitgeometryName { get; set; }

    public string? StreetName { get; set; }
}
