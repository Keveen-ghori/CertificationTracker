using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RptCaseSum1getClearanceDatum
{
    public int? DepartmentId { get; set; }

    public decimal IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public bool? IsPrimary { get; set; }

    public int? IncidentStatusId { get; set; }

    public int? Ucrclearance { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public int UcrcodeId { get; set; }

    public string? Ucrcode { get; set; }

    public string? UcrcodeDisplayName { get; set; }
}
