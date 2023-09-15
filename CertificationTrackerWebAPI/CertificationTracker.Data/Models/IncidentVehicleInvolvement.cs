using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentVehicleInvolvement
{
    public decimal IncidentVehicleInvolvementId { get; set; }

    public decimal IncidentId { get; set; }

    public decimal? Mvid { get; set; }

    public decimal? NonVerifiedVehicleId { get; set; }

    public int? AutoTheftCode { get; set; }

    public int? VehicleInvolvementCode { get; set; }

    public decimal? InvolvementLocationId { get; set; }

    public int? TypeofStolenVehicle { get; set; }

    public int? ReasonNotTowedCode { get; set; }

    public int? OwnerNotifiedBy { get; set; }

    public decimal? PersonClaimingVehicle { get; set; }

    public int? LocationOfEvidence { get; set; }

    public decimal? RecoveredFromPersonId { get; set; }

    public int? StolenRecoveredWhere { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public Guid? UniqueId { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Source { get; set; }

    public string? Comment { get; set; }

    public bool? IsKeyInVehicle { get; set; }

    public bool? IsWeaponInVehicle { get; set; }

    public bool? IsCarJacking { get; set; }

    public bool? IsVehicleEnteredIntoCollect { get; set; }

    public string? CollectNumber { get; set; }

    public string? Ncicnumber { get; set; }

    public DateTime? DateNcicentered { get; set; }

    public string? NcicenteredOperator { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public DateTime? InvolvementDateTime { get; set; }

    public bool? WereThePlatesRecoveredWithVehicle { get; set; }

    public bool? WasOtherPropertyRecovered { get; set; }

    public bool? WasVehicleTowed { get; set; }

    public bool? IsOwnerNotified { get; set; }

    public DateTime? DateOwnerNotified { get; set; }

    public string? CollectCancellationNum { get; set; }

    public string? OutofTownCaseNumber { get; set; }

    public string? CollectLocateMsgnum { get; set; }

    public bool? WasLocateSenttoOutOfTownAgency { get; set; }

    public decimal? EstimatedVehicleValue { get; set; }

    public string? DamageAdditionalDescription { get; set; }

    public string? MissingPartsDescription { get; set; }

    public bool? IsBurned { get; set; }

    public bool? IsSuspectArson { get; set; }

    public bool? WereDoorsLocked { get; set; }

    public string? InsuranceCompanyName { get; set; }

    public bool? OwnerAvailableForCourt { get; set; }

    public bool? WasArrestMadeOnRecovery { get; set; }

    public bool? Nciccancelled { get; set; }

    public DateTime? DateNciccancelled { get; set; }

    public string? NciccancelledOperator { get; set; }

    public string? RecoveryOfficer { get; set; }

    public bool? IsEvidence { get; set; }

    public string? RecoveredataPawnShop { get; set; }

    public bool? IsJdc18required { get; set; }

    public decimal? DamagedValue { get; set; }

    public DateTime? InvolvementDateTo { get; set; }

    public decimal? TowRequestId { get; set; }

    public int? NibrslossType { get; set; }

    public bool? IsAddedByQa { get; set; }

    public virtual RefIncidentReferenceDatum? AutoTheftCodeNavigation { get; set; }

    public virtual ICollection<HelpQueryVehicleInvolvement> HelpQueryVehicleInvolvements { get; set; } = new List<HelpQueryVehicleInvolvement>();

    public virtual Incident Incident { get; set; } = null!;

    public virtual ICollection<IncidentPersonInvolvement> IncidentPersonInvolvements { get; set; } = new List<IncidentPersonInvolvement>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentRelatedAttachment> IncidentRelatedAttachments { get; set; } = new List<IncidentRelatedAttachment>();

    public virtual Mstrlocation? InvolvementLocation { get; set; }

    public virtual RefIncidentReferenceDatum? LocationOfEvidenceNavigation { get; set; }

    public virtual Mstrvehicle? Mv { get; set; }

    public virtual NibrsreferenceDatum? NibrslossTypeNavigation { get; set; }

    public virtual NonVerifiedCallVehicle? NonVerifiedVehicle { get; set; }

    public virtual DepartmentEmployee? OwnerNotifiedByNavigation { get; set; }

    public virtual Mstrperson? PersonClaimingVehicleNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? ReasonNotTowedCodeNavigation { get; set; }

    public virtual Mstrperson? RecoveredFromPerson { get; set; }

    public virtual RefIncidentReferenceDatum? StolenRecoveredWhereNavigation { get; set; }

    public virtual TowRequest? TowRequest { get; set; }

    public virtual RefIncidentReferenceDatum? TypeofStolenVehicleNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? VehicleInvolvementCodeNavigation { get; set; }
}
