using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashPersonSummaryDatum
{
    public decimal CrashPersonInvolvementId { get; set; }

    public int? InjuryStatus { get; set; }

    public int? AlcoholTestStatus { get; set; }

    public int? AlcoholTestType { get; set; }

    public int? DrugTestStatus { get; set; }

    public int? DrugTestType { get; set; }

    public int? TransportSource { get; set; }

    public int? ActionTakenByOfficer { get; set; }

    public int? NonBusSeatingPosition { get; set; }

    public int? RestraintSystem { get; set; }

    public int? HelmetUse { get; set; }

    public int? AirBagDeployment { get; set; }

    public int? EjectionStatus { get; set; }

    public int? SpeedingRelated { get; set; }

    public int? DriverDistractedBy { get; set; }

    public int? NonMotoristActionOrCircumstancePriorToCrash { get; set; }

    public int? NonMotoristLocationAtTimeOfCrash { get; set; }

    public int? NonmotoristDistractedBy { get; set; }

    public int? NonMotoristActionOrCircumstancePriorToCrashToOrFromSchool { get; set; }

    public string? ConditionOfPersonAtTimeOfCrash { get; set; }

    public string? DriverActions { get; set; }

    public string? SafetyEquipment { get; set; }

    public string? NonMotoristActionsOrCircumstancesAtTimeofCrash { get; set; }

    public string? WitnessStatementType { get; set; }

    public string? WitnessObservationVerification { get; set; }

    public string? WitnessStatementSource { get; set; }

    public string? BusSeatingPosition { get; set; }

    public string? LocationOfNonmotoristDescription { get; set; }

    public bool? NonmotoristWasNotInRoadway { get; set; }

    public string? ViolationCodes { get; set; }

    public string? EmscompanyName { get; set; }

    public string? EmsresponseRunNumber { get; set; }

    public string? NameOfIntendedReceivingFacility { get; set; }

    public bool? DirectionIsUnknown { get; set; }

    public decimal? StrikingMotorVehicleId { get; set; }

    public int? LogTravelingDirection { get; set; }

    public DateTime? DateTimeofDeath { get; set; }

    public bool? IsPossibleLifeThreatening { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual RefCrashReferenceDatum? ActionTakenByOfficerNavigation { get; set; }

    public virtual RefCrashReferenceDatum? AirBagDeploymentNavigation { get; set; }

    public virtual RefCrashReferenceDatum? AlcoholTestStatusNavigation { get; set; }

    public virtual RefCrashReferenceDatum? AlcoholTestTypeNavigation { get; set; }

    public virtual CrashPersonInvolvement CrashPersonInvolvement { get; set; } = null!;

    public virtual RefCrashReferenceDatum? DriverDistractedByNavigation { get; set; }

    public virtual RefCrashReferenceDatum? DrugTestStatusNavigation { get; set; }

    public virtual RefCrashReferenceDatum? DrugTestTypeNavigation { get; set; }

    public virtual RefCrashReferenceDatum? EjectionStatusNavigation { get; set; }

    public virtual RefCrashReferenceDatum? HelmetUseNavigation { get; set; }

    public virtual RefCrashReferenceDatum? InjuryStatusNavigation { get; set; }

    public virtual RefCrashReferenceDatum? LogTravelingDirectionNavigation { get; set; }

    public virtual RefCrashReferenceDatum? NonBusSeatingPositionNavigation { get; set; }

    public virtual RefCrashReferenceDatum? NonMotoristActionOrCircumstancePriorToCrashNavigation { get; set; }

    public virtual RefCrashReferenceDatum? NonMotoristActionOrCircumstancePriorToCrashToOrFromSchoolNavigation { get; set; }

    public virtual RefCrashReferenceDatum? NonMotoristLocationAtTimeOfCrashNavigation { get; set; }

    public virtual RefCrashReferenceDatum? NonmotoristDistractedByNavigation { get; set; }

    public virtual RefCrashReferenceDatum? RestraintSystemNavigation { get; set; }

    public virtual RefCrashReferenceDatum? SpeedingRelatedNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TransportSourceNavigation { get; set; }
}
