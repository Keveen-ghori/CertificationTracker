using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class ServiceCall
{
    public decimal ServiceCallId { get; set; }

    public int? DepartmentId { get; set; }

    public int? CallTypeId { get; set; }

    public decimal? PrimaryLocationId { get; set; }

    public decimal? SecondaryLocationId { get; set; }

    public int? ReportEmployeeId { get; set; }

    public int? ScstatusId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime? ActivityStartDate { get; set; }

    public DateTime? ActivityEndDate { get; set; }

    public int? Cadid { get; set; }

    public DateTime? CallCreatedDate { get; set; }

    public DateTime? CallArrivedDate { get; set; }

    public DateTime? CallClearedDate { get; set; }

    public DateTime? CallDispatchedDate { get; set; }

    public string? CallMechanism { get; set; }

    public string? CallOperator { get; set; }

    public string? AssignedNumber { get; set; }

    public DateTime? ServiceCallTransferDatetime { get; set; }

    public string? CallPriority { get; set; }

    public string? HbfinialCallType { get; set; }

    public string? HbcallType { get; set; }

    public string? CallOriginator { get; set; }

    public string? ReportCode { get; set; }

    public string? Source { get; set; }

    public bool? IsReportRequired { get; set; }

    public string? DispositionCode { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public virtual RefCallForServiceDefinition? CallType { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<EnforcementOfficialUnit> EnforcementOfficialUnits { get; set; } = new List<EnforcementOfficialUnit>();

    public virtual ICollection<NonVerifiedCallPerson> NonVerifiedCallPeople { get; set; } = new List<NonVerifiedCallPerson>();

    public virtual ICollection<NonVerifiedCallVehicle> NonVerifiedCallVehicles { get; set; } = new List<NonVerifiedCallVehicle>();

    public virtual Mstrlocation? PrimaryLocation { get; set; }

    public virtual DepartmentEmployee? ReportEmployee { get; set; }

    public virtual SysApplicationStatus? ReportStatus { get; set; }

    public virtual SysApplicationStatus? Scstatus { get; set; }

    public virtual Mstrlocation? SecondaryLocation { get; set; }

    public virtual ICollection<ServiceCallComment> ServiceCallComments { get; set; } = new List<ServiceCallComment>();

    public virtual ICollection<ServiceCallDisposition> ServiceCallDispositions { get; set; } = new List<ServiceCallDisposition>();

    public virtual ICollection<ServiceCallLog> ServiceCallLogs { get; set; } = new List<ServiceCallLog>();
}
