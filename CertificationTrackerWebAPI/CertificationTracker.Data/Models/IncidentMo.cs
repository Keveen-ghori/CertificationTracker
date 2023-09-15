using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentMo
{
    public decimal IncidentMoid { get; set; }

    public decimal? IncidentId { get; set; }

    public int? Motype { get; set; }

    public string? Modescription { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? Mo { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual RefIncidentReferenceDatum? MotypeNavigation { get; set; }
}
