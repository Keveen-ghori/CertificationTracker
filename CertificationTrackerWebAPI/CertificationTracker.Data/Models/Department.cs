using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public int? AgencyId { get; set; }

    public int? DefaultCourt { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsDispatchable { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? TownCode { get; set; }

    public string? DepartmentAttributesXml { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Image { get; set; }

    public string? StateOri { get; set; }

    public string? CodingSystem { get; set; }

    public string? MapConfiguration { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public int? CaddefaultDepartmentEmployeeId { get; set; }

    public string? SearchOtherTownSetting { get; set; }

    public virtual SysAgency? Agency { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookings { get; set; } = new List<ArrestBooking>();

    public virtual DepartmentEmployee? CaddefaultDepartmentEmployee { get; set; }

    public virtual ICollection<Crash> Crashes { get; set; } = new List<Crash>();

    public virtual ICollection<DataProcessStepDataItem> DataProcessStepDataItems { get; set; } = new List<DataProcessStepDataItem>();

    public virtual ICollection<DataProcess> DataProcesses { get; set; } = new List<DataProcess>();

    public virtual RefIncidentReferenceDatum? DefaultCourtNavigation { get; set; }

    public virtual ICollection<DepApplicationUsage> DepApplicationUsages { get; set; } = new List<DepApplicationUsage>();

    public virtual ICollection<DepartmentDailyRoster> DepartmentDailyRosters { get; set; } = new List<DepartmentDailyRoster>();

    public virtual ICollection<DepartmentEmployee> DepartmentEmployees { get; set; } = new List<DepartmentEmployee>();

    public virtual ICollection<DepartmentGisgeometry> DepartmentGisgeometries { get; set; } = new List<DepartmentGisgeometry>();

    public virtual ICollection<DepartmentGislayer> DepartmentGislayers { get; set; } = new List<DepartmentGislayer>();

    public virtual ICollection<DepartmentOrg> DepartmentOrgs { get; set; } = new List<DepartmentOrg>();

    public virtual ICollection<DepartmentUnitShiftGroup> DepartmentUnitShiftGroups { get; set; } = new List<DepartmentUnitShiftGroup>();

    public virtual ICollection<DepartmentUnitType> DepartmentUnitTypes { get; set; } = new List<DepartmentUnitType>();

    public virtual ICollection<DepartmentUnit> DepartmentUnits { get; set; } = new List<DepartmentUnit>();

    public virtual ICollection<DepartmentVehicle> DepartmentVehicles { get; set; } = new List<DepartmentVehicle>();

    public virtual ICollection<DispositionSpecialProcess> DispositionSpecialProcesses { get; set; } = new List<DispositionSpecialProcess>();

    public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; } = new List<EmployeeHistory>();

    public virtual ICollection<EmployeeWorkingLog> EmployeeWorkingLogs { get; set; } = new List<EmployeeWorkingLog>();

    public virtual ICollection<FieldInterview> FieldInterviews { get; set; } = new List<FieldInterview>();

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();

    public virtual ICollection<JuvenileBookingDetail> JuvenileBookingDetails { get; set; } = new List<JuvenileBookingDetail>();

    public virtual ICollection<Mstrlocation> Mstrlocations { get; set; } = new List<Mstrlocation>();

    public virtual ICollection<NibrsexportHistory> NibrsexportHistories { get; set; } = new List<NibrsexportHistory>();

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual ICollection<PhotoLineupPhoto> PhotoLineupPhotos { get; set; } = new List<PhotoLineupPhoto>();

    public virtual ICollection<Postarea> Postareas { get; set; } = new List<Postarea>();

    public virtual ICollection<Postcourse> Postcourses { get; set; } = new List<Postcourse>();

    public virtual ICollection<PostoutSideInstructor> PostoutSideInstructors { get; set; } = new List<PostoutSideInstructor>();

    public virtual ICollection<PropertyRoomItem> PropertyRoomItems { get; set; } = new List<PropertyRoomItem>();

    public virtual ICollection<RefCallForServiceDefinition> RefCallForServiceDefinitions { get; set; } = new List<RefCallForServiceDefinition>();

    public virtual ICollection<RefCallPriority> RefCallPriorities { get; set; } = new List<RefCallPriority>();

    public virtual ICollection<RefCrashReferenceDatum> RefCrashReferenceData { get; set; } = new List<RefCrashReferenceDatum>();

    public virtual ICollection<RefDispositionCode> RefDispositionCodes { get; set; } = new List<RefDispositionCode>();

    public virtual ICollection<RefDrugDatum> RefDrugData { get; set; } = new List<RefDrugDatum>();

    public virtual ICollection<RefIncidentReferenceDatum> RefIncidentReferenceData { get; set; } = new List<RefIncidentReferenceDatum>();

    public virtual ICollection<RefMiscReferenceDatum> RefMiscReferenceData { get; set; } = new List<RefMiscReferenceDatum>();

    public virtual ICollection<RefMstrinxreferenceDatum> RefMstrinxreferenceData { get; set; } = new List<RefMstrinxreferenceDatum>();

    public virtual ICollection<RefNarrativeTemplate> RefNarrativeTemplates { get; set; } = new List<RefNarrativeTemplate>();

    public virtual ICollection<RefNibrscodeDefinition> RefNibrscodeDefinitions { get; set; } = new List<RefNibrscodeDefinition>();

    public virtual ICollection<RefOffenseCodeDefinition> RefOffenseCodeDefinitions { get; set; } = new List<RefOffenseCodeDefinition>();

    public virtual ICollection<RefPropertyDatum> RefPropertyData { get; set; } = new List<RefPropertyDatum>();

    public virtual ICollection<RefStatuteDefinition> RefStatuteDefinitions { get; set; } = new List<RefStatuteDefinition>();

    public virtual ICollection<RefTrafficStopTicketReferenceDatum> RefTrafficStopTicketReferenceData { get; set; } = new List<RefTrafficStopTicketReferenceDatum>();

    public virtual ICollection<RefUcrcodeDefinition> RefUcrcodeDefinitions { get; set; } = new List<RefUcrcodeDefinition>();

    public virtual ICollection<RefViolation> RefViolations { get; set; } = new List<RefViolation>();

    public virtual ICollection<ReportContainer> ReportContainers { get; set; } = new List<ReportContainer>();

    public virtual ICollection<RestoreCancelledApplicationDatum> RestoreCancelledApplicationData { get; set; } = new List<RestoreCancelledApplicationDatum>();

    public virtual ICollection<RmsapplicationDataExportLog> RmsapplicationDataExportLogs { get; set; } = new List<RmsapplicationDataExportLog>();

    public virtual ICollection<RmsdataProcessController> RmsdataProcessControllers { get; set; } = new List<RmsdataProcessController>();

    public virtual ICollection<RmsdeptWorkFlow> RmsdeptWorkFlows { get; set; } = new List<RmsdeptWorkFlow>();

    public virtual ICollection<RmsworkFlowController> RmsworkFlowControllers { get; set; } = new List<RmsworkFlowController>();

    public virtual ICollection<SecurityObject> SecurityObjects { get; set; } = new List<SecurityObject>();

    public virtual ICollection<SecurityRole> SecurityRoles { get; set; } = new List<SecurityRole>();

    public virtual ICollection<ServiceCall> ServiceCalls { get; set; } = new List<ServiceCall>();

    public virtual ICollection<SysApplicationStatus> SysApplicationStatuses { get; set; } = new List<SysApplicationStatus>();

    public virtual ICollection<SysImage> SysImages { get; set; } = new List<SysImage>();

    public virtual ICollection<SysNotificationAction> SysNotificationActions { get; set; } = new List<SysNotificationAction>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditions { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<SysNotificationPlan> SysNotificationPlans { get; set; } = new List<SysNotificationPlan>();

    public virtual ICollection<SysNumberAssignment> SysNumberAssignments { get; set; } = new List<SysNumberAssignment>();

    public virtual ICollection<SysNumberController> SysNumberControllers { get; set; } = new List<SysNumberController>();

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUis { get; set; } = new List<SysapplicationStatusAllowedUi>();

    public virtual ICollection<SysrmsuserInterfaceDefinition> SysrmsuserInterfaceDefinitions { get; set; } = new List<SysrmsuserInterfaceDefinition>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<Warrant> Warrants { get; set; } = new List<Warrant>();
}
