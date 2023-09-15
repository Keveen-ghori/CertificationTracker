using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentPersonVictimDetail
{
    public decimal IncidentPersonVictimDetailId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public int? SexAssaultVictimPenetraType { get; set; }

    public int? PenetrationMethodCode { get; set; }

    public decimal? PerpetratorId { get; set; }

    public bool? IsIncapableofConsent { get; set; }

    public bool? IsIncest { get; set; }

    public bool? IsPublicSafetyPerson { get; set; }

    public bool? IsVictimShot { get; set; }

    public bool? IsVictimSeeksProsecution { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual RefIncidentReferenceDatum? PenetrationMethodCodeNavigation { get; set; }

    public virtual IncidentPersonInvolvement? Perpetrator { get; set; }

    public virtual RefIncidentReferenceDatum? SexAssaultVictimPenetraTypeNavigation { get; set; }
}
