using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class SysApplicationStatus
{
    public int SysApplicationStatusId { get; set; }

    public int? SysrmsapplicationTypeId { get; set; }

    public string? Status { get; set; }

    public int? Duration { get; set; }

    public string? NotificationXml { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? Color { get; set; }

    public int? Sequence { get; set; }

    public string? DataValue { get; set; }

    public int? DepartmentId { get; set; }

    public int? RefDepartmentOverrideFrom { get; set; }

    public virtual ICollection<ArrestBooking> ArrestBookingFingerPrintStatusNavigations { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingReportStatuses { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<ArrestBooking> ArrestBookingStatuses { get; set; } = new List<ArrestBooking>();

    public virtual ICollection<Crash> CrashCrashStatuses { get; set; } = new List<Crash>();

    public virtual ICollection<CrashGeneratedReport> CrashGeneratedReportCrashStatusNavigations { get; set; } = new List<CrashGeneratedReport>();

    public virtual ICollection<CrashGeneratedReport> CrashGeneratedReportReportStatusNavigations { get; set; } = new List<CrashGeneratedReport>();

    public virtual ICollection<Crash> CrashReportStatuses { get; set; } = new List<Crash>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<DispositionsChargesImport> DispositionsChargesImports { get; set; } = new List<DispositionsChargesImport>();

    public virtual ICollection<DispositionsImport> DispositionsImports { get; set; } = new List<DispositionsImport>();

    public virtual ICollection<FieldInterview> FieldInterviews { get; set; } = new List<FieldInterview>();

    public virtual ICollection<IncidentGeneratedReport> IncidentGeneratedReportIncidentStatusNavigations { get; set; } = new List<IncidentGeneratedReport>();

    public virtual ICollection<IncidentGeneratedReport> IncidentGeneratedReportReportStatusNavigations { get; set; } = new List<IncidentGeneratedReport>();

    public virtual ICollection<Incident> IncidentIncidentStatuses { get; set; } = new List<Incident>();

    public virtual ICollection<IncidentInvestigationManagement> IncidentInvestigationManagements { get; set; } = new List<IncidentInvestigationManagement>();

    public virtual ICollection<Incident> IncidentReportStatuses { get; set; } = new List<Incident>();

    public virtual ICollection<PhotoLineup> PhotoLineups { get; set; } = new List<PhotoLineup>();

    public virtual ICollection<PropertyCustodyTracking> PropertyCustodyTrackings { get; set; } = new List<PropertyCustodyTracking>();

    public virtual ICollection<PropertyRoomItem> PropertyRoomItemItemStatusNavigations { get; set; } = new List<PropertyRoomItem>();

    public virtual ICollection<PropertyRoomItem> PropertyRoomItemReportStatusNavigations { get; set; } = new List<PropertyRoomItem>();

    public virtual ICollection<RmsapplicationActionTrace> RmsapplicationActionTraceApplicationStatuses { get; set; } = new List<RmsapplicationActionTrace>();

    public virtual ICollection<RmsapplicationActionTrace> RmsapplicationActionTraceInvestigativeStatuses { get; set; } = new List<RmsapplicationActionTrace>();

    public virtual ICollection<RmsapplicationActionTrace> RmsapplicationActionTraceReportStatusStatuses { get; set; } = new List<RmsapplicationActionTrace>();

    public virtual ICollection<RmsuserQueryResult> RmsuserQueryResults { get; set; } = new List<RmsuserQueryResult>();

    public virtual ICollection<RmsworkFlowDef> RmsworkFlowDefPendingApplicationStatuses { get; set; } = new List<RmsworkFlowDef>();

    public virtual ICollection<RmsworkFlowDef> RmsworkFlowDefPendingReportStatuses { get; set; } = new List<RmsworkFlowDef>();

    public virtual ICollection<RmsworkFlowDef> RmsworkFlowDefReviewingApplicationStatuses { get; set; } = new List<RmsworkFlowDef>();

    public virtual ICollection<RmsworkFlowDef> RmsworkFlowDefReviewingReportStatuses { get; set; } = new List<RmsworkFlowDef>();

    public virtual ICollection<ServiceCall> ServiceCallReportStatuses { get; set; } = new List<ServiceCall>();

    public virtual ICollection<ServiceCall> ServiceCallScstatuses { get; set; } = new List<ServiceCall>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditionApplicationStatuses { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditionInvestigativeStatuses { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<SysNotificationCondition> SysNotificationConditionReportStatuses { get; set; } = new List<SysNotificationCondition>();

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUiApplicationStatuses { get; set; } = new List<SysapplicationStatusAllowedUi>();

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUiInvestgativeStatuses { get; set; } = new List<SysapplicationStatusAllowedUi>();

    public virtual ICollection<SysapplicationStatusAllowedUi> SysapplicationStatusAllowedUiReportStatuses { get; set; } = new List<SysapplicationStatusAllowedUi>();

    public virtual SysrmsapplicationType? SysrmsapplicationType { get; set; }

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();

    public virtual ICollection<WarrantGeneratedReport> WarrantGeneratedReportReportStatusNavigations { get; set; } = new List<WarrantGeneratedReport>();

    public virtual ICollection<WarrantGeneratedReport> WarrantGeneratedReportWarrantStatusNavigations { get; set; } = new List<WarrantGeneratedReport>();

    public virtual ICollection<Warrant> WarrantReportStatuses { get; set; } = new List<Warrant>();

    public virtual ICollection<Warrant> WarrantWarrantStatuses { get; set; } = new List<Warrant>();

    public virtual ICollection<WfallowedUi> WfallowedUiApplicationStatuses { get; set; } = new List<WfallowedUi>();

    public virtual ICollection<WfallowedUi> WfallowedUiReportStatuses { get; set; } = new List<WfallowedUi>();
}
