using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashVehicleSummaryDatum
{
    public decimal CrashVehicleInvolvementId { get; set; }

    public int? UnitType { get; set; }

    public int? SpecialFunctionOfVehicleInOperation { get; set; }

    public int? EmergencyVehicleUse { get; set; }

    public int? PostedStatutorySpeedLimit { get; set; }

    public int? DirectionOfTravelBeforeCrash { get; set; }

    public int? TrafficwayDescription { get; set; }

    public int? RoadwayAlignment { get; set; }

    public int? RoadwayGrade { get; set; }

    public int? TrafficControlDeviceType { get; set; }

    public int? TrafficControlDeviceStatus { get; set; }

    public int? VehicleAction { get; set; }

    public int? VehicleDamageExtentOfVehicleDamage { get; set; }

    public int? MostHarmfulEventForThisVehicle { get; set; }

    public int? Towed { get; set; }

    public int? VehicleBodyType { get; set; }

    public int? BusUse { get; set; }

    public bool? VehicleOwnerInformationSameAsDriver { get; set; }

    public int? TotalOccupantsInVehicle { get; set; }

    public bool? DirectionOfTravelBeforeCrashIsUnknown { get; set; }

    public int? TotalLanesInRoadway { get; set; }

    public string? SequenceOfEvents { get; set; }

    public bool? HitAndRunStatus { get; set; }

    public string? ContributingCircumstancesVehicle { get; set; }

    public bool? WasSerialNumberRemoved { get; set; }

    public bool? WereBikeLanesOrSharrowsPresent { get; set; }

    public string? NameOfRoadwayOnWhichVehicleWasTraveling { get; set; }

    public bool? VehicleWasNotOnRoadway { get; set; }

    public bool? MotorVehicleRegistrationWasInvalid { get; set; }

    public bool? MotorVehicleRegistrationPlateWasMissing { get; set; }

    public string? NameOfIssuingInsuranceCompany { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool? IsConsentualTow { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual RefCrashReferenceDatum? BusUseNavigation { get; set; }

    public virtual CrashVehicleInvolvement CrashVehicleInvolvement { get; set; } = null!;

    public virtual RefCrashReferenceDatum? DirectionOfTravelBeforeCrashNavigation { get; set; }

    public virtual RefCrashReferenceDatum? EmergencyVehicleUseNavigation { get; set; }

    public virtual RefCrashReferenceDatum? MostHarmfulEventForThisVehicleNavigation { get; set; }

    public virtual RefCrashReferenceDatum? PostedStatutorySpeedLimitNavigation { get; set; }

    public virtual RefCrashReferenceDatum? RoadwayAlignmentNavigation { get; set; }

    public virtual RefCrashReferenceDatum? RoadwayGradeNavigation { get; set; }

    public virtual RefCrashReferenceDatum? SpecialFunctionOfVehicleInOperationNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TowedNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TrafficControlDeviceStatusNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TrafficControlDeviceTypeNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TrafficwayDescriptionNavigation { get; set; }

    public virtual RefCrashReferenceDatum? UnitTypeNavigation { get; set; }

    public virtual RefCrashReferenceDatum? VehicleActionNavigation { get; set; }

    public virtual RefCrashReferenceDatum? VehicleBodyTypeNavigation { get; set; }

    public virtual RefCrashReferenceDatum? VehicleDamageExtentOfVehicleDamageNavigation { get; set; }
}
