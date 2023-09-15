using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentForceReport
{
    public decimal IncidentForceReportId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? PoliceForceLocationCode { get; set; }

    public decimal? IncidentPersonInvolvementId { get; set; }

    public int? AppliedForceOfficerId { get; set; }

    public int? SupervisorOfOfficer { get; set; }

    public int? TaserTypeOfUse { get; set; }

    public string? SubjecAttitudeDesc { get; set; }

    public string? OfficerConditionDesc { get; set; }

    public string? SubjectConditionDesc { get; set; }

    public string? Narrative { get; set; }

    public string? OleoresinCapsicumFirstAid { get; set; }

    public string? OleoresinCapsicumMedicalCond { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? AdditionalReasonsForForce { get; set; }

    public string? Hospital { get; set; }

    public string? TreatingPhysician { get; set; }

    public string? EditedName { get; set; }

    public string? HeartConditionType { get; set; }

    public string? RespiratoryProblemType { get; set; }

    public short? PregnantMonths { get; set; }

    public bool? IsCurrentIrrecord { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public string? PoliceForceTypeCode { get; set; }

    public string? PoliceForceWeaponTypeCode { get; set; }

    public bool? IsForceAppliedToAnimal { get; set; }

    public DateTime? TaserDeploymentDateTime { get; set; }

    public string? TaserUnitNumber { get; set; }

    public int? TaserNumberOfCycles { get; set; }

    public string? MedicalTreatmentForTaser { get; set; }

    public bool? WasTaserEffective { get; set; }

    public string? PoliceForceResultCode { get; set; }

    public string? OtherTypeOfForce { get; set; }

    public string? OtherWeapon { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual IncidentPersonInvolvement? IncidentPersonInvolvement { get; set; }

    public virtual RefIncidentReferenceDatum? PoliceForceLocationCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? TaserTypeOfUseNavigation { get; set; }
}
