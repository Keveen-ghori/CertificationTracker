using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentPersonWitnessDetail
{
    public decimal IncidentPersonWitnessDetailId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public DateTime? WitnessDate { get; set; }

    public string? WitnessLocationDescription { get; set; }

    public bool? IsWitnessWillTestify { get; set; }

    public string? WitnessAccountDescription { get; set; }

    public string? WitnessSpecialCondition { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }
}
