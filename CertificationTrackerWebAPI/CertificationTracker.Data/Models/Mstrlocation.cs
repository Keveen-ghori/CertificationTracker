using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Mstrlocation
{
    public decimal LocationId { get; set; }

    public int? CadimportDepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public string LocationType { get; set; } = null!;

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? MapX { get; set; }

    public double? MapY { get; set; }

    public string? LocationCode { get; set; }

    public string? HouseNumber { get; set; }

    public string? Location { get; set; }

    public string? Apartment { get; set; }

    public string? Floor { get; set; }

    public string? Building { get; set; }

    public string? Unit { get; set; }

    public string? Suite { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public bool? IsGeoValidated { get; set; }

    public string? LocationShortDisplayString { get; set; }

    public string? LocationDetailDisplayString { get; set; }

    public string? ClosestStreet { get; set; }

    public string? AliasName { get; set; }

    public string? Zip { get; set; }

    public string? County { get; set; }

    public int? GeoCodeRank { get; set; }

    public string? GeoCoderInfo { get; set; }

    public int? HouseNumberInt { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Pobox { get; set; }

    public Guid? UniqueId { get; set; }

    public string? CopiedFromSource { get; set; }

    public string? CopiedFromLocationId { get; set; }

    public DateTime? CopiedOn { get; set; }

    public string? CopiedByName { get; set; }

    public string? Country { get; set; }

    public int? CadlocationId { get; set; }

    public string? Description { get; set; }

    public string? NewShortDetailDisplaystring { get; set; }

    public string? NewDetailDisplystring { get; set; }

    public decimal? StreetId { get; set; }

    public bool? IsOutOfTownLocation { get; set; }

    public decimal? MstrlocationPointId { get; set; }

    public decimal? MstrstreetSegmentId { get; set; }

    public decimal? KtpsAgencyId { get; set; }

    public virtual ICollection<AddressDirecctory> AddressDirecctories { get; set; } = new List<AddressDirecctory>();

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookingArrestLocations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingBookingLocations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingOffenseLocations { get; set; } = new List<ArrestBooking>();

    public virtual Department? CadimportDepartment { get; set; }

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoCarrierAddressNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoPowerUnitInformationOwnerAddressNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<CrashVehicleCommericalInfo> CrashVehicleCommericalInfoTrailerInformationInformationOwnerAddressNavigations { get; set; } = new List<CrashVehicleCommericalInfo>();

    public virtual ICollection<Crash> Crashes { get; set; } = new List<Crash>();

    public virtual ICollection<CustodyLog> CustodyLogs { get; set; } = new List<CustodyLog>();

    public virtual ICollection<FieldInterview> FieldInterviews { get; set; } = new List<FieldInterview>();

    public virtual ICollection<HelpQueryLocationInvolvement> HelpQueryLocationInvolvements { get; set; } = new List<HelpQueryLocationInvolvement>();

    public virtual ICollection<IncidentOutOfTownWarrant> IncidentOutOfTownWarrants { get; set; } = new List<IncidentOutOfTownWarrant>();

    public virtual ICollection<IncidentPropertyInvolvement> IncidentPropertyInvolvements { get; set; } = new List<IncidentPropertyInvolvement>();

    public virtual ICollection<IncidentReportTypeDetail> IncidentReportTypeDetails { get; set; } = new List<IncidentReportTypeDetail>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual ICollection<LocationGisinformation> LocationGisinformations { get; set; } = new List<LocationGisinformation>();

    public virtual ICollection<MstrlocationAlert> MstrlocationAlerts { get; set; } = new List<MstrlocationAlert>();

    public virtual ICollection<MstrlocationImage> MstrlocationImages { get; set; } = new List<MstrlocationImage>();

    public virtual ICollection<MstrlocationRelatedMedium> MstrlocationRelatedMedia { get; set; } = new List<MstrlocationRelatedMedium>();

    public virtual ICollection<Mstrorganization> MstrorganizationPrimaryLocations { get; set; } = new List<Mstrorganization>();

    public virtual ICollection<Mstrorganization> MstrorganizationSecondaryLocations { get; set; } = new List<Mstrorganization>();

    public virtual ICollection<MstrpersonLocation> MstrpersonLocationMailLocations { get; set; } = new List<MstrpersonLocation>();

    public virtual ICollection<MstrpersonLocation> MstrpersonLocationResidenceLocs { get; set; } = new List<MstrpersonLocation>();

    public virtual ICollection<MstrpersonLocation> MstrpersonLocationSecondaryResidenceLocs { get; set; } = new List<MstrpersonLocation>();

    public virtual ICollection<MstrvehicleStatus> MstrvehicleStatuses { get; set; } = new List<MstrvehicleStatus>();

    public virtual ICollection<NonVerifiedCallPerson> NonVerifiedCallPeople { get; set; } = new List<NonVerifiedCallPerson>();

    public virtual ICollection<ServiceCall> ServiceCallPrimaryLocations { get; set; } = new List<ServiceCall>();

    public virtual ICollection<ServiceCall> ServiceCallSecondaryLocations { get; set; } = new List<ServiceCall>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TowRequest> TowRequestTowFromLocations { get; set; } = new List<TowRequest>();

    public virtual ICollection<TowRequest> TowRequestTowToLocations { get; set; } = new List<TowRequest>();

    public virtual ICollection<TrafficStop> TrafficStopOffenseLocations { get; set; } = new List<TrafficStop>();

    public virtual ICollection<TrafficStop> TrafficStopTrafficStopLocations { get; set; } = new List<TrafficStop>();

    public virtual ICollection<WarrantAttempt> WarrantAttempts { get; set; } = new List<WarrantAttempt>();
}
