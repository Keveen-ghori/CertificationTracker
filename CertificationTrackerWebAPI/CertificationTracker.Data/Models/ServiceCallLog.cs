using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ServiceCallLog
{
    public decimal ServiceCallLogId { get; set; }

    public decimal? IncidentServiceCallId { get; set; }

    public decimal? CadeventUnitActionId { get; set; }

    public DateTime? ActionDateTime { get; set; }

    public string? ActionDescription { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public virtual ServiceCall? IncidentServiceCall { get; set; }
}
