using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptClassificationSearch
{
    public int? DepartmentId { get; set; }

    public decimal? IncidentId { get; set; }

    public string? ViewIncidentUrl { get; set; }

    public string? UniqueId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? UcrcodeId { get; set; }

    public string? Classification { get; set; }

    public int? NibrscodeId { get; set; }

    public string? NibrsCode { get; set; }

    public string? OffenseName { get; set; }

    public string? ReportWriter { get; set; }

    public string? Location { get; set; }
}
