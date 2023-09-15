using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class PrtPropertyReceipt2propertyInvolvement
{
    public int? DepartmentId { get; set; }

    public decimal? IncidentId { get; set; }

    public decimal? Mppid { get; set; }

    public string? IncidentNumber { get; set; }

    public int? IncidentStatusId { get; set; }

    public DateTime? IncidentOccuredDtstart { get; set; }

    public string? Involvement { get; set; }

    public decimal? OwnerPersonId { get; set; }

    public decimal? OwnerOrgId { get; set; }

    public int Abandoned { get; set; }

    public int Evidence { get; set; }

    public int Found { get; set; }

    public int Hold { get; set; }

    public int Recovered { get; set; }

    public int Safekeep { get; set; }

    public int Surrendered { get; set; }

    public string? AbandonedLoc { get; set; }

    public string? FoundLoc { get; set; }

    public string? RecoveredLoc { get; set; }

    public string? SeizedLoc { get; set; }

    public DateTime? SeizedDateTime { get; set; }

    public string? RecovFrom { get; set; }

    public string? LocationDetailDisplayString { get; set; }
}
