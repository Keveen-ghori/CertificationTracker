using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class IncidentReportTypeDetail
{
    public decimal IncidentReportTypeDetailId { get; set; }

    public decimal? IncidentId { get; set; }

    public int? DayNightCode { get; set; }

    public int? TypeofRobberyCode { get; set; }

    public int? TypeofLarcenyCode { get; set; }

    public int? TypeofIdentityTheftCode { get; set; }

    public int? TypeofForgeryCode { get; set; }

    public int? ValueRangeCode { get; set; }

    public int? PenetrationCode { get; set; }

    public int? MostSeriousIncidentInjuryCode { get; set; }

    public bool? IsPoliceUseForce { get; set; }

    public int? ActualAttemptedCode { get; set; }

    public int? LocationTypeCode { get; set; }

    public int? OfficerUsingForceId { get; set; }

    public int? FireTypeCode { get; set; }

    public int? PerpetratorSexCode { get; set; }

    public int? VictimSexCode { get; set; }

    public decimal? LocationOfIntendedProperty { get; set; }

    public int? ObjectofTheftCode { get; set; }

    public string? Value { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsForcedEntry { get; set; }

    public bool? IsResident { get; set; }

    public bool? IsHomeInvasion { get; set; }

    public bool? IsVictimShot { get; set; }

    public bool? IsVictimPef { get; set; }

    public bool? IsIncest { get; set; }

    public bool? WasSexAssaultCollected { get; set; }

    public bool? IsVictimIncapableConsent { get; set; }

    public bool? IsPerpetratorinSexOffenderReg { get; set; }

    public string? HeartConditions { get; set; }

    public string? RespiratoryProblems { get; set; }

    public string? TreatingPhysician { get; set; }

    public string? Hosptial { get; set; }

    public string? ForceApplicationResult { get; set; }

    public string? AdditionalReasons { get; set; }

    public string? WeaponMethodCode { get; set; }

    public bool? IsTargetedProperty { get; set; }

    public bool? WasTargetedPropertyOccupied { get; set; }

    public bool? WasPersonSeriouslyInjured { get; set; }

    public bool? WasAnyoneInjuredofFire { get; set; }

    public bool? WasInsuranceFraud { get; set; }

    public bool? IsAccelerantUsed { get; set; }

    public bool? IsCurrentIrrecord { get; set; }

    public decimal? PrimaryIncidentId { get; set; }

    public bool? IsCarJacking { get; set; }

    public bool? IsFamilyViolence { get; set; }

    public string? MethodofPenetrationCode { get; set; }

    public virtual RefIncidentReferenceDatum? ActualAttemptedCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? DayNightCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? FireTypeCodeNavigation { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual Mstrlocation? LocationOfIntendedPropertyNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? LocationTypeCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? MostSeriousIncidentInjuryCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? ObjectofTheftCodeNavigation { get; set; }

    public virtual DepartmentEmployee? OfficerUsingForce { get; set; }

    public virtual RefIncidentReferenceDatum? PenetrationCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? PerpetratorSexCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? TypeofForgeryCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? TypeofIdentityTheftCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? TypeofLarcenyCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? TypeofRobberyCodeNavigation { get; set; }

    public virtual RefIncidentReferenceDatum? ValueRangeCodeNavigation { get; set; }

    public virtual RefMstrinxreferenceDatum? VictimSexCodeNavigation { get; set; }
}
