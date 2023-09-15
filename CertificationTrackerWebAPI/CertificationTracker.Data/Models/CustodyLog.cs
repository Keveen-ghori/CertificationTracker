using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CustodyLog
{
    public decimal CustodyLogId { get; set; }

    public int? OfficerId { get; set; }

    public decimal? LocationId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public int? Block { get; set; }

    public int? Cell { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public DateTime? CustodyDateTime { get; set; }

    public string? Agency { get; set; }

    public string? Comments { get; set; }

    public virtual RefIncidentReferenceDatum? BlockNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? CellNavigation { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual Mstrlocation? Location { get; set; }

    public virtual DepartmentEmployee? Officer { get; set; }
}
