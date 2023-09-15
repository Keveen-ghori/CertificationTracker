using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ReportHelper
{
    public decimal ReportHelperId { get; set; }

    public int? ReportDefinitionId { get; set; }

    public string? ReferenceTableName { get; set; }

    public decimal? RefItemId { get; set; }

    public string? ReportGroup { get; set; }

    public string? ReportCategory { get; set; }

    public string? ReportName { get; set; }

    public virtual ReportDefinition? ReportDefinition { get; set; }
}
