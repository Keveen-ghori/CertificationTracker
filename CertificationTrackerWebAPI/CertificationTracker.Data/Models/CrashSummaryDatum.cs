using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class CrashSummaryDatum
{
    public decimal CrashId { get; set; }

    public int? CrashClassificationTrafficwayClassType { get; set; }

    public int? CrashClassificationTrafficwayOwnershipType { get; set; }

    public int? FirstHarmfulEvent { get; set; }

    public int? MannerOfCrashCollisionImpact { get; set; }

    public int? LightCondition { get; set; }

    public int? TrafficSurfaceCondition { get; set; }

    public int? TypeOfIntersection { get; set; }

    public int? SchoolBusRelated { get; set; }

    public int? RelationToJunctionCrashSpecificLocation { get; set; }

    public int? IsCrashRelatedToAworkZone { get; set; }

    public int? LocationOfCrashRelativeToWorkZone { get; set; }

    public int? TypeOfWorkZone { get; set; }

    public int? WorkerPresence { get; set; }

    public int? LawEnforcementPresence { get; set; }

    public int? UnitOfMeasure { get; set; }

    public int? DirectionFromNearestLandmark { get; set; }

    public int? SourceOfInformation { get; set; }

    public string? WeatherCondition { get; set; }

    public string? ContributingCircumstancesEnvironment { get; set; }

    public string? ContributingCircumstancesRoad { get; set; }

    public double? DistanceFromNearestLandmark { get; set; }

    public string? DescriptionOfNearestLandmark { get; set; }

    public string? CrashDrawingApplicationSting { get; set; }

    public byte[]? CrashDrawingApplicationImage { get; set; }

    public bool? WereVehiclesMovedPriorToPoliceArrival { get; set; }

    public int? MedianBarrierPenetration { get; set; }

    public bool? IsSosactivated { get; set; }

    public bool? IsContactBoardEdnotified { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public int? LocFirstHarmfulEventRelativeToTrafficway { get; set; }

    public int? PoliceCaseStatus { get; set; }

    public string? PoliceCaseStatusComment { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? MapX { get; set; }

    public double? MapY { get; set; }

    public string? NotInStreetList { get; set; }

    public string? CrashOccurredOnStreet { get; set; }

    public decimal? CrashOccurredOnStreetId { get; set; }

    public string? IntersectionStreet1 { get; set; }

    public decimal? IntersectionStreet1Id { get; set; }

    public virtual Crash Crash { get; set; } = null!;

    public virtual RefCrashReferenceDatum? CrashClassificationTrafficwayClassTypeNavigation { get; set; }

    public virtual RefCrashReferenceDatum? CrashClassificationTrafficwayOwnershipTypeNavigation { get; set; }

    public virtual RefMiscReferenceDatum? DirectionFromNearestLandmarkNavigation { get; set; }

    public virtual RefCrashReferenceDatum? FirstHarmfulEventNavigation { get; set; }

    public virtual RefCrashReferenceDatum? IsCrashRelatedToAworkZoneNavigation { get; set; }

    public virtual RefCrashReferenceDatum? LawEnforcementPresenceNavigation { get; set; }

    public virtual RefCrashReferenceDatum? LightConditionNavigation { get; set; }

    public virtual RefCrashReferenceDatum? LocFirstHarmfulEventRelativeToTrafficwayNavigation { get; set; }

    public virtual RefCrashReferenceDatum? LocationOfCrashRelativeToWorkZoneNavigation { get; set; }

    public virtual RefCrashReferenceDatum? MannerOfCrashCollisionImpactNavigation { get; set; }

    public virtual RefCrashReferenceDatum? MedianBarrierPenetrationNavigation { get; set; }

    public virtual RefCrashReferenceDatum? PoliceCaseStatusNavigation { get; set; }

    public virtual RefCrashReferenceDatum? RelationToJunctionCrashSpecificLocationNavigation { get; set; }

    public virtual RefCrashReferenceDatum? SchoolBusRelatedNavigation { get; set; }

    public virtual RefCrashReferenceDatum? SourceOfInformationNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TrafficSurfaceConditionNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TypeOfIntersectionNavigation { get; set; }

    public virtual RefCrashReferenceDatum? TypeOfWorkZoneNavigation { get; set; }

    public virtual RefMiscReferenceDatum? UnitOfMeasureNavigation { get; set; }

    public virtual RefCrashReferenceDatum? WorkerPresenceNavigation { get; set; }
}
