using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentForceInvolvement
{
    public decimal ForceInvolvementId { get; set; }

    public decimal IncidentId { get; set; }

    public int? ForceTypeCode { get; set; }

    public int? WeaponTypeCode { get; set; }

    public decimal? ForceWeaponUsedBy { get; set; }

    public decimal? PropertyId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Comment { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public virtual RefIncidentReferenceDatum? ForceTypeCodeNavigation { get; set; }

    public virtual IncidentPersonInvolvement? ForceWeaponUsedByNavigation { get; set; }

    public virtual Incident Incident { get; set; } = null!;

    public virtual Mstrproperty? Property { get; set; }

    public virtual RefIncidentReferenceDatum? WeaponTypeCodeNavigation { get; set; }
}
