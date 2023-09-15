using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class RefCrashReferenceDatum
{
    public int RefCrashReferenceDataId { get; set; }

    public int? AgencyId { get; set; }

    public int? DepartmentId { get; set; }

    public string? DisplayString { get; set; }

    public string? Description { get; set; }

    public bool? IsSystemData { get; set; }

    public int? DisplaySeq { get; set; }

    public string? RefCategory { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? DataValue { get; set; }

    public bool? IsDefaultToCategory { get; set; }

    public string? SubRefCategory { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public string? Rptcode { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<Crash> CrashCrashTypeNavigations { get; set; } = new List<Crash>();

    public virtual ICollection<CrashPersonInvolvement> CrashPersonInvolvements { get; set; } = new List<CrashPersonInvolvement>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumActionTakenByOfficerNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumAirBagDeploymentNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumAlcoholTestStatusNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumAlcoholTestTypeNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumDriverDistractedByNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumDrugTestStatusNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumDrugTestTypeNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumEjectionStatusNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumHelmetUseNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumInjuryStatusNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumLogTravelingDirectionNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumNonBusSeatingPositionNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumNonMotoristActionOrCircumstancePriorToCrashNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumNonMotoristActionOrCircumstancePriorToCrashToOrFromSchoolNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumNonMotoristLocationAtTimeOfCrashNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumNonmotoristDistractedByNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumRestraintSystemNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumSpeedingRelatedNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPersonSummaryDatum> CrashPersonSummaryDatumTransportSourceNavigations { get; set; } = new List<CrashPersonSummaryDatum>();

    public virtual ICollection<CrashPropertyInvolvement> CrashPropertyInvolvements { get; set; } = new List<CrashPropertyInvolvement>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumCrashClassificationTrafficwayClassTypeNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumCrashClassificationTrafficwayOwnershipTypeNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumFirstHarmfulEventNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumIsCrashRelatedToAworkZoneNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumLawEnforcementPresenceNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumLightConditionNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumLocFirstHarmfulEventRelativeToTrafficwayNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumLocationOfCrashRelativeToWorkZoneNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumMannerOfCrashCollisionImpactNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumMedianBarrierPenetrationNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumPoliceCaseStatusNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumRelationToJunctionCrashSpecificLocationNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumSchoolBusRelatedNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumSourceOfInformationNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumTrafficSurfaceConditionNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumTypeOfIntersectionNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumTypeOfWorkZoneNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<CrashSummaryDatum> CrashSummaryDatumWorkerPresenceNavigations { get; set; } = new List<CrashSummaryDatum>();

    public virtual ICollection<Crash> CrashTimAttributeCodeNavigations { get; set; } = new List<Crash>();

    public virtual ICollection<CrashVehicleAreaImpact> CrashVehicleAreaImpacts { get; set; } = new List<CrashVehicleAreaImpact>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoCargoBodyTypeNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoCommercialOrNoncommercialNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoGrossVehicleWeightRatingNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoHazardousMaterialsPlacardDisplayNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoVehicleConfigurationNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoWereHazardousMaterialsReleasedNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleInvolvement> CrashVehicleInvolvements { get; set; } = new List<CrashVehicleInvolvement>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumBusUseNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumDirectionOfTravelBeforeCrashNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumEmergencyVehicleUseNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumMostHarmfulEventForThisVehicleNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumPostedStatutorySpeedLimitNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumRoadwayAlignmentNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumRoadwayGradeNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumSpecialFunctionOfVehicleInOperationNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumTowedNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumTrafficControlDeviceStatusNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumTrafficControlDeviceTypeNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumTrafficwayDescriptionNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumUnitTypeNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumVehicleActionNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumVehicleBodyTypeNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual ICollection<CrashVehicleSummaryDatum> CrashVehicleSummaryDatumVehicleDamageExtentOfVehicleDamageNavigations { get; set; } = new List<CrashVehicleSummaryDatum>();

    public virtual Department? Department { get; set; }
}
