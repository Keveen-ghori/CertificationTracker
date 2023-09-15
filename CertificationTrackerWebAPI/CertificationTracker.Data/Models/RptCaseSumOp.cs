using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCaseSumOp
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public string Clarr { get; set; } = null!;

    public string Clarrj { get; set; } = null!;

    public string Clexepa { get; set; } = null!;

    public string Clexepj { get; set; } = null!;

    public string Open { get; set; } = null!;

    public string Unfd { get; set; } = null!;

    public string Ucrstatus { get; set; } = null!;

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
