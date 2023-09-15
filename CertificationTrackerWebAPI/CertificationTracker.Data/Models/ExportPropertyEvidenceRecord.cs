using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ExportPropertyEvidenceRecord
{
    public string? Location { get; set; }

    public string? Case { get; set; }

    public string? Seq { get; set; }

    public string? Date { get; set; }

    public string? PropertyDescription { get; set; }

    public string? FoundSeized { get; set; }

    public string? SeizedReport { get; set; }

    public string? FelMisd { get; set; }

    public string? Status { get; set; }

    public string Id { get; set; } = null!;

    public decimal? Mppid { get; set; }

    public decimal? IncidentPropertyInvolvementId { get; set; }
}
