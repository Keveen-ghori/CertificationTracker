using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashVehicleAreaImpact
{
    public decimal? CrashVehicleInvolvementId { get; set; }

    public int? DamageAreaPoint { get; set; }

    public bool? IsInitialContactPoint { get; set; }

    public string? Description { get; set; }

    public string? ImageContentPath { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public decimal CrashVehicleAreaImpactId { get; set; }

    public virtual CrashVehicleInvolvement? CrashVehicleInvolvement { get; set; }

    public virtual RefCrashReferenceDatum? DamageAreaPointNavigation { get; set; }
}
