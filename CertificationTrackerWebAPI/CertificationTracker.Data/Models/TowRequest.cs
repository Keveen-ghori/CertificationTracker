using System;
using System.Collections.Generic;

namespace CertificationTracker.Data.Models;

public partial class TowRequest
{
    public decimal TowRequestId { get; set; }

    public decimal? TowFromLocationId { get; set; }

    public decimal? TowToLocationId { get; set; }

    public int? ReportedEmployeeId { get; set; }

    public decimal? TowCompanyAddressDirecctoryId { get; set; }

    public string? TowTypeCode { get; set; }

    public decimal? NonVerifiedCallVehicleId { get; set; }

    public int? NotifiedBy { get; set; }

    public string? TowStatus { get; set; }

    public string? TowNumber { get; set; }

    public DateTime? StatusDateTime { get; set; }

    public int? DepartmentId { get; set; }

    public Guid? UniqueId { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? EditedOn { get; set; }

    public string? AddedName { get; set; }

    public string? EditedName { get; set; }

    public bool? IsHold { get; set; }

    public bool? IsConcensusTow { get; set; }

    public string? Comment { get; set; }

    public bool? OwnerNotified { get; set; }

    public DateTime? DateNotified { get; set; }

    public string? TowAuthorizedBy { get; set; }

    public string? TowReason { get; set; }

    public string? HoldAuthorizationBy { get; set; }

    public virtual ICollection<CrashVehicleInvolvement> CrashVehicleInvolvements { get; set; } = new List<CrashVehicleInvolvement>();

    public virtual ICollection<FieldInterviewVehicleInvolvment> FieldInterviewVehicleInvolvments { get; set; } = new List<FieldInterviewVehicleInvolvment>();

    public virtual ICollection<IncidentVehicleInvolvement> IncidentVehicleInvolvements { get; set; } = new List<IncidentVehicleInvolvement>();

    public virtual NonVerifiedCallVehicle? NonVerifiedCallVehicle { get; set; }

    public virtual DepartmentEmployee? NotifiedByNavigation { get; set; }

    public virtual DepartmentEmployee? ReportedEmployee { get; set; }

    public virtual AddressDirecctory? TowCompanyAddressDirecctory { get; set; }

    public virtual Mstrlocation? TowFromLocation { get; set; }

    public virtual Mstrlocation? TowToLocation { get; set; }

    public virtual ICollection<TrafficStop> TrafficStops { get; set; } = new List<TrafficStop>();
}
