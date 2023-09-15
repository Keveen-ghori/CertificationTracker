using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentOtherFactor
{
    public decimal IncidentOtherFactorsId { get; set; }

    public decimal? IncidentId { get; set; }

    public string? ContributingFactorLst { get; set; }

    public string? WeatherConditions { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsCurrentIrrecord { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public virtual Incident? Incident { get; set; }
}
