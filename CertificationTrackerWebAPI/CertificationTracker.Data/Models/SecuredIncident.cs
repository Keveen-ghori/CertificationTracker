using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SecuredIncident
{
    public decimal IndividualSecurityToUserId { get; set; }

    public int? GrantedByEmployeeId { get; set; }

    public decimal? ApplicationTypePk { get; set; }

    public string? Reason { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? IncidentNumber { get; set; }

    public string? OrgName { get; set; }
}
