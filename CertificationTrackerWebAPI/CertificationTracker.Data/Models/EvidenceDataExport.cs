using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class EvidenceDataExport
{
    public string? Location { get; set; }

    public string? CaseNumber { get; set; }

    public string? FirstName { get; set; }

    public DateTime? AddedOn { get; set; }

    public string? PropertyDescription { get; set; }
}
