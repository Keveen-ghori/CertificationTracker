using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class GetIncidentUcr
{
    public decimal IncidentId { get; set; }

    public int? DepartmentId { get; set; }

    public int? IncidentStatusId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? IncidentNumber { get; set; }

    public int? UcrcodeId { get; set; }

    public string? CategoryGroup { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public int? HierarchyRank { get; set; }

    public short? Classification { get; set; }

    public string? UcrmajorCode { get; set; }

    public string? IncidentReportType { get; set; }
}
