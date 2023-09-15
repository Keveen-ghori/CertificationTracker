using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptEvadePpawcount
{
    public decimal IncidentId { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public int? DepartmentId { get; set; }

    public int? IncidentStatusId { get; set; }

    public string? IncidentNumber { get; set; }

    public string? IncidentType { get; set; }
}
