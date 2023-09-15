using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ExcelIncidentCrime
{
    public decimal? PrimaryIncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? Classification { get; set; }

    public string? Location { get; set; }

    public string? LocationDetailDisplayString { get; set; }

    public string Arrest { get; set; } = null!;

    public string? District { get; set; }
}
