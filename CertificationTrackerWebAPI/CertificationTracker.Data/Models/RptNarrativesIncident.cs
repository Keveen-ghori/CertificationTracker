using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptNarrativesIncident
{
    public int? DepartmentId { get; set; }

    public string? IncidentNumberSup { get; set; }

    public string? Cadnumber { get; set; }

    public string? IncidentNumber { get; set; }

    public int? SupplementSeq { get; set; }

    public string? ReportStatus { get; set; }

    public string? InvestigativeStatus { get; set; }

    public string? FullName { get; set; }

    public string? IncidentReportType { get; set; }

    public string? PickUpCategoryGroup { get; set; }

    public string? PickUpClassification { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public DateTime? IncidentOccuredDtend { get; set; }

    public string? Narrative { get; set; }

    public int? NarCheck { get; set; }

    public int? CallTypeId { get; set; }
}
