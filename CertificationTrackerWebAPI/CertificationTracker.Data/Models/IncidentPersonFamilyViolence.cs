using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentPersonFamilyViolence
{
    public decimal IncidentPersonFamilyViolenceId { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public int? ViolenceStatusCode { get; set; }

    public int? RelationshiptoVictim { get; set; }

    public int? LiquorDrugsInvolvedCode { get; set; }

    public int? InjuryCode { get; set; }

    public string? TransferOffenseCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual RefIncidentReferenceDatum? InjuryCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? LiquorDrugsInvolvedCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? RelationshiptoVictimNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? ViolenceStatusCodeNavigation { get; set; }
}
