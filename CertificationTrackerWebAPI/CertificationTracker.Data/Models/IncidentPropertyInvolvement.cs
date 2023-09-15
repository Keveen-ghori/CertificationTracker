using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentPropertyInvolvement
{
    public decimal IncidentPropertyInvolvementId { get; set; }

    public decimal IncidentId { get; set; }

    public decimal? Mppid { get; set; }

    public decimal? RelatedPersonInvolvementId { get; set; }

    public decimal? RelatedVehicleInvolvementId { get; set; }

    public int? PropertyInvolvementCode { get; set; }

    public decimal? InvolvemenLocationId { get; set; }

    public decimal? OwnerPersonId { get; set; }

    public decimal? OwnerOrgId { get; set; }

    public decimal? RecoveredFromPersonId { get; set; }

    public decimal? ReturnedToPersonId { get; set; }

    public int? CustodyReason { get; set; }

    public int? SecuredLocation { get; set; }

    public int? PropertyLocker { get; set; }

    public int? StolenRecoveredWhere { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Comment { get; set; }

    public string? Source { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? CurrencyType { get; set; }

    public short? Countof1 { get; set; }

    public short? Countof2 { get; set; }

    public short? Countof5 { get; set; }

    public short? Countof10 { get; set; }

    public short? Countof20 { get; set; }

    public short? Countof50 { get; set; }

    public short? Countof100 { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalAmountofCash { get; set; }

    public bool? IsJdc18required { get; set; }

    public string? RecoveredataPawnShop { get; set; }

    public bool? IsDamaged { get; set; }

    public string? DamageDescription { get; set; }

    public bool? IsBurned { get; set; }

    public bool? SuspectArsonByUcrdefinition { get; set; }

    public DateTime? InvolvementDateTime { get; set; }

    public DateTime? ReturnedToPersonDateTime { get; set; }

    public int? ItemCount { get; set; }

    public decimal? TotalValueOfItems { get; set; }

    public int? RecoverdNumberOfItems { get; set; }

    public decimal? RecoveredValue { get; set; }

    public decimal? DamagedValue { get; set; }

    public bool? ReturnedToOwner { get; set; }

    public DateTime? InvolvementDateTo { get; set; }

    public int? NibrslossType { get; set; }

    public bool? IsAddedByQa { get; set; }

    public bool? NotTakenIntoCustody { get; set; }

    public string? ReasonForNotTakenIntoCustody { get; set; }

    public virtual RefIncidentReferenceDatum? CustodyReasonNavigation { get; set; }

    public virtual ICollection<HelpQueryPropertyInvolvement> HelpQueryPropertyInvolvements { get; set; } = new List<HelpQueryPropertyInvolvement>();

    public virtual Incident Incident { get; set; } = null!;

    public virtual ICollection<IncidentPropertyDrugDetail> IncidentPropertyDrugDetails { get; set; } = new List<IncidentPropertyDrugDetail>();

    public virtual ICollection<IncidentRelatedAttachment> IncidentRelatedAttachments { get; set; } = new List<IncidentRelatedAttachment>();

    public virtual Mstrlocation? InvolvemenLocation { get; set; }

    public virtual Mstrproperty? Mpp { get; set; }

    public virtual NibrsreferenceDatum? NibrslossTypeNavigation { get; set; }

    public virtual Mstrorganization? OwnerOrg { get; set; }

    public virtual Mstrperson? OwnerPerson { get; set; }

    public virtual RefIncidentReferenceDatum? PropertyInvolvementCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? PropertyLockerNavigation { get; set; }

    public virtual Mstrperson? RecoveredFromPerson { get; set; }

    public virtual IncidentPersonInvolvement? RelatedPersonInvolvement { get; set; }

    public virtual IncidentVehicleInvolvement? RelatedVehicleInvolvement { get; set; }

    public virtual Mstrperson? ReturnedToPerson { get; set; }

    public virtual RefIncidentReferenceDatum? SecuredLocationNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? StolenRecoveredWhereNavigation { get; set; }
}
