using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCaseSumOpx
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public int Clarr { get; set; }

    public int Clarrj { get; set; }

    public int Clexepa { get; set; }

    public int Clexepj { get; set; }

    public int Open { get; set; }

    public int Unfd { get; set; }

    public int? InvestigativeStatusId { get; set; }

    public string? InvestigativeStatus { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }

    public DateTime? UcraddedOn { get; set; }

    public string? ComplainantLastName { get; set; }

    public string? ComplainantFirstName { get; set; }

    public int? IncidentStatusId { get; set; }

    public string? Status { get; set; }
}
